using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using PhanHe1.DAO;

namespace PhanHe1
{
    public partial class FormUpdateNhanSu : Form
    {
        private bool mode_switch = false;
        private bool mode_dt = true;
        private string workingTable = null;
        public FormUpdateNhanSu()
        {
            InitializeComponent();
            workingTable = getWorkingTable();
            allowModeSwitch();
        }

        private string getWorkingTable()
        {
            string table = string.Empty;

            // Allows SinhVien to select to show privileges.
            if (OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA"
                || OracleDataProvider.ROLE.ToUpper() == "ADMINISTRATOR")
            {
                table = "PHANHE2.NhanSu";
            }

            else if (OracleDataProvider.ROLE.ToUpper() == "NHANVIENCOBAN"
                     || OracleDataProvider.ROLE.ToUpper() == "GIANGVIEN"
                     || OracleDataProvider.ROLE.ToUpper() == "GIAOVU"
                     || OracleDataProvider.ROLE.ToUpper() == "TRUONGDONVI")
            {
                table = "PHANHE2.V_NhanSu";
            }
            return table;
        }

        private void allowModeSwitch()
        {
            if (OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA"
                || OracleDataProvider.ROLE.ToUpper() == "ADMINISTRATOR")
            {
                mode_switch = true;
            }
        }

        private void labelMode_Click(object sender, EventArgs e)
        {
            if (!mode_switch) return;

            if (mode_dt)
            {
                mode_dt = false;
                labelMode.Text = "Cập nhật nhân sự";
                panelAll.Visible = true;
                panelPhone.Visible = false;
            }
            else
            {
                mode_dt = true;
                labelMode.Text = "Cập nhật số điện thoại";
                panelAll.Visible = false;
                panelPhone.Visible = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = string.Empty;

            if (mode_dt)
            {
                string DT = textBoxPhone2.Text.Trim();

                if (!Regex.IsMatch(DT, @"^\d{10}$"))
                {
                    MessageBox.Show("Điện thoại chỉ nhận 10 giá trị số.");
                    return;
                }

                query = $"UPDATE {workingTable} SET DT = '{DT}' WHERE MANV = '{OracleDataProvider.Username}'";
            }
            else
            {
                string id = textBoxID.Text.Trim();
                string name = textBoxName.Text.Trim();
                string phai = (radioButtonEmpty.Checked) ? string.Empty : (radioButtonFemale.Checked) ? "NỮ" : "NAM";
                string date = (dateTimePicker2.Value.Date != DateTime.Today)? dateTimePicker2.Value.ToString("dd-MM-yyyy") : string.Empty;
                string phucap = textBoxSal.Text.Trim();
                string dt = textBoxPhone.Text.Trim();
                string vaitro = (comboBoxRole.SelectedItem != null)? comboBoxRole.SelectedItem.ToString() : string.Empty;
                string madv = textBoxDept.Text.Trim();
                query = $"UPDATE {workingTable} SET ";


                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng điền Mã nhân viên cần update.");
                    return;
                }

                else if (!Regex.IsMatch(id, @"^NS\d{3}$"))
                {
                    MessageBox.Show("Mã nhân viên có cấu trúc: NS___ với ___ là số từ 0-9.");
                    return;
                }

                else if (!string.IsNullOrEmpty(name))
                {
                    query += $" HOTEN = '{name}' ,";
                }

                else if (!string.IsNullOrEmpty(phai))
                {
                    query += $" PHAI = '{phai}' ,";
                }

                else if (!string.IsNullOrEmpty(date))
                {
                    query += $" NGAYSINH = TO_DATE('{date}','DD-MM-YYYY') ";
                }

                else if (!string.IsNullOrEmpty(phucap))
                {
                    if (!Regex.IsMatch(phucap, @"^\d+$"))
                    {
                        MessageBox.Show("Phụ cấp chỉ nhận giá trị số.");
                        return;
                    }
                    query += $" PHUCAP = {phucap} ,";
                }
                else if (!string.IsNullOrEmpty(dt))
                {
                    if (!Regex.IsMatch(dt, @"^\d{10}$"))
                    {
                        MessageBox.Show("Điện thoại chỉ nhận 10 giá trị số.");
                        return;
                    }
                    query += $" DT = '{dt}' ,";

                }

                else if (!string.IsNullOrEmpty(vaitro))
                {
                    query += $" VAITRO = '{vaitro}' ,";
                }

                else if (!string.IsNullOrEmpty(madv))
                {
                    query += $" MADV = '{madv}' ,";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 trường cần cập nhật.");
                    return;
                }
                query = query.Remove(query.Length - 1);
                query += $" WHERE MANV = '{id}";
            }

            try
            {
                if(OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                    MessageBox.Show("Cập nhật thành công.");
                else
                    MessageBox.Show("Bạn không phải là nhân sự của hệ thống.");
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
    }
}
