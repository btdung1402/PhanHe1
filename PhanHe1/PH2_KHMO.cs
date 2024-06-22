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
    public partial class PH2_KHMO : Form
    {
        public PH2_KHMO()
        {
            InitializeComponent();
        }

        private void PH2_KHMO_Load(object sender, EventArgs e)
        {
            LoadKHMO();
        }

        private void LoadKHMO()
        {
            try
            {
                string queryKHM = "SELECT * FROM PHANHE2.KHMO";

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataKHMO = OracleDataProvider.Instance.ExecuteQuery(queryKHM);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataKHMO;
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng KeHoachMo.");
                }
                //  insufficient privileges
                else if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
