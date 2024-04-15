using PhanHe1.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web.Security;

namespace PhanHe1
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
            LoadDataForComboBox();
            CheckOnlyCommon();
        }

        private bool CheckOnlyCommon()
        {
            string query = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true";
            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query);
                return false;
            }
            catch (OracleException)
            {
                MessageBox.Show("Chỉ có thể tạo COMMON USER/ROLE, thêm C##");
                return true;
            }
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
            if (cbxSeePassword2.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void LoadDataForComboBox()
        {
            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Add an empty option to the DataTable
            dataTable.Columns.Add("ROLE", typeof(string));
            dataTable.Rows.Add("(NONE)"); // Add a row

            // Load data from the database into the DataTable
            string query = "SELECT ROLE FROM DBA_ROLES";
            dataTable.Merge(OracleDataProvider.Instance.ExecuteQuery(query));

            // Bind the DataTable to the ComboBox
            cbbRole.DataSource = dataTable;
            cbbRole.DisplayMember = "ROLE";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonUser.Checked)
            {
                createUser();

            }
            else if (radioButtonRole.Checked)
            {
                createRole();
            }
        }
        private void createUser()
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();
            DataRowView selectedRow = (DataRowView)cbbRole.SelectedItem;
            string role = selectedRow["ROLE"].ToString().Trim().ToUpper();
            if (string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(confirm)
                || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng", "Mật khẩu không trùng khớp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query_create = $"create user {username} identified by {password}";
            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query_create);
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

            if (!string.IsNullOrEmpty(role) && role != "(NONE)")
            {
                string query_grant = $"GRANT {role} to {username}";
                try
                {
                    OracleDataProvider.Instance.ExecuteNonQuery(query_grant);

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
            MessageBox.Show("Tạo User thành công!");

        }
        private void createRole()
        {
            string rolename = txtRoleName.Text.Trim();
            string password = string.Empty;
            string confirm = string.Empty;
            if (string.IsNullOrEmpty(rolename))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = $"create role {rolename}";
            if (!cbxUsePassword.Checked)
            {
                password = textBox1.Text.Trim();
                confirm = textBox2.Text.Trim();
                if (password != confirm)
                {
                    MessageBox.Show("Xác nhận mật khẩu không đúng", "Mật khẩu không trùng khớp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                query += $" identified by {password}";
            }
            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Tạo Role thành công!");
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
            string password = string.Empty;
            string confirmPassword = string.Empty;
            if (radioButtonUser.Checked)
            {
                password = txtPassword.Text;
                confirmPassword = txtConfirm.Text;
            }
            if (radioButtonRole.Checked)
            {
                password = textBox1.Text;
                confirmPassword = textBox2.Text;
            }


            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))
            {
                if (password == confirmPassword)
                {
                    // Passwords match, update UI to indicate confirmation
                    labelWarning.Text = "Mật khẩu khớp";
                    labelWarning.ForeColor = Color.Green;
                    label3.Text = "Mật khẩu khớp";
                    label3.ForeColor = Color.Green;
                }
                else
                {
                    // Passwords don't match, update UI to indicate error
                    labelWarning.Text = "Mật khẩu không khớp";
                    labelWarning.ForeColor = Color.Red;
                    label3.Text = "Mật khẩu không khớp";
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                // Either password or confirm password field is empty, reset UI
                labelWarning.Text = "";
            }
        }

        private void cbxUsePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUsePassword.Checked == true)
            {
                panelRolePassword.Visible = false;
            }
            else { panelRolePassword.Visible = true; }
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUser.Checked)
            {
                panelRole.Visible = false;
                panelUser.Visible = true;
            }

        }
        private void radioButtonRole_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRole.Checked)
            {
                panelUser.Visible = false;
                panelRole.Visible = true;
            }
        }

    }
}
