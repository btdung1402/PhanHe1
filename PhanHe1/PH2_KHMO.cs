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
using System.Text.RegularExpressions;

namespace PhanHe1
{
    public partial class PH2_KHMO : Form
    {
        public PH2_KHMO()
        {
            InitializeComponent();
            if (OracleDataProvider.ROLE.ToLower() == "giaovu")
            {
                panelAdd.Visible = true;
            }
        }

        private void PH2_KHMO_Load(object sender, EventArgs e)
        {
            LoadKHMO();
        }

        private void LoadKHMO()
        {
            try
            {
                string queryKHM = "SELECT * FROM PHANHE2.KHMO";

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataKHMO = OracleDataProvider.Instance.ExecuteQuery(queryKHM);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataKHMO;
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng KeHoachMo.");
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (OracleDataProvider.ROLE.ToLower() != "giaovu")
            {
                return;
            }

            string id = textBoxID.Text.Trim();
            string mahp = textBoxHP.Text.Trim();
            string hk = textBoxHK.Text.Trim();
            string nam = textBoxNam.Text.Trim();
            string ct = textBoxCT.Text.Trim();


            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(mahp) || string.IsNullOrEmpty(hk)
                || string.IsNullOrEmpty(nam) || string.IsNullOrEmpty(ct) )
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(id, @"^\d+$"))
            {
                MessageBox.Show("Mã KHMO chỉ nhận giá trị số.");
                return;
            }

            if (!Regex.IsMatch(mahp, @"^HP\d{3}$"))
            {
                MessageBox.Show("Mã học phần có cấu trúc: HP___ với ___ là số từ 0-9.");
                return;
            }

            if (!Regex.IsMatch(hk, @"^\d{1}$"))
            {
                MessageBox.Show("Học kỳ chỉ nhận 1 giá trị số.");
                return;
            }

            if (!Regex.IsMatch(nam, @"^\d{4}-\d{4}$"))
            {
                MessageBox.Show("Năm nhận giá trị: XXXX-YYYY với YYYY = XXXX + 1");
                return;
            }


            string query = $"INSERT INTO PHANHE2.KHMO VALUES ('{id}','{mahp}','{hk}','{nam}','{ct}')";
            try
            {
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                    MessageBox.Show("Thêm thành công.");
                else
                    MessageBox.Show("Thêm thất bại.");
                LoadKHMO();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (OracleDataProvider.ROLE.ToLower() != "giaovu")
            {
                return;
            }

            string id = textBoxID.Text.Trim();
            string mahp = textBoxHP.Text.Trim();
            string hk = textBoxHK.Text.Trim();
            string nam = textBoxNam.Text.Trim();
            string ct = textBoxCT.Text.Trim();

            try
            {
                // Initialize a list to hold the update clauses
                List<string> updateClauses = new List<string>();

                // Check each text box and add to the update list if not empty
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng điền mã KHMO cần cập nhật.");
                    return;
                }

                if (!Regex.IsMatch(id, @"^\d+$"))
                {
                    MessageBox.Show("Mã KHMO chỉ nhận giá trị số.");
                    return;
                }

                if (!string.IsNullOrEmpty(mahp))
                {
                    if (!Regex.IsMatch(mahp, @"^HP\d{3}$"))
                    {
                        MessageBox.Show("Mã học phần có cấu trúc: HP___ với ___ là số từ 0-9.");
                        return;
                    }
                    updateClauses.Add($"mahp = '{mahp}'");
                }

                if (!string.IsNullOrEmpty(hk))
                {
                    if (!Regex.IsMatch(hk, @"^\d{1}$"))
                    {
                        MessageBox.Show("Học kỳ chỉ nhận 1 giá trị số.");
                        return;
                    }

                    updateClauses.Add($"hk = {hk}");
                }

                if (!string.IsNullOrEmpty(nam))
                {
                    if (!Regex.IsMatch(nam, @"^\d{4}-\d{4}$"))
                    {
                        MessageBox.Show("Năm nhận giá trị: XXXX-YYYY với YYYY = XXXX + 1");
                        return;
                    }
                    updateClauses.Add($"nam = {nam}");
                }

                if (!string.IsNullOrEmpty(ct))
                {
                    updateClauses.Add($"MACT = {ct}");
                }

                // Only proceed if there are update clauses
                if (updateClauses.Count > 0)
                {
                    // Join the clauses with commas
                    string setClause = string.Join(", ", updateClauses);

                    // Create the full query string
                    string queryU = $"UPDATE phanhe2.khmo SET {setClause} WHERE KHMO_ID = '{id}'";

                    // Only execute the update if the role is "Giáo vụ"
                    if (OracleDataProvider.ROLE.ToUpper() == "GIAOVU")
                    {
                        if (OracleDataProvider.Instance.ExecuteNonQuery(queryU) != 0)
                            MessageBox.Show("Cập nhật thành công.");
                        else
                            MessageBox.Show("Cập nhật thất bại.");
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có vai trò 'Giáo vụ' mới có thể cập nhật.");
                    }

                    // Reload the data
                    LoadKHMO();
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
