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
    public partial class PH2_HP : Form
    {
        public PH2_HP()
        {
            InitializeComponent();
            if (OracleDataProvider.ROLE.ToLower() == "giaovu")
            {
                panelAdd.Visible = true;
            }
        }

        private void PH2_HP_Load(object sender, EventArgs e)
        {
            LoadHocPhan();

        }

        private void LoadHocPhan()
        {
            try
            {
                string queryDonVi = "SELECT * FROM PHANHE2.HOCPHAN";

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
                    MessageBox.Show("Bạn không có quyền truy cập bảng HocPhan.");
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
            string madv = textBoxDV.Text.Trim();
            string tc = textBoxTC.Text.Trim();
            string th = textBoxTH.Text.Trim();
            string lt = textBoxLT.Text.Trim();
            string sv = textBoxSV.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(madv)
                || string.IsNullOrEmpty(tc) || string.IsNullOrEmpty(th) || string.IsNullOrEmpty(lt) ||
                string.IsNullOrEmpty(sv) )
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(id, @"^HP\d{3}$"))
            {
                MessageBox.Show("Mã học phần có cấu trúc: HP___ với ___ là số từ 0-9.");
                return;
            }

            if (!Regex.IsMatch(madv, @"^DV\d{2}$"))
            {
                MessageBox.Show("Mã đơn vị có cấu trúc: DV__ với __ là số từ 0-9.");
                return;
            }

            if (!Regex.IsMatch(tc, @"^\d+$"))
            {
                MessageBox.Show("Số tín chỉ chỉ nhận giá trị số.");
                return;
            }

            if (!Regex.IsMatch(th, @"^\d+$"))
            {
                MessageBox.Show("Số tín thực hành chỉ chỉ nhận giá trị số.");
                return;
            }

            if (!Regex.IsMatch(lt, @"^\d+$"))
            {
                MessageBox.Show("Số tín lý thuyết chỉ chỉ nhận giá trị số.");
                return;
            }

            if (!Regex.IsMatch(sv, @"^\d+$"))
            {
                MessageBox.Show("Số sinh viên chỉ nhận giá trị số.");
                return;
            }

            


            string query = $"INSERT INTO PHANHE2.HOCPHAN VALUES ('{id}','{name}','{name}',{tc},{lt},{th},{sv},'{madv})";
            try
            {
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                    MessageBox.Show("Thêm thành công.");
                else
                    MessageBox.Show("Thêm thất bại.");
                LoadHocPhan();
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
            string madv = textBoxDV.Text.Trim();
            string tc = textBoxTC.Text.Trim();
            string th = textBoxTH.Text.Trim();
            string lt = textBoxLT.Text.Trim();
            string sv = textBoxSV.Text.Trim();

            try
            {
                // Initialize a list to hold the update clauses
                List<string> updateClauses = new List<string>();

                // Check each text box and add to the update list if not empty
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng điền mã học phần cần cập nhật.");
                    return;
                }

                if (!Regex.IsMatch(id, @"^HP\d{3}$"))
                {
                    MessageBox.Show("Mã học phần có cấu trúc: HP___ với ___ là số từ 0-9.");
                    return;
                }

                if (!string.IsNullOrEmpty(name))
                {
                    updateClauses.Add($"tenhp = '{name}'");
                }

                if (!string.IsNullOrEmpty(tc))
                {
                    if (!Regex.IsMatch(tc, @"^\d+$"))
                    {
                        MessageBox.Show("Số tín chỉ chỉ nhận giá trị số.");
                        return;
                    }
                    updateClauses.Add($"sotc = {tc}");
                }

                if (!string.IsNullOrEmpty(th))
                {
                    if (!Regex.IsMatch(th, @"^\d+$"))
                    {
                        MessageBox.Show("Số tín thực hành chỉ chỉ nhận giá trị số.");
                        return;
                    }
                    updateClauses.Add($"STTH = {th}");
                }

                if (!string.IsNullOrEmpty(lt))
                {
                    if (!Regex.IsMatch(lt, @"^\d+$"))
                    {
                        MessageBox.Show("Số tín lý thuyết chỉ chỉ nhận giá trị số.");
                        return;
                    }
                    updateClauses.Add($"STLT = {lt}");
                }

                if (!string.IsNullOrEmpty(sv))
                {
                    if (!Regex.IsMatch(sv, @"^\d+$"))
                    {
                        MessageBox.Show("Số sinh viên chỉ nhận giá trị số.");
                        return;
                    }
                    updateClauses.Add($"SOSVTD = {sv}");
                }

                if (!string.IsNullOrEmpty(madv))
                {
                    if (!Regex.IsMatch(madv, @"^DV\d{2}$"))
                    {
                        MessageBox.Show("Mã đơn vị có cấu trúc: DV__ với __ là số từ 0-9.");
                        return;
                    }
                    updateClauses.Add($"MADV = {madv}");
                }

                // Only proceed if there are update clauses
                if (updateClauses.Count > 0)
                {
                    // Join the clauses with commas
                    string setClause = string.Join(", ", updateClauses);

                    // Create the full query string
                    string queryU = $"UPDATE phanhe2.hocphan SET {setClause} WHERE MAHP = '{id}'";

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
                    LoadHocPhan();
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
