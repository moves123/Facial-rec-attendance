using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Tulpep.NotificationWindow;

namespace Facial_rec_attendance
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';// hiden the password  box so the password can be protected
            txtpassword.MaxLength = 8; // limited  the password lenght to 8 letter,digits etc...
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "") // checking if the boxes are have empty values
            {
                MessageBox.Show("Invalid Login!! Please enter a Username and Password"); // if thats the case this error msg pop ups
                return;
            }

            SQLiteConnection con = new SQLiteConnection("Data Source = DB.db;version=3"); // connection to sql database

            try
            {

                con.Open();
                // query to get login details from one of the table in thw database
                //has to get a username + password
                string query = "SELECT * FROM Login WHERE Username='" + this.txtusername.Text + "' AND Password= '" + this.txtpassword.Text + "' ";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.ExecuteNonQuery();
                SQLiteDataReader dr = cmd.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    // notificztion popup for successful login
                    PopupNotifier show = new PopupNotifier();
                    show.TitleText = "System Message";
                    show.ContentText = "Successful Login Welcome!!!!";
                    show.Popup();
                    //MessageBox.Show("login sucessful");
                    HomePage f2 = new HomePage(); //if login is successfult the application takes you to the mentioned page
                    this.Hide();
                    f2.ShowDialog();
                    

                }
                if (count > 1)
                {
                    MessageBox.Show("duplicate user and pass");
                }
                if (count < 1)
                {
                    MessageBox.Show("The username and password  entered are incorrect");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();

        }
        void Clear() // when the user input wrong credidentials the application remove all the input
            // have to re eneter the details again
        {
            txtusername.Text = txtpassword.Text = "";
        }

        // exit option from the application
        //verification purpose if they want to exit with a yes and no option
        private void btnexit_Click(object sender, EventArgs e)
        {
            const string error = "Do you want to exit?";
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
