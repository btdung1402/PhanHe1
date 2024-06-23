using PhanHe2.DAO;
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

namespace PhanHe2
{
    public partial class FormAudit : Form
    {
        private string query;
        public FormAudit()
        {
            InitializeComponent();
            radioStdAudit.Checked = true;
        }

        private void Load_Data()
        {
            if (query == null)
            {
                return;
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

        private void radioStdAudit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStdAudit.Checked)
            {
                query = "SELECT *\r\n" +
                    "FROM (\r\n    SELECT USERNAME, TIMESTAMP, OWNER, OBJ_NAME, ACTION_NAME, SQL_TEXT, SQL_BIND, CURRENT_USER \r\n    FROM DBA_AUDIT_TRAIL \r\n    ORDER BY EXTENDED_TIMESTAMP DESC\r\n)\r\n" +
                    "WHERE ROWNUM <= 100";
                Load_Data();
                btnManageAudit.Enabled = true;
            }
        }

        private void radioFGACAudit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFGACAudit.Checked)
            {
                query = "SELECT SESSION_ID, DB_USER, CLIENT_ID, OBJECT_NAME, POLICY_NAME, SQL_TEXT, SQL_BIND, STATEMENT_TYPE, EXTENDED_TIMESTAMP, CURRENT_USER\r\n" +
                    "FROM DBA_FGA_AUDIT_TRAIL\r\n" +
                    "ORDER BY EXTENDED_TIMESTAMP DESC";
                Load_Data();
                btnManageAudit.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Data();
            MessageBox.Show("Làm mới dữ liệu thành công.");
        }

        private void btnManageAudit_Click(object sender, EventArgs e)
        {
            FormAuditManage f = new FormAuditManage();
            f.ShowDialog();
        }
    }

}
