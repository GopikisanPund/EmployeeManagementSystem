using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class EmpployeeRegisterationForm : Form
    {
        // Connection string to the database
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public EmpployeeRegisterationForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please enter the record to insert", "No Record enter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((string.IsNullOrEmpty(txtID.Text) == true))
            {
                txtID.Focus();
                errorProvider1.SetError(this.txtID, "Please Enter ID");
            }
            else if ((string.IsNullOrEmpty(txtName.Text)) == true)
            {
                txtName.Focus();
                errorProvider2.SetError(this.txtName, "Please Enter Name");
            }
            else if (CombDesignition.SelectedItem == null)
            {
                CombDesignition.Focus();
                errorProvider3.SetError(this.CombDesignition, "Please select Designation");
            }
            else if (string.IsNullOrEmpty(txtSalary.Text) == true)
            {
                txtSalary.Focus();
                errorProvider4.SetError(this.CombDesignition, "Please Enter Salary");
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();

                // Establish a connection to the database
                using (OleDbConnection con = new OleDbConnection(cs))
                {
                    try
                    {
                        con.Open();

                        string query2 = "select * from employee where id=@id";

                        OleDbCommand cmd2 = new OleDbCommand(query2, con);

                        cmd2.Parameters.AddWithValue("@id", txtID.Text);

                        OleDbDataReader dr = cmd2.ExecuteReader();

                        if (dr.HasRows == true)
                        {
                            MessageBox.Show(txtID + "ID is already exist", "Please check the ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // SQL query to insert data into the 'employee' table
                            string query1 = "insert into employee values (@id, @ename, @age, @designation, @salary)";

                            // Create a command object and add parameters to prevent SQL injection
                            using (OleDbCommand cmd = new OleDbCommand(query1, con))
                            {
                                cmd.Parameters.AddWithValue("@id", txtID.Text);
                                cmd.Parameters.AddWithValue("@ename", txtName.Text);
                                cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
                                cmd.Parameters.AddWithValue("@designation", CombDesignition.Text);
                                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);

                                // Execute the query and get the number of affected rows
                                int a = cmd.ExecuteNonQuery();

                                // Display a success or failure message based on the result
                                if (a > 0)
                                {
                                    MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Record failed to save", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                con.Close();
                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        // Handle database-related errors
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Reset the form controls to their initial state
        public void reset()
        {

            txtID.Clear();
            txtName.Clear();
            decimal minValue = numericUpDown1.Minimum;
            decimal maxValue = numericUpDown1.Maximum;

            // Set the value to the minimum if it's less than the minimum, or the maximum if it's greater than the maximum
            numericUpDown1.Value = Math.Max(minValue, Math.Min(maxValue, numericUpDown1.Value));
            CombDesignition.Text = null;
            txtSalary.Clear();
            txtID.Focus();
        }

        // Retrieve data from the database and display it in the DataGridView
        void display()
        {
            using (OleDbConnection con = new OleDbConnection(cs))
            {
                string query = "Select * from employee";

                // Create a data adapter to fetch data from the database
                using (OleDbDataAdapter da = new OleDbDataAdapter(query, con))
                {
                    // Create a DataTable to store the retrieved data
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Display the data in the DataGridView
                    dataGridView.DataSource = dt;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnReset.Text))
            {
                MessageBox.Show("Please select a record to  reset", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Display all data in the DataGridView and reset the form controls
            display();
            reset();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // Display all data in the DataGridfView
            display();
        }

        // Handle the double-click event on the DataGridView
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    // Get the index of the selected row
                    int selectedIndex = dataGridView.SelectedRows[0].Index;

                    // Check if the index is within the valid range
                    if (selectedIndex >= 0 && selectedIndex < dataGridView.RowCount)
                    {
                        // Populate the form controls with data from the selected row
                        txtID.Text = dataGridView.Rows[selectedIndex].Cells[0].Value?.ToString();
                        txtName.Text = dataGridView.Rows[selectedIndex].Cells[1].Value?.ToString();
                        numericUpDown1.Value = Convert.ToDecimal(dataGridView.Rows[selectedIndex].Cells[2].Value?.ToString());
                        CombDesignition.Text = dataGridView.Rows[selectedIndex].Cells[3].Value?.ToString();
                        txtSalary.Text = dataGridView.Rows[selectedIndex].Cells[4].Value?.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selected row index. Please select a valid row before double-clicking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row before double-clicking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                // Handle the case where conversion fails (e.g., non-numeric value in a numeric field).
                MessageBox.Show("Invalid data format. Please check the selected row data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other unexpected exceptions.
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select a record to update", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Establish a connection to the database
            using (OleDbConnection con = new OleDbConnection(cs))
            {
                try
                {
                    con.Open();

                    // SQL query to update data in the 'employee' table
                    string query1 = "UPDATE employee SET id = @id, ename = @ename, age = @age, designation = @designation, salary = @salary WHERE id = @id";

                    // Create a command object and add parameters to prevent SQL injection
                    using (OleDbCommand cmd = new OleDbCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        cmd.Parameters.AddWithValue("@ename", txtName.Text);
                        if (numericUpDown1.Minimum <= numericUpDown1.Value && numericUpDown1.Value <= numericUpDown1.Maximum)
                        {
                            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@age", Math.Max(numericUpDown1.Minimum, Math.Min(numericUpDown1.Maximum, numericUpDown1.Value)));
                        }

                        cmd.Parameters.AddWithValue("@designation", CombDesignition.Text);
                        cmd.Parameters.AddWithValue("@salary", txtSalary.Text);

                        // Execute the query and get the number of affected rows
                        int a = cmd.ExecuteNonQuery();

                        // Display a success or failure message based on the result
                        if (a > 0)
                        {
                            MessageBox.Show("Record Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            display();
                            reset();
                        }
                        else
                        {
                            MessageBox.Show("Record failed to update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
                    }
                }
                catch (OleDbException ex)
                {
                    // Handle database-related errors
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select a record to Delete", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Establish a connection to the database
            using (OleDbConnection con = new OleDbConnection(cs))
            {
                try
                {
                    con.Open();

                    // SQL query to update data in the 'employee' table
                    string query1 = "DELETE FROM employee WHERE id = @id";

                    // Create a command object and add parameters to prevent SQL injection
                    using (OleDbCommand cmd = new OleDbCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        cmd.Parameters.AddWithValue("@ename", txtName.Text);
                        if (numericUpDown1.Minimum <= numericUpDown1.Value && numericUpDown1.Value <= numericUpDown1.Maximum)
                        {
                            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@age", Math.Max(numericUpDown1.Minimum, Math.Min(numericUpDown1.Maximum, numericUpDown1.Value)));
                        }

                        cmd.Parameters.AddWithValue("@designation", CombDesignition.Text);
                        cmd.Parameters.AddWithValue("@salary", txtSalary.Text);

                        // Execute the query and get the number of affected rows
                        int a = cmd.ExecuteNonQuery();

                        // Display a success or failure message based on the result
                        if (a > 0)
                        {
                            MessageBox.Show("Record delete successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            display();
                            reset();
                        }
                        else
                        {
                            MessageBox.Show("Record failed to delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
                catch (OleDbException ex)
                {
                    // Handle database-related errors
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();

            string query="select * from employee where ename like @ename  + '%'";

            OleDbDataAdapter da = new OleDbDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ename",txtSearch.Text.Trim());

            DataTable dt= new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView.DataSource = dt;
            }
            else
            {

                MessageBox.Show("No Record Findout!!!!!!!");
                dataGridView.DataSource=null;
            }
        }
    }
}
