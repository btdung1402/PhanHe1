using PhanHe2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;
namespace PhanHe2
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
                string querySinhVien = "SELECT * FROM PHANHE2.SinhVien ORDER BY MASV";

                if (OracleDataProvider.ROLE.ToUpper() == "GIAOVU")
                {
                    btn_i.Visible = true;
                    ttSV.Visible = true;
                    btn_u.Visible = true;
                }
                if (OracleDataProvider.ROLE.ToUpper() == "SINHVIEN")
                {
                    ttSV.Visible = true;
                    btn_u.Visible = true;
                    tbMSV.Text = OracleDataProvider.Username.ToUpper();
                    tbMSV.Enabled = false;
                    comboBoxCT.Enabled = false;
                    tBName.Enabled = false; 
                    comboBoxNganh.Enabled = false;
                    comboBoxPhai.Enabled = false;
                    dateTimePicker1.Enabled = false;
                }
                // Use OracleDataProvider to execute the query and get the DataTable for SinhVien
                DataTable dataSinhVien = OracleDataProvider.Instance.ExecuteQuery(querySinhVien);
                dataGridView1.DataSource = dataSinhVien;
            }


            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng SinhVien.");
                }
                //  insufficient privileges
                if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }

        }



        private void btn_i_Click(object sender, EventArgs e)
        {
            string id = tbMSV.Text.Trim();
            string name = tBName.Text.Trim();
            string phai = (comboBoxPhai.SelectedItem == null) ? string.Empty : comboBoxPhai.SelectedItem.ToString();
            string bdate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string dchi = tBAddr.Text.Trim();
            string dt = tBPhone.Text.Trim();
            string ct = (comboBoxCT.SelectedItem == null) ? string.Empty : comboBoxCT.SelectedItem.ToString();
            string nganh = (comboBoxNganh.SelectedItem == null) ? string.Empty : comboBoxNganh.SelectedItem.ToString();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phai)
                || string.IsNullOrEmpty(bdate) || string.IsNullOrEmpty(dchi) || string.IsNullOrEmpty(dt)
                || string.IsNullOrEmpty(ct) || string.IsNullOrEmpty(nganh))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(id, @"^SV\d{4}$"))
            {
                MessageBox.Show("Mã sinh viên có cấu trúc: SV____ với ____ là số từ 0-9.");
                return;
            }

            try
            {
                string query = $"Insert into PHANHE2.SINHVIEN (MASV,HOTEN,PHAI,NGSINH,DCHI,DT,MACT,MANGANH) " +
                    $"values ('{id}','{name}','{phai}','{bdate}','{dchi}','{dt}','{ct}','{nganh}')";
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                {
                    MessageBox.Show("Tạo sinh viên thành công.");
                    LoadSinhVien();
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
                else
                {
                    // Handle other Oracle exceptions
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
            }
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            string id = tbMSV.Text.Trim();
            string name = tBName.Text.Trim();
            string phai = (comboBoxPhai.SelectedItem == null) ? string.Empty : comboBoxPhai.SelectedItem.ToString();
            string bdate = (dateTimePicker1.Value.Date == DateTime.Today)? string.Empty : dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string dchi = tBAddr.Text.Trim();
            string dt = tBPhone.Text.Trim();
            string ct = (comboBoxCT.SelectedItem == null) ? string.Empty : comboBoxCT.SelectedItem.ToString();
            string nganh = (comboBoxNganh.SelectedItem == null) ? string.Empty : comboBoxNganh.SelectedItem.ToString();

            try
            {
                // Initialize a list to hold the update clauses
                List<string> updateClauses = new List<string>();

                // Check each text box and add to the update list if not empty
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng điền mã sinh viên cần cập nhật.");
                    return;
                }

                if (!Regex.IsMatch(id, @"^SV\d{4}$"))
                {
                    MessageBox.Show("Mã sinh viên có cấu trúc: SV____ với ____ là số từ 0-9.");
                    return;
                }

                if (!string.IsNullOrEmpty(name))
                {
                    updateClauses.Add($"hoten = '{name}'");
                }

                if (!string.IsNullOrEmpty(phai))
                {
                    updateClauses.Add($"phai = '{phai}'");
                }

                if (!string.IsNullOrEmpty(bdate))
                {
                    updateClauses.Add($"ngaysinh = to_date('{bdate}','DD-MM-YYYY')");
                }

                if (!string.IsNullOrEmpty(dchi))
                {
                    updateClauses.Add($"dchi = '{dchi}'");
                }

                if (!string.IsNullOrEmpty(dt))
                {
                    if (!Regex.IsMatch(dt, @"^\d{10}$"))
                    {
                        MessageBox.Show("Điện thoại chỉ nhận 10 giá trị số.");
                        return;
                    }
                    updateClauses.Add($"dt = '{dchi}'");
                }

                if (!string.IsNullOrEmpty(nganh))
                {
                    updateClauses.Add($"manganh = '{nganh}'");
                }

                // Only proceed if there are update clauses
                if (updateClauses.Count > 0)
                {
                    // Join the clauses with commas
                    string setClause = string.Join(", ", updateClauses);

                    // Create the full query string
                    string queryU = $"UPDATE phanhe2.sinhvien SET {setClause} WHERE MASV = '{id}'";

                    // Only execute the update if the role is "Giáo vụ"
                    if (OracleDataProvider.ROLE.ToUpper() == "GIAOVU" || OracleDataProvider.ROLE.ToUpper() == "SINHVIEN")
                    {
                        if (OracleDataProvider.Instance.ExecuteNonQuery(queryU) != 0)
                            MessageBox.Show("Cập nhật thành công.");
                        else
                            MessageBox.Show("Cập nhật thất bại.");
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có vai trò 'Giáo vụ' hoặc 'Sinh viên' mới có thể cập nhật.");
                    }

                    // Reload the data
                    LoadSinhVien();
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
