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
using System.Collections;
namespace PhanHe1
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv.EnableHeadersVisualStyles = false;
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 122, 125);
            dtgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void btnDelData_Click(object sender, EventArgs e)
        {
            if (dtgv.DataSource != null)
            {
                dtgv.DataSource = null;
                btnAddUser.Enabled = false;
                btnSearch.Enabled = false;
                btnLockUnlock.Enabled = false;
            }
            }
        private void Load_Data(string query = null)
        {
            if (query == null)
            {
                query = "select username, account_status, " +
                              "TO_CHAR(created, 'DD-MM-YYYY') as created_date, " +
                              "TO_CHAR(expiry_date, 'DD-MM-YYYY') as expiry_date, " +
                              "TO_CHAR(last_login,'DD-MM-YYYY, HH:MI:SS') as last_login from dba_users";
                btnAddUser.Enabled = true;
                btnSearch.Enabled = true;
                btnLockUnlock.Enabled = true;
            }
            try
            {
                if (dtgv.DataSource != null)
                {
                    dtgv.DataSource = null;
                    Color oldColor = dtgv.BackgroundColor;
                    dtgv.BackgroundColor = Color.Cyan;
                    dtgv.BackgroundColor = oldColor;
                }

                dtgv.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
                }
                else
                {
                    // Handle other Oracle exceptions
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText;
            FormSearch f = new FormSearch();
            DialogResult result = f.ShowDialog();
            if (result != DialogResult.OK)
                return;

            searchText = f.GetSearchString().Trim().ToUpper();

            string query = "select username, account_status, " +
                              "TO_CHAR(created, 'DD-MM-YYYY') as created_date, " +
                              "TO_CHAR(expiry_date, 'DD-MM-YYYY') as expiry_date, " +
                              "TO_CHAR(last_login,'DD-MM-YYYY, HH:MI:SS') as last_login from dba_users " +
                              $"where username = '{searchText}'";
            Load_Data(query);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAdd f = new FormAdd();
            f.Show();
        }

        private void btnLockUnlock_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            try
            {
                selectedRow = dtgv.SelectedRows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xử lý.");
                return;
            }
           
            string selectedUser = selectedRow.Cells["username"].Value.ToString();
            string selectedAccountStatus = selectedRow.Cells["account_status"].Value.ToString();
            string locked = string.Empty;
            if (selectedAccountStatus.ToUpper() == "OPEN")
            {
                locked = "LOCK";
            }

            if (selectedAccountStatus.ToUpper() == "LOCKED")
            {
                locked = "UNLOCK";
            }
            string query = $"ALTER USER {selectedUser} ACCOUNT {locked}";
            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show($"{locked}ED  {selectedUser}.");
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
            Load_Data();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword f = new FormChangePassword();
            f.Show();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM DBA_ROLES";
            Load_Data(query);
            btnAddUser.Enabled = false;
            btnSearch.Enabled = false;
            btnLockUnlock.Enabled = false;
            
        }
    }
}
