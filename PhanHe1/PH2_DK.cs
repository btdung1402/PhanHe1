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
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhanHe1
{
    public partial class PH2_DK : Form
    {
        private string workingTable = string.Empty;
        public PH2_DK()
        {
            InitializeComponent();
            workingTable = getWorkingTable();
        }

        private void PH2_DK_Load(object sender, EventArgs e)
        {
            LoadDangKy();
        }

        private string getWorkingTable()
        {
            string table = string.Empty;

            if (OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA"
                || OracleDataProvider.ROLE.ToUpper() == "ADMINISTRATOR")
            {
                table = "PHANHE2.Dangky";
                btn_d.Visible = true;
                btn_I.Visible = true;
                btn_u.Visible = true;
                p_diem.Visible = true;
                panelID.Visible = true;
                themdangky.Visible = true;
            }

            else if (OracleDataProvider.ROLE.ToUpper() == "GIANGVIEN"
                     || OracleDataProvider.ROLE.ToUpper() == "TRUONGDONVI")
            {
                table = "PHANHE2.V_DANGKY";
                btn_u.Visible = true;
                p_diem.Visible = true;
                panelID.Visible = true;
            }

            else if (OracleDataProvider.ROLE.ToUpper() == "GIAOVU")
            {
                table = "PHANHE2.V_THOA_DANGKY_GIAOVU";
                btn_d.Visible = true;
                btn_I.Visible = true;
                panelID.Visible = true;
                themdangky.Visible = true;
            }
            else if (OracleDataProvider.ROLE.ToUpper() == "SINHVIEN")
            {
                table = "PHANHE2.DANGKY";
                btn_d.Visible = true;
                btn_I.Visible = true;
                tbmasv.Text = OracleDataProvider.Username.ToUpper();
                tbmasv.Enabled = false;
                themdangky.Visible = true;
            }
            return table;
        }
        private void LoadDangKy()
        {
            try
            {
                if (string.IsNullOrEmpty(workingTable))
                {
                    MessageBox.Show("Bạn không có quyền truy cập bảng DangKy.");
                    return;
                }    
                string queryDangKy = $"SELECT * FROM {workingTable} ORDER BY DANGKY_ID";


                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataSinhVien = OracleDataProvider.Instance.ExecuteQuery(queryDangKy);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataSinhVien;
                if (dataSinhVien.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có dữ liệu trên bảng DangKy.");
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng DangKy.");
                }
                else if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else
                {
                    // Handle other Oracle exceptions
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
            }
        }



        private void btn_u_Click(object sender, EventArgs e)
        {

            try
            {
                // Initialize a list to hold the update clauses
                List<string> updateClauses = new List<string>();

                // Check each text box and add to the update list if not empty
                string id = tB_idDK.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng điền ID đăng ký.");
                    return;
                }

                if (!Regex.IsMatch(id, @"^\d+$"))
                {
                    MessageBox.Show("Mã đăng ký chỉ nhận giá trị số.");
                    return;
                }

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
                    string queryU = $"UPDATE {workingTable} SET {setClause} WHERE DangKy_id = '{id}'";

                    // Only execute the update if the role is "Giảng viên"
                    if (OracleDataProvider.ROLE.ToUpper() == "GIANGVIEN"
                        || OracleDataProvider.ROLE.ToUpper() == "TRUONGDONVI"
                        || OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA")
                    {
                        if (OracleDataProvider.Instance.ExecuteNonQuery(queryU) != 0)
                            MessageBox.Show("Cập nhật thành công.");
                        else
                            MessageBox.Show("Cập nhật thất bại.");
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có vai trò 'Giảng viên' mới có thể cập nhật điểm.");
                    }

                    // Reload the data
                    LoadDangKy();
                }
                else
                {
                    MessageBox.Show("Vui lòng cung cấp trường cần cập nhật.");
                }
            }
            catch (OracleException ex)
            {
                //  insufficient privileges
                if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btn_d_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            try
            {
                selectedRow = dataGridView1.SelectedRows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xử lý.");
                return;
            }

            string selectedID = selectedRow.Cells["DANGKY_ID"].Value.ToString();

            string query = $"DELETE FROM {workingTable} where DANGKY_ID = '{selectedID}'";
            try
            {
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                    MessageBox.Show($"Xóa thành công.");
                else
                    MessageBox.Show($"Xóa thất bại.");

            }
            catch (OracleException ex)
            {
                //  insufficient privileges
                if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else if (ex.Number == 1402 && OracleDataProvider.ROLE.ToLower() == "giaovu") // WITH CHECK OPTION
                {
                    MessageBox.Show("Chưa đến lúc đăng ký học phần.");
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadDangKy();
        }


        private void btn_I_Click(object sender, EventArgs e)
        {
            string id = tB_idDK.Text.Trim();
            string masv = tbmasv.Text.Trim();
            string magv = tbmagv.Text.Trim();
            string mahp = tbmhp.Text.Trim();
            string HK = tbhk.Text.Trim();
            string nam = tbnam.Text.Trim();
            string ct = (comboBoxCT.SelectedItem == null) ? string.Empty : comboBoxCT.SelectedItem.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(magv)
                || string.IsNullOrEmpty(mahp) || string.IsNullOrEmpty(HK) || string.IsNullOrEmpty(nam)
                || string.IsNullOrEmpty(ct))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(id, @"^\d+$"))
            {
                MessageBox.Show("Mã đăng ký chỉ nhận giá trị số.");
                return;
            }

            if (!Regex.IsMatch(masv, @"^SV\d{4}$"))
            {
                MessageBox.Show("Mã sinh viên có cấu trúc: SV____ với ____ là số từ 0-9.");
                return;
            }

            if (!Regex.IsMatch(magv, @"^NS\d{3}$"))
            {
                MessageBox.Show("Mã giáo viên có cấu trúc: NS___ với ___ là số từ 0-9.");
                return;
            }

            if (!Regex.IsMatch(mahp, @"^HP\d{3}$"))
            {
                MessageBox.Show("Mã học phần có cấu trúc: NS___ với ___ là số từ 0-9.");
                return;
            }

            if (!Regex.IsMatch(HK, @"^\d{1}$") && HK != "0")
            {
                MessageBox.Show("Học kỳ chỉ nhận 1 giá trị số khác 0.");
                return;
            }


            try
            {
                string query = $"Insert into {workingTable} (DANGKY_ID,MASV,MAGV,MAHP,HK,NAM,MACT) " +
                    $"values ('{id}','{masv}','{magv}','{mahp}','{HK}','{nam}','{ct}')";
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                {
                    MessageBox.Show("Đăng ký thành công.");
                    LoadDangKy();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra.");
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập chức năng này.");
                }
                else if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else if (ex.Number == 1402 && OracleDataProvider.ROLE.ToLower() == "giaovu") // WITH CHECK OPTION
                {
                    MessageBox.Show("Chưa đến lúc đăng ký học phần.");
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



