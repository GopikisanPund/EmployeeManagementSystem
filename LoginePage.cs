using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class LoginePage : Form
    {
    //    //private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
          string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;


        public LoginePage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if username or password is empty
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //exit the method early
                 return; 
            }
            //check if one txtbox is empty 
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //exit the method early
                return;
            }

            OleDbConnection con = null;

            try
            {
                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\C#_Project\\EmployeeManagementSystem\\Database\\Database1.accdb");
                con.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT * FROM LoginTable WHERE Username=@user AND Password=@pass", con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                using (OleDbDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        //calling form 4 
                        EmpployeeRegisterationForm form4 = new EmpployeeRegisterationForm();
                        form4.Show();
                        this.Hide();                    
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Please provide UserID");
                //textBox2.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Please provide password");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
