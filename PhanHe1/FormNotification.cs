using PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Management.Instrumentation;

namespace PhanHe1
{
    public partial class FormNotification : Form
    {
        public FormNotification()
        {
            InitializeComponent();
            //dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Data();
            MessageBox.Show("Làm mới dữ liệu thành công.");
        }

        private void FormNotificationcs_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data(string query = null)
        {
            if (query == null)
            {
                query = "select NOIDUNG from admin_ols.thongbao";
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

                DataTable data = OracleDataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = data;
                if (data.Rows.Count == 0) 
                    MessageBox.Show("Bạn chưa có thông báo nào.");
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
