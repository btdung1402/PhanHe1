using PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Collections;
namespace PhanHe1
{
    public partial class PH2_PC : Form
    {
        private string workingTable = string.Empty;
        public PH2_PC()
        {
            InitializeComponent();
            workingTable = getWorkingTable();
        }

        private void PH2_PC_Load(object sender, EventArgs e)
        {
            loadPhanCong();
        }

        private string getWorkingTable()
        {
            string table = string.Empty;

            if (OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA"
                || OracleDataProvider.ROLE.ToUpper() == "ADMINISTRATOR")
            {
                table = "PHANHE2.PhanCong";
                pnthem.Visible = true;
                btn_capnhat.Visible = true;
                btn_xoa.Visible = true;
                buttonRefresh.Visible = true;
                btnI.Visible = true;
            }

            else if (OracleDataProvider.ROLE.ToUpper() == "GIANGVIEN")
            {
                table = "PHANHE2.V_PHANCONG";
            }

            else if (OracleDataProvider.ROLE.ToUpper() == "TRUONGDONVI")
            {
                table = "Phanhe2.V_TRGDV_PHANCONG_HP";
                pnthem.Visible = true;
                btn_capnhat.Visible = true;
                btn_xoa.Visible = true;
                buttonRefresh.Visible = true;
                btnI.Visible = true;
            }

            else if (OracleDataProvider.ROLE.ToUpper() == "GIAOVU")
            {
                table = "PHANHE2.PhanCong";
                pnthem.Visible = true;
                btn_capnhat.Visible = true;
            }
            return table;
        }


