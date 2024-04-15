using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using PhanHe1.DAO;

namespace PhanHe1
{
    public partial class FormDel : Form
    {
        private string mode;
        public FormDel()
        {
            InitializeComponent();
            CheckOnlyCommon();
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 122, 125);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            radioButtonUser.Checked = true;
        }

        private bool CheckOnlyCommon()
        {
            string query = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true";
            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query);
                return false;
            }
            catch (OracleException)
            {
                MessageBox.Show("Chỉ có thể tạo COMMON USER/ROLE, thêm C##");
                return true;
            }
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            string txt = textBox.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(txt) ) 
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            string cascade = "";
            if (checkBox1.Checked)
            {
                cascade = "CASCADE";
            }
            string query = $"DROP {mode} {txt} {cascade}";
            try
            {
                OracleDataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show($"Xóa {mode} thành công!");
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
            if (mode == "USER")
            {
                query = $"select * from dba_users";
                Load_Data(query);
            }
            if (mode == "ROLE")
            {
                query = $"select * from dba_roles";
                Load_Data(query);
            }
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUser.Checked)
            {
                mode = "USER";
                string query = $"select * from dba_users";
                Load_Data(query);
                checkBox1.Enabled = true;
            }
            
        }

        private void radioButtonRole_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRole.Checked)
            {
                mode = "ROLE";
                string query = $"select * from dba_roles";
                Load_Data(query);
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
            }

            
        }

        private void Load_Data(string query)
        {
            try
            {
                if (dataGridView2.DataSource != null) dataGridView2.DataSource = null;
                dataGridView2.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);
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
