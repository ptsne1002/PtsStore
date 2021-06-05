using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PtsStore
{
    public partial class LoginForm : Form
    {
        private ConnectDB connectDB = new ConnectDB();
        private Thread thread;
        private string userName;
        private string password;
        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            userName = txtUser.Text;
            if(txtPassHide.Visible == false)
            {
                password = txtPassUnhide.Text;
            }
            else
            {
                password = txtPassHide.Text;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connectDB.GetConnectionDB();
            cmd.CommandText = "select username,password from account where username ='" + userName+"' and password = '"+password+"'";
            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if(userName == dr.GetString(0)&& password == dr.GetString(1))
                {
                    thread = new Thread(openMainForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Name Or Password Error\n\tPlease Try Again", "Fail To Login");
            }
            connectDB.CloseConnection();
        }

        private void openMainForm()
        {
            Application.Run(new MainForm());
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click_1(sender, e);
            }    
        }


        private void checkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHide.Checked)
            {
                txtPassHide.Hide();
                txtPassUnhide.Show();
                txtPassUnhide.Text = txtPassHide.Text;

            }
            else
            {
                txtPassHide.Show();
                txtPassUnhide.Hide();
                txtPassHide.Text = txtPassUnhide.Text;

            }
        }
    }
}
