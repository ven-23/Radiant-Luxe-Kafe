using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiant_Luxe_Kafe
{
    public partial class Login : Form
    {
        private const string CONNECTION_STRING = "server=localhost;user id = root; password=; database=dbRLK;";
        
        public Login()
        {
            InitializeComponent();
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                var incompleteinfo = new mIncompleteInfo();
                incompleteinfo.ShowDialog();
                return;
            }

            // Check the entered username and password in the database
            string sqlQuery = "SELECT COUNT(*) FROM CustomerInfo WHERE Username = @Username AND Password = @Password";

            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STRING))
            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Username", enteredUsername);
                cmd.Parameters.AddWithValue("@Password", enteredPassword);

                try
                {
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        var loginsuccess = new mLoginSuccess();
                        loginsuccess.ShowDialog();
                        Hide();
                        Main main = new Main(enteredUsername);
                        main.FormClosed += (s, args) => Close();
                        main.ShowDialog();
                    }
                    else
                    {
                        var invalunp = new mInvalidUP();
                        invalunp.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    var error = new mError();
                    error.ShowDialog();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
