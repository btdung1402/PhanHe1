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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Xml.Linq;
namespace PhanHe1
{
    public partial class PH2_DV : Form
    {
        public PH2_DV()
        {
            InitializeComponent();
            if (OracleDataProvider.ROLE.ToLower() == "giaovu")
            {
                panelAdd.Visible = true;
            }
        }

        private void PH2_DV_Load(object sender, EventArgs e)
        {
            LoadDonVi();
        }
        private void LoadDonVi()
        {
            try
            {
                string queryDonVi = "SELECT * FROM PHANHE2.DonVi";

                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataDonVi = OracleDataProvider.Instance.ExecuteQuery(queryDonVi);

                // Assuming you have a DataGridView control named dataGridView1
                dataGridView1.DataSource = dataDonVi;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (OracleDataProvider.ROLE.ToLower() != "giaovu")
            {
                return;
            }

            string id = textBoxID.Text.Trim();
            string name = textBoxName.Text.Trim();
            string boss = textBoxBoss.Text.Trim();

            if (!Regex.IsMatch(id, @"^DV\d{2}$"))
            {
                MessageBox.Show("Mã đơn vị có cấu trúc: DV__ với __ là số từ 0-9.");
                return;
            }

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(boss))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.");
                return;
            }

            string query = $"INSERT INTO PHANHE2.DONVI VALUES ('{id}','{name}','{boss}')";
            try
            {
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                    MessageBox.Show("Thêm thành công.");
                else
                    MessageBox.Show("Thêm thất bại.");
                LoadDonVi();
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
            string name = textBoxName.Text.Trim();
            string boss = textBoxBoss.Text.Trim();

            try
            {
                // Initialize a list to hold the update clauses
                List<string> updateClauses = new List<string>();

                // Check each text box and add to the update list if not empty
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng điền mã đơn vị cần cập nhật.");
                    return;
                }

                if (!Regex.IsMatch(id, @"^DV\d{2}$"))
                {
                    MessageBox.Show("Mã đơn vị có cấu trúc: DV__ với __ là số từ 0-9.");
                    return;
                }

                if (!string.IsNullOrEmpty(name))
                {
                    updateClauses.Add($"tendv = '{name}'");
                }

                if (!string.IsNullOrEmpty(boss))
                {
                    updateClauses.Add($"trgdv = '{boss}'");
                }

                // Only proceed if there are update clauses
                if (updateClauses.Count > 0)
                {
                    // Join the clauses with commas
                    string setClause = string.Join(", ", updateClauses);

                    // Create the full query string
                    string queryU = $"UPDATE phanhe2.donvi SET {setClause} WHERE MADV = '{id}'";

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
                    LoadDonVi();
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

        private void buttonDel_Click(object sender, EventArgs e)
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

            string selectedID = selectedRow.Cells["MADV"].Value.ToString();

            string query = $"DELETE FROM phanhe2.donvi where MADV = '{selectedID}'";
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
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadDonVi();
        }
    }
}

