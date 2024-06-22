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

                if ( vaitro == "Giáo vụ")
                {
                    querySinhVien = "SELECT * FROM PHANHE2.PhanCong";
                }
                else if (vaitro == "Trưởng khoa" )
                {
                    querySinhVien = "SELECT * FROM PHANHE2.PhanCong";
                    pnthem.Visible = true;
                }
                else if (vaitro == "Giảng viên")
                {
                    querySinhVien = "SELECT * FROM PHANHE2.V_PHANCONG";
                }
                else if (vaitro == "Trưởng đơn vị")
                {
                    querySinhVien=  " select* from Phanhe2.V_TRGDV_PHANCONG_HP";
                    pnthem.Visible = true;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string queryRole = "SELECT Vaitro, MaNV FROM PHANHE2.V_NHANSU";
                // Execute the query to get the role and MaNV
                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);

                if (dataRole.Rows.Count > 0)
                {
                    // Get the role and MaNV from the first row
                    string vaitro = dataRole.Rows[0]["Vaitro"].ToString();
                    string MANV = dataRole.Rows[0]["MaNV"].ToString();





                    // Create the full query string
                    string queryU_sdt;
                    // Only execute the update if the role is "Giảng viên"
                    if (vaitro == "Trưởng đơn vị")
                    {
                        queryU_sdt = $"DELETE FROM PHANHE2.V_TRGDV_PHANCONG_HP WHERE PHANCONG_ID ={tbpcid.Text}";
                        OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                        MessageBox.Show("Delete successful.");
                    }
                    else if(vaitro=="Trưởng khoa")
                    {
                        queryU_sdt = $"DELETE FROM PHANHE2.V_PHANCONG_TRUONGKHOA WHERE PHANCONG_ID ={tbpcid.Text}";
                        OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                        MessageBox.Show("Delete successful.");
                    }
                    else
                    {
                        MessageBox.Show("role khong phu hơp de drop.");
                    }


                    loadPhanCong();

                }
                else
                {
                    MessageBox.Show("No role data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {

            try
            {
                string queryRole = "SELECT Vaitro, MaNV FROM PHANHE2.V_NHANSU";
                // Execute the query to get the role and MaNV
                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);

                if (dataRole.Rows.Count > 0)
                {
                    // Get the role and MaNV from the first row
                    string vaitro = dataRole.Rows[0]["Vaitro"].ToString();
                    string MANV = dataRole.Rows[0]["MaNV"].ToString();





                    // Create the full query string
                    string queryU_sdt;
                    // Only execute the update if the role is "Giảng viên"
                    if (vaitro == "Trưởng đơn vị")
                    {
                        queryU_sdt = $"INSERT INTO phanhe2.V_TRGDV_PHANCONG_HP (Phancong_id,Magv,MAHP,HK,NAM,MACT) VALUES({tbpcid.Text}, '{tbmagv.Text}','{tbmahp.Text}',{tbnam.Text},'{tbyear.Text}','{tbmact.Text}')";

                        OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                        MessageBox.Show("Insert successful.");
                    }
                    else if(vaitro == "Trưởng khoa")
                    {
                        queryU_sdt = $"INSERT INTO phanhe2.V_PHANCONG_TRUONGKHOA (Phancong_id,Magv,MAHP,HK,NAM,MACT) VALUES({tbpcid.Text}, '{tbmagv.Text}','{tbmahp.Text}',{tbnam.Text},'{tbyear.Text}','{tbmact.Text}')";

                        OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                        MessageBox.Show("Insert successful.");
                    }
                    else
                    {
                        MessageBox.Show("Trưởng đơn vị mới được thêm phâm công");
                    }

                    // Reload the data
                    loadPhanCong();

                }
                else
                {
                    MessageBox.Show("No role data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
