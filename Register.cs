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
using TheArtOfDevHtmlRenderer.Adapters;

namespace Radiant_Luxe_Kafe
{
    public partial class Register : Form
    {
        private const string CONNECTION_STRING = "server=localhost;user id = root; password=; database=dbRLK;";
        public Register()
        {
            InitializeComponent();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPass.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConPass.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullname.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtConPass.Text) || (!rbtnMale.Checked && !rbtnFemale.Checked))
            {
                var incompleteinfo = new mIncompleteInfo();
                incompleteinfo.ShowDialog();
                return;
            }

            // Check if Password and ConfirmPassword match
            if (txtPassword.Text != txtConPass.Text)
            {
                var passmismatch = new mPassMismatch();
                passmismatch.ShowDialog();
                return;
            }

            // Determine the selected gender
            string gender = rbtnMale.Checked ? "Male" : (rbtnFemale.Checked ? "Female" : "");

            // All checks passed, proceed with insertion
            string sqlquery = "INSERT INTO CustomerInfo(FullName, Address, PhoneNumber, Gender, Username, Password, ConfirmPassword) " +
                              $"VALUES('{txtFullname.Text}', '{txtAddress.Text}', '{txtPhoneNumber.Text}', '{gender}', '{txtUsername.Text}', '{txtPassword.Text}', '{txtConPass.Text}')";

            MySqlConnection conn = new MySqlConnection(CONNECTION_STRING);
            MySqlCommand cmd = new MySqlCommand(sqlquery, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                var recordinserted = new mRecordInserted();
                recordinserted.ShowDialog();
            }
            catch (Exception ex)
            {
                var error = new mError();
                error.ShowDialog();
            }
            finally
            {
                conn.Close();
            }


            this.Hide();
            Login loginForm = new Login();
            loginForm.FormClosed += (s, args) => Close();
            loginForm.ShowDialog();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.FormClosed += (s, args) => Close();
            loginForm.ShowDialog();
        }
    }
}
