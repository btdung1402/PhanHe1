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
                string queryRole = "SELECT Vaitro FROM PHANHE2.V_NHANSU";

                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);
                // Get the role from the first row (assuming Vaitro is a single value)
                string vaitro = dataRole.Rows[0]["Vaitro"].ToString();

                string queryDonVi;
                if(vaitro ==null)
                {
                    queryDonVi= "SELECT * FROM PHANHE2.Sinhvien"; //để test
                }
                else
                {
                    queryDonVi = "SELECT * FROM PHANHE2.DonVi";
                }

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataDonVi = OracleDataProvider.Instance.ExecuteQuery(queryDonVi);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataDonVi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
