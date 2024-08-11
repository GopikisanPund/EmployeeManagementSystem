using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class startupscreen : Form
    {
        public startupscreen()
        {
            InitializeComponent();
        }

        private void startupscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            label1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                LoginePage loginePage = new LoginePage();
                loginePage.Show();
                this.Hide();

            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
