using System;
using System.Collections;
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
    public partial class FormPrivilege : Form
    {
        bool loaded = false;
        public FormPrivilege()
        {
            InitializeComponent();
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv.EnableHeadersVisualStyles = false;
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 122, 125);
            dtgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string grantee = txtSearch.Text;
            string query = "SELECT GRANTEE, TABLE_NAME AS TABLENAME, PRIVILEGE, GRANTABLE\r\nFROM DBA_TAB_PRIVS \r\nWHERE TABLE_NAME NOT LIKE '%$%'";


            if (!(grantee.Length == 0 || grantee == String.Empty))
            {
                query = "SELECT GRANTEE, TABLE_NAME AS TABLENAME, PRIVILEGE, GRANTABLE\r\nFROM DBA_TAB_PRIVS \r\nWHERE TABLE_NAME NOT LIKE '%$%' AND GRANTEE = '" + grantee + "'";
                loaded = false;
            }

            if (loaded) return;

            try
            {
                dtgv.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);
            }
            catch (OracleException ex) 
            {
<<<<<<< HEAD
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
=======
                MessageBox.Show("Error: " + ex.Message);
>>>>>>> e385080f2aa3e30f015b6cf60722523bf53cd253
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }

        private void FormPrivilege_Load(object sender, EventArgs e)
        {
            string query = "SELECT GRANTEE, TABLE_NAME AS TABLENAME, PRIVILEGE, GRANTABLE\r\nFROM DBA_TAB_PRIVS \r\nWHERE TABLE_NAME NOT LIKE '%$%'";
            try
            {
                dtgv.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);
                loaded = true;
            }
            catch (OracleException ex)
            {
<<<<<<< HEAD
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
=======
                MessageBox.Show("Error: " + ex.Message);
>>>>>>> e385080f2aa3e30f015b6cf60722523bf53cd253
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the system sound (ding) from playing
                e.SuppressKeyPress = true;


                btnSearch.PerformClick();
            }
        }
    }
}
