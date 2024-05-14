using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;
using PhanHe1.DAO;

namespace PhanHe1
{
    public partial class FormAddNhanSu : Form
    {
        public FormAddNhanSu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text.Trim();
            string name = textBoxName.Text.Trim();
            string phai = (radioButtonFemale.Checked)? "NỮ":"NAM";
            string date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string phucap = textBoxSalary.Text.Trim();
            string dt = textBoxPhone.Text.Trim();
            string vaitro = (comboBoxRole.SelectedItem == null)? string.Empty:comboBoxRole.SelectedItem.ToString();
            string madv = textBoxDept.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phai)
                || string.IsNullOrEmpty(dt) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(phucap)
                || string.IsNullOrEmpty(madv) || string.IsNullOrEmpty(vaitro)) 
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(id, @"^NS\d{3}$"))
            {
                MessageBox.Show("Mã nhân viên có cấu trúc: NS___ với ___ là số từ 0-9.");
                return;
            }

            if (!Regex.IsMatch(phucap, @"^\d+$"))
            {
                MessageBox.Show("Phụ cấp chỉ nhận giá trị số.");
                return;
            }

            if (!Regex.IsMatch(dt, @"^\d{10}$"))
            {
                MessageBox.Show("Điện thoại chỉ nhận 10 giá trị số.");
                return;
            }

            try
            {
                string query = $"Insert into PHANHE2.NHANSU (MANV,HOTEN,PHAI,NGSINH,PHUCAP,DT,VAITRO,MADV) " +
                    $"values ('{id}','{name}','{phai}',to_date('{date}','DD-MM-YYYY'),{phucap},'{dt}','{vaitro}','{madv}')";
                if (OracleDataProvider.Instance.ExecuteNonQuery(query) != 0)
                    MessageBox.Show("Thêm nhân sự thành công.");
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

    }
}
