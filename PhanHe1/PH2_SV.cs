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
    public partial class PH2_SV : Form
    {
        public PH2_SV()
        {
            InitializeComponent();
        }

        private void PH2_SV_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }

        private void LoadSinhVien()
        {
            try
            {
                string querySinhVien;
                if (/*user_name == "SV"*/ 0==1)
                {
                    querySinhVien = "SELECT * FROM PHANHE2.SinhVien";
                }
                else
                {
                    string queryRole = "SELECT Vaitro FROM PHANHE2.V_NHANSU";

                    DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);
                    // Get the role from the first row (assuming Vaitro is a single value)
                    string vaitro = dataRole.Rows[0]["Vaitro"].ToString();

                    if (vaitro == "Trưởng khoa" || vaitro == "Trưởng đơn vị"|| vaitro == "Nhân viên cơ bản")
                    {
                        querySinhVien = "SELECT * FROM PHANHE2.SinhVien";
                    }
                    else if (vaitro == "Giáo vụ")
                    {
                        querySinhVien = "SELECT * FROM PHANHE2.SinhVien";
                        btn_i.Visible=true;
                        ttSV.Visible=true;

                    }
                    else
                        querySinhVien = "SELECT * FROM PHANHE2.SinhVien";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_i_Click(object sender, EventArgs e)
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
                        string queryU_sdt = $"INSERT INTO phanhe2.SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH) VALUES('{tbMSV.Text}', '{tBName.Text}','{tBS.Text}',TO_DATE('{tBDate.Text}', 'DD-MM-YYYY'),'{tBAddr.Text}','{tBPhone.Text}','{tBMCT.Text }','{tBMj.Text}')";

                        // Only execute the update if the role is "Giảng viên"
                        if (vaitro == "Giáo vụ")
                        {
                            OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                            MessageBox.Show("Insert successful.");
                        }
                        else
                        {
                            MessageBox.Show("Only 'Giáo vụ' role can insert a student.");
                        }

                    // Reload the data
                    LoadSinhVien();
                   
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

        private void ttSV_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
