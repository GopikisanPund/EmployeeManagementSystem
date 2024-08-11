using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.OleDb;
namespace EmployeeManagementSystem
{

    public partial class SignUp : Form
    {
        string emailpattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        string passpattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()-_=+{};:,<.>]).{8,}$";

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Open Sign Up Screen");
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) == true)
            {
                txtID.Focus();
                errorProvider1.SetError(this.txtID, "plese Fill ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                txtName.Focus();
                errorProvider2.SetError(this.txtName, "Please Enter Name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void NumFiled_Leave(object sender, EventArgs e)
        {
            if (NumFiled.Value == 0)
            {
                NumFiled.Focus();
                errorProvider3.SetError(this.NumFiled, ("Please Select the class"));
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, emailpattern) == false)
            {
                txtEmail.Focus();
                errorProvider4.SetError(txtEmail, "Please Enter valide mail");
            }
            else
            {
                errorProvider4.Clear();
            }

        }
        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtpass.Text, passpattern) == false)
            {
                txtpass.Focus();
                errorProvider5.SetError(this.txtpass, "Please Enter valide Password");
            }
            else
            {
                errorProvider5.Clear();
            }
        }
        private void txtrpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text != txtrpass.Text)
            {

                txtpass.Focus();
                errorProvider6.SetError(this.txtpass, "password missmatch");

            }
            else
            {
                errorProvider6.Clear();
            }
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text) == true)
            {
                txtID.Focus();
                errorProvider1.SetError(this.txtID, "plese Fill ID");
            }
            else if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                txtName.Focus();
                errorProvider2.SetError(this.txtName, "Please Enter Name");
            }
            else if (NumFiled.Value == 0)
            {
                NumFiled.Focus();
                errorProvider3.SetError(this.NumFiled, ("Please Select the class"));
            }
            else if (Regex.IsMatch(txtEmail.Text, emailpattern) == false)
            {
                txtEmail.Focus();
                errorProvider4.SetError(txtEmail, "Please Enter valide mail");
            }
            else if (Regex.IsMatch(txtpass.Text, passpattern) == false)
            {
                txtpass.Focus();
                errorProvider5.SetError(this.txtpass, "Please Enter valide Password");
            }
            else if (txtpass.Text != txtrpass.Text)
            {
                txtpass.Focus();
                errorProvider6.SetError(this.txtpass, "password missmatch");
            }
            else
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;


                    using (OleDbConnection con = new OleDbConnection(cs))
                    {
                        con.Open();
                        //Get the unique id in signup page
                        string query3 = "select * from signup where id=@id";
                        OleDbCommand cmd3 = new OleDbCommand(query3, con);
                        //take value in id column
                        cmd3.Parameters.AddWithValue("@id", txtID.Text);
                        //read data 
                        OleDbDataReader dr = cmd3.ExecuteReader();
                        //check data is comes or not in table 
                        if (dr.HasRows)
                        {
                            MessageBox.Show(txtID.Text + " " + " ID Already Exist");
                        }

                        else
                        {
                            // Separate insert data into login table
                            string loginQuery = "insert into LoginTable values(@Username, @Password)";

                            using (OleDbCommand loginCmd = new OleDbCommand(loginQuery, con))
                            {
                                loginCmd.Parameters.AddWithValue("@Username", txtEmail.Text);
                                loginCmd.Parameters.AddWithValue("@Password", txtpass.Text);
                                loginCmd.ExecuteNonQuery();
                            }

                            // Insert all data into signup table
                            string signupQuery = "insert into signup values(@id, @sname, @class, @email, @pass)";
                            using (OleDbCommand signupCmd = new OleDbCommand(signupQuery, con))
                            {
                                signupCmd.Parameters.AddWithValue("@id", txtID.Text);
                                signupCmd.Parameters.AddWithValue("@sname", txtName.Text);
                                signupCmd.Parameters.AddWithValue("@class", NumFiled.Value);
                                signupCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                signupCmd.Parameters.AddWithValue("@pass", txtpass.Text);

                                int a = signupCmd.ExecuteNonQuery();

                                if (a > 0)
                                {
                                    MessageBox.Show("Register successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //MessageBox.Show("Your Email :" +txtEmail + "\n \n "+ "Password is"+"\n \n " +txtpass+ "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("Your Email: " + txtEmail.Text + "\n\n" + "Password is: " + "\n\n" + txtpass.Text + "\n\nSuccess", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoginePage logine = new LoginePage();
                                    logine.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("Register Failed", "Failed");
                                }
                            }
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("A database error occurred:" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            NumFiled.Value = 0;
            txtpass.Clear();
            txtrpass.Clear();
            txtID.Focus();
        }

        private void NumFiled_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
