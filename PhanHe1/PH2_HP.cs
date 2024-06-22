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
    public partial class PH2_HP : Form
    {
        public PH2_HP()
        {
            InitializeComponent();
        }

        private void PH2_HP_Load(object sender, EventArgs e)
        {
            LoadHocPhan();

        }

        private void LoadHocPhan()
        {
            try
            {
                string queryRole = "SELECT Vaitro FROM PHANHE2.V_NHANSU";

                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);
                // Get the role from the first row (assuming Vaitro is a single value)
                string vaitro = dataRole.Rows[0]["Vaitro"].ToString();

                string queryHocPhan;

                if (vaitro == null)
                {
                    queryHocPhan = "SELECT * FROM PHANHE2.sinhvien"; // truong hop sinh vien
                }
               
                else
                {
                    queryHocPhan = "SELECT * FROM PHANHE2.HocPhan";
                }

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataHocPhan = OracleDataProvider.Instance.ExecuteQuery(queryHocPhan);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataHocPhan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
