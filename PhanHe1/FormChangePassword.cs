using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using PhanHe1.DAO;
namespace PhanHe1
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void cbxSeePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSeePassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordConfirmation();
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordConfirmation();
        }

        private void CheckPasswordConfirmation()
        {
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirm.Text.Trim();
           

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))
            {
                if (password == confirmPassword)
                {
                    // Passwords match, update UI to indicate confirmation
                    labelWarning.Text = "Hợp lệ";
                    labelWarning.ForeColor = Color.Green;
                }
                else
                {
                    // Passwords don't match, update UI to indicate error
                    labelWarning.Text = "Không hợp lệ";
                    labelWarning.ForeColor = Color.Red;
                }
            }
            else
            {
                // Either password or confirm password field is empty, reset UI
                labelWarning.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            string confirm = this.txtConfirm.Text.Trim();
            if (string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                return;

            }
            string query = $"ALTER USER {username} IDENTIFIED BY {password}";
            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            catch (OracleException ex)
            {
                //  insufficient privileges
                if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
