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
                string queryRole = "SELECT Vaitro FROM PHANHE2.V_NHANSU";

                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);
                // Get the role from the first row (assuming Vaitro is a single value)
                string vaitro = dataRole.Rows[0]["Vaitro"].ToString();

                string queryKHM;
                if(vaitro==null)
                {
                    queryKHM = "SELECT * FROM PHANHE2.Sinhvien";
                }    
                else
                {
                    queryKHM = "SELECT * FROM PHANHE2.KHMO";
                }

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataKHMO = OracleDataProvider.Instance.ExecuteQuery(queryKHM);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataKHMO;
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
