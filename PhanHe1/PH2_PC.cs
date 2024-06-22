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
    public partial class PH2_PC : Form
    {
        public PH2_PC()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PH2_PC_Load(object sender, EventArgs e)
        {
            loadPhanCong();
        }
        private void loadPhanCong()
        {
            try
            {
                string queryRole = "SELECT Vaitro FROM PHANHE2.V_NHANSU";

                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);
                // Get the role from the first row (assuming Vaitro is a single value)
                string vaitro = dataRole.Rows[0]["Vaitro"].ToString();

                string querySinhVien;

                if (vaitro == "Trưởng khoa" || vaitro == "Giáo vụ")
                {
                    querySinhVien = "SELECT * FROM PHANHE2.PhanCong";
                }
                else if (vaitro == "Giảng viên")
                {
                    querySinhVien = "SELECT * FROM PHANHE2.V_PHANCONG";
                }
                else if (vaitro == "Trưởng đơn vị")
                {
                    querySinhVien=  " select* from Phanhe2.V_TRGDV_PHANCONG_HP";
                }
                else if (vaitro == null)
                {

                    querySinhVien = "SELECT * FROM PHANHE2.Sinhvien";
                }
                else
                {

                    querySinhVien = "SELECT * FROM PHANHE2.V_PHANCONG";
                }

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataSinhVien = OracleDataProvider.Instance.ExecuteQuery(querySinhVien);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