        private void loadPhanCong(string query = null)
        {
            if (query == null)
            {
                if (string.IsNullOrEmpty(workingTable))
                {
                    MessageBox.Show("Bạn không có quyền truy cập bảng PhanCong");
                    return;
                }
                query = $"SELECT * FROM {workingTable} ORDER BY PHANCONG_ID";
            }
            
            try
            {

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataSinhVien = OracleDataProvider.Instance.ExecuteQuery(query);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataSinhVien;
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng PhanCong.");
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

        private void btn_xoa_Click(object sender, EventArgs e)
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

            string selectedID = selectedRow.Cells["PHANCONG_ID"].Value.ToString();

            string query = string.Empty;
            if (OracleDataProvider.ROLE.ToUpper() == "TRUONGDONVI")
            {
                query = $"DELETE FROM PHANHE2.V_TRGDV_PHANCONG_HP WHERE PHANCONG_ID ={selectedID}";

            }
            else if (OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA")
            {
                query = $"DELETE FROM PHANHE2.V_PHANCONG_TRUONGKHOA WHERE PHANCONG_ID ={selectedID}";

            }
            else
            {
                MessageBox.Show("Vai trò của bạn không có chức năng này.");
            }
            try
            {
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                    MessageBox.Show($"Xóa thành công.");
                else
                    MessageBox.Show($"Xóa thất bại.");

            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng PhanCong.");
                }
                //  insufficient privileges
                else if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
            loadPhanCong();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            string id = tbpcid.Text.Trim();
            string magv = tbmagv.Text.Trim();
            string mahp = tbmahp.Text.Trim();
            string HK = tbnam.Text.Trim();
            string nam = tbyear.Text.Trim();
            string ct = (comboBoxCT.SelectedItem == null) ? string.Empty : comboBoxCT.SelectedItem.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(magv) || string.IsNullOrEmpty(ct)
                || string.IsNullOrEmpty(mahp) || string.IsNullOrEmpty(HK) || string.IsNullOrEmpty(nam))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(id, @"^\d+$"))
            {
                MessageBox.Show("Mã phân công chỉ nhận giá trị số.");
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

            if (!Regex.IsMatch(nam, @"^\d{4}-\d{4}$"))
            {
                MessageBox.Show("Năm nhận giá trị: XXXX-YYYY với YYYY = XXXX + 1");
                return;
            }

            string query = string.Empty;

            // Only execute the update if the role is "Giảng viên"
            if (OracleDataProvider.ROLE.ToUpper() == "TRUONGDONVI")
            {
                query = $"INSERT INTO phanhe2.V_TRGDV_PHANCONG_HP (Phancong_id,Magv,MAHP,HK,NAM,MACT) " +
                    $"VALUES({id}, '{magv}','{mahp}',{HK},'{nam}','{ct}')";

            }
            else if (OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA")
            {
                query = $"INSERT INTO phanhe2.V_PHANCONG_TRUONGKHOA (Phancong_id,Magv,MAHP,HK,NAM,MACT) " +
                   $"VALUES({id}, '{magv}','{mahp}',{HK},'{nam}','{ct}')";
            }
            else
            {
                MessageBox.Show("Trưởng đơn vị mới được thêm phâm công");
                return;
            }


            try
            {
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                    MessageBox.Show("Thêm thành công.");
                else
                    MessageBox.Show("Thêm thất bại.");
                // Reload the data
                loadPhanCong();
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng PhanCong.");
                }
                else
                {
                    // Handle other Oracle exceptions
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string id = tbpcid.Text.Trim();
            string magv = tbmagv.Text.Trim();
            string mahp = tbmahp.Text.Trim();
            string HK = tbnam.Text.Trim();
            string nam = tbyear.Text.Trim();
            string ct = (comboBoxCT.SelectedItem == null) ? string.Empty : comboBoxCT.SelectedItem.ToString();

            // Initialize a list to hold the update clauses
            List<string> updateClauses = new List<string>();

            // Check each text box and add to the update list if not empty
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng điền ID phân công cần cập nhật.");
                return;
            }

            if (!Regex.IsMatch(id, @"^\d+$"))
            {
                MessageBox.Show("Mã phân công chỉ nhận giá trị số.");
                return;
            }

            if (!string.IsNullOrEmpty(magv))
            {
                if (!Regex.IsMatch(magv, @"^NS\d{3}$"))
                {
                    MessageBox.Show("Mã giáo viên có cấu trúc: NS___ với ___ là số từ 0-9.");
                    return;
                }
                updateClauses.Add($"MAGV = '{magv}'");
            }

            if (!string.IsNullOrEmpty(mahp))
            {
                if (!Regex.IsMatch(mahp, @"^HP\d{3}$"))
                {
                    MessageBox.Show("Mã học phần có cấu trúc: NS___ với ___ là số từ 0-9.");
                    return;
                }
                updateClauses.Add($"MAHP = '{mahp}'");
            }

            if (!string.IsNullOrEmpty(HK))
            {
                if (!Regex.IsMatch(HK, @"^\d{1}$") && HK != "0")
                {
                    MessageBox.Show("Học kỳ chỉ nhận 1 giá trị số khác 0.");
                    return;
                }
                updateClauses.Add($"HK = {mahp} ");
            }
            if (!string.IsNullOrEmpty(nam))
            {
                if (!Regex.IsMatch(nam, @"^\d{4}-\d{4}$"))
                {
                    MessageBox.Show("Năm nhận giá trị: XXXX-YYYY với YYYY = XXXX + 1");
                    return;
                }
                updateClauses.Add($"NAM = '{nam}'");
            }

            if (!string.IsNullOrEmpty(ct))
            {
                updateClauses.Add($"MACT = '{ct}'");
            }

            try
            {
                // Only proceed if there are update clauses
                if (updateClauses.Count > 0)
                {
                    // Join the clauses with commas
                    string setClause = string.Join(", ", updateClauses);
                    string wTbl = string.Empty;
                    if (OracleDataProvider.ROLE.ToUpper() == "TRUONGDONVI")
                    {
                        wTbl = "PHANHE2.V_TRGDV_PHANCONG_H";
                    }
                    else if (OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA")
                    {
                        wTbl = "PHANHE2.V_PHANCONG_TRUONGKHOA";
                    }
                    else if (OracleDataProvider.ROLE.ToUpper() == "GIAOVU")
                    {
                        wTbl = "PHANHE2.V_PHANCONG_GIAOVU";
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền thực hiện chức năng này.");
                        return;
                    }

                    // Create the full query string
                    string queryU = $"UPDATE {wTbl} SET {setClause} WHERE PHANCONG_ID = '{id}'";

                    if (OracleDataProvider.Instance.ExecuteNonQuery(queryU) != 0)
                        MessageBox.Show("Cập nhật thành công.");
                    else
                        MessageBox.Show("Cập nhật thất bại.");

                    // Reload the data
                    loadPhanCong();
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
    }
}
