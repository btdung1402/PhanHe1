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
            string query = "select username, account_status, " +
                           "TO_CHAR(created, 'DD-MM-YYYY') as created_date, " +
                           "TO_CHAR(expiry_date, 'DD-MM-YYYY') as expiry_date, " +
                           "TO_CHAR(last_login,'DD-MM-YYYY, HH:MI:SS') as last_login from dba_users";
            try
            {
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
    }
}
