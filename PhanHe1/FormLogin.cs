using PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; //Oracle Client Library

namespace PhanHe1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty; 
            txtUserName.Focus();
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            
            string conn = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); User Id =" + username + "; Password=" + password + ";";

            OracleDataProvider.Initialize(conn);
            OracleDataProvider ODP = OracleDataProvider.Instance;
            if (ODP.TestConnection())
            {
                FormMainMenu_PH1 f = new FormMainMenu_PH2();
                this.Hide();
                f.FormClosed += MainMenu_FormClosed;
                f.Show();
            }
            else
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Sai tên mật khẩu hoặc tài khoản.","Đăng nhập sai",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When FormMainMenu is closed, show FormDangNhap again
            this.Show();
        }

       

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the system sound (ding) from playing
                e.SuppressKeyPress = true;

                // Simulate button click
                btnLogIn.PerformClick();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the system sound (ding) from playing
                e.SuppressKeyPress = true;

                // Select the password textbox
                txtPassword.Select();
            }
        }
    }

   
}
