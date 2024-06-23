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
using PhanHe2.DAO;

namespace PhanHe2
{
    public partial class FormAuditManage : Form
    {
        private string selected_object = "";
        private string selected_action = "";
        private string selected_option = "";
        private string selected_user = "";
        public FormAuditManage()
        {
            InitializeComponent();
            LoadUserDataComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
        
            if (comboBoxObject.SelectedItem == null && !checkBoxAuditUser.Checked)
            {
                MessageBox.Show("Vui lòng chọn object.");
                return;
            }

            if (comboBoxAction.SelectedItem == null && !checkBoxAuditUser.Checked)
            {
                MessageBox.Show("Vui lòng chọn action.");
                return;
            }

            if (comboBoxOption.SelectedItem == null && !checkBoxAuditUser.Checked)
            {
                selected_option = "";
            }

            if (comboBoxUser.SelectedItem == null && checkBoxAuditUser.Checked)
            {
                MessageBox.Show("Vui lòng chọn user.");
                return;
            }


            string query = (checkBoxAuditUser.Checked)? $"AUDIT ALL BY {selected_user}" :
                           $"AUDIT {selected_action} ON {selected_object} {selected_option}";

            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Thêm audit thành công.");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBoxObject.SelectedItem == null && !checkBoxAuditUser.Checked)
            {
                MessageBox.Show("Vui lòng chọn object.");
                return;
            }

            if (comboBoxAction.SelectedItem == null && !checkBoxAuditUser.Checked)
            {
                MessageBox.Show("Vui lòng chọn action.");
                return;
            }

            if (comboBoxOption.SelectedItem == null && !checkBoxAuditUser.Checked)
            {
                selected_option = "";
            }

            if (comboBoxUser.SelectedItem == null && checkBoxAuditUser.Checked)
            {
                MessageBox.Show("Vui lòng chọn user.");
                return;
            }

            if (selected_option.ToUpper() == "BY ACCESS")
            {
                MessageBox.Show("Xóa audit không được kèm với BY ACCESS.");
                return;
            }

            string query = (checkBoxAuditUser.Checked) ? $"NOAUDIT ALL BY {selected_user}" :
                           $"NOAUDIT {selected_action} ON {selected_object} {selected_option}";
            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Xoá audit thành công.");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void comboBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
                selected_object = (comboBoxObject.SelectedItem.ToString() == "THONGBAO") ? "ADMIN_OLS.THONGBAO" : "PHANHE2." + comboBoxObject.SelectedItem.ToString();
        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_action = comboBoxAction.SelectedItem.ToString();
        }

        private void comboBoxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_option = comboBoxOption.SelectedItem.ToString();
            buttonDel.Enabled = (selected_option.ToUpper() == "BY ACCESS") ? false : true;
        }

        private void LoadUserDataComboBox()
        {
            //DataTable dataTable = new DataTable();
            // Add an empty option to the DataTable
           // dataTable.Columns.Add("USERNAME", typeof(string));
            string query = "SELECT USERNAME FROM ALL_USERS";
            try
            {
                //dataTable.Merge(OracleDataProvider.Instance.ExecuteQuery(query) );
                comboBoxUser.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);
                comboBoxUser.DisplayMember = "USERNAME";
            }
            catch (OracleException ex)
            {
                //  insufficient privileges
                if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền để xem tất cả người dùng.");
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void checkBoxAuditUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAuditUser.Checked)
            {
                labelObject.Text = "User";
                comboBoxObject.Visible = false;
                comboBoxUser.Visible = true;
                comboBoxAction.Visible = false;
                comboBoxAction.SelectedIndex = -1;
                comboBoxOption.Visible = false;
                comboBoxOption.SelectedIndex = -1;
                comboBoxUser.Enabled = true;
                labelOpt.Visible = false;
                labelAction.Visible = false;
                
            }
            else
            {
                labelObject.Text = "Object";
                comboBoxObject.Visible = true;
                comboBoxUser.Visible = false;
                comboBoxAction.Visible = true;
                comboBoxOption.Visible = true;
                comboBoxUser.Enabled = false;
                labelOpt.Visible = true;
                labelAction.Visible = true;

            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)comboBoxUser.SelectedItem;
            selected_user = selectedRow["USERNAME"].ToString().Trim().ToUpper();
        }
    }
}
