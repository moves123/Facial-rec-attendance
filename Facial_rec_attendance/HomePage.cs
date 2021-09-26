using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facial_rec_attendance
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnAddnewstudent_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.ShowDialog();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            register f2 = new register();
            this.Hide();
            f2.ShowDialog();
        }

        private void btnschedule_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();

            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }
        //timer , showing contionous running clock on a lable
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();// the timer is set to run continous
        }

        //exiting the application
        private void btnext_Click(object sender, EventArgs e)
        {
            const string error = "Are you sure you wan to Exit!!?";
            const string msg = "EXIT";
            var result = MessageBox.Show(error, msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
