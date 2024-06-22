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
    public partial class PH2_DV : Form
    {
        public PH2_DV()
        {
            InitializeComponent();
        }

        private void PH2_DV_Load(object sender, EventArgs e)
        {
            LoadDonVi();
        }
        private void LoadDonVi()
        {
            try
            {
                string  queryDonVi = "SELECT * FROM PHANHE2.DonVi";

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataDonVi = OracleDataProvider.Instance.ExecuteQuery(queryDonVi);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataDonVi;
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng DonVi.");
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

    }
}
