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
using System.Xml.Linq;

namespace PhanHe1
{
    public partial class PH2_DK : Form
    {
        public PH2_DK()
        {
            InitializeComponent();
        }

        private void PH2_DK_Load(object sender, EventArgs e)
        {
            LoadDangKy();
        }
        private void LoadDangKy()
        {
            try
            {
                string queryRole = "SELECT Vaitro FROM PHANHE2.V_NHANSU";

                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);
                // Get the role from the first row (assuming Vaitro is a single value)
                string vaitro = dataRole.Rows[0]["Vaitro"].ToString();

                string queryDangKy;

                if(vaitro==null)
                {
                    queryDangKy = "SELECT * FROM PHANHE2.sinhvien";
                }
                else if(vaitro=="Trưởng khoa")
                {
                    queryDangKy = "SELECT * from PHANHE2.Dangky";
                }
               
                else if (vaitro == "Giáo vụ")
                {
                    queryDangKy = "SELECT * FROM PHANHE2.V_THOA_DANGKY_GIAOVU";
                    btn_d.Visible = true;
                    btn_I.Visible = true;
                    themdangky.Visible = true;
                }
                else if(vaitro=="Giảng viên"  || vaitro== "Trưởng đơn vị")
                {
                    queryDangKy = "SELECT * FROM PHANHE2.V_DANGKY";
                    btn_u.Visible = true;
                    p_diem.Visible = true;
                }
                else
                {
                    queryDangKy = "SELECT * FROM PHANHE2.V_DANGKY";
                }
                

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataSinhVien = OracleDataProvider.Instance.ExecuteQuery(queryDangKy);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Điểm_Click(object sender, EventArgs e)
        {

        }

        private void btn_u_Click(object sender, EventArgs e)
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

                    // Initialize a list to hold the update clauses
                    List<string> updateClauses = new List<string>();

                    // Check each text box and add to the update list if not empty
                    if (!string.IsNullOrEmpty(tB_DTK.Text))
                    {
                        updateClauses.Add($"diemth = {tB_DTK.Text}");
                    }

                    if (!string.IsNullOrEmpty(tB_DTQ.Text))
                    {
                        updateClauses.Add($"diemqt = {tB_DTQ.Text}");
                    }

                    if (!string.IsNullOrEmpty(tB_DCK.Text))
                    {
                        updateClauses.Add($"diemck = {tB_DCK.Text}");
                    }

                    if (!string.IsNullOrEmpty(tB_DTK.Text))
                    {
                        updateClauses.Add($"diemtk = {tB_DTK.Text}");
                    }

                    // Only proceed if there are update clauses
                    if (updateClauses.Count > 0)
                    {
                        // Join the clauses with commas
                        string setClause = string.Join(", ", updateClauses);

                        // Create the full query string
                        string queryU_sdt = $"UPDATE phanhe2.v_dangky SET {setClause} WHERE DangKy_id = '{tB_idDK.Text}'";

                        // Only execute the update if the role is "Giảng viên"
                        if (vaitro == "Giảng viên"|| vaitro == "Trưởng đơn vị"||vaitro =="Trưởng khoa")
                        {
                            OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                            MessageBox.Show("Update successful.");
                        }
                        else
                        {
                            MessageBox.Show("Only 'Giảng viên' role can update marks.");
                        }

                        // Reload the data
                        LoadDangKy();
                    }
                    else
                    {
                        MessageBox.Show("No fields to update.");
                    }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_d_Click(object sender, EventArgs e)
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
                    string queryU_sdt = $"DELETE FROM PHANHE2.V_THOA_DANGKY_GIAOVU WHERE DANGKY_ID ={tB_idDK.Text}";
                    // Only execute the update if the role is "Giảng viên"
                    if (vaitro == "Giáo vụ")
                    {
                        OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                        MessageBox.Show("Delete successful.");
                    }
                    else
                    {
                        MessageBox.Show("role khong phu hơp de drop.");
                    }

  
                    LoadDangKy();

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_I_Click(object sender, EventArgs e)
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
                    string queryU_sdt = $"INSERT INTO phanhe2.V_THOA_DANGKY_GIAOVU (DANGKY_ID,MASV,MAGV,MAHP,HK,NAM,MACT) VALUES({tB_idDK.Text}, '{tbmasv.Text}','{tbmagv.Text}','{tbmhp.Text}',{tbhk.Text},'{tbnam.Text}','{tbct.Text}')";

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
                    LoadDangKy();

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
