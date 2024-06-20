using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanHe1.DAO;
using Oracle.ManagedDataAccess.Client;


namespace PhanHe1
{
    public partial class FormRevoke : Form
    {
        //OracleDataProvider db;
        //bool commonUser;
        public FormRevoke()
        {
            InitializeComponent();
            //commonUser = CheckOnlyCommon();

            textBox1.Padding = new Padding(20); 
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 122, 125);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 122, 125);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
        }

        // Use for Container Database
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim().ToUpper();
            string query = "SELECT GRANTEE, OWNER, TABLE_NAME, PRIVILEGE, COLUMN_NAME, GRANTOR, GRANTABLE\r\n FROM dba_col_privs\r\n WHERE GRANTEE = '" + name + "'";
            query += "UNION ALL\r\nSELECT GRANTEE, OWNER, TABLE_NAME, PRIVILEGE, NULL AS COLUMN_NAME, GRANTOR , GRANTABLE\r\nFROM dba_tab_privs\r\nWHERE GRANTEE = '" + name + "'";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
            string query_1 = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + name + "'";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
           
            try
            {
                // Lấy dữ liệu từ cơ sở dữ liệu và gán cho DataGridView
                dataGridView1.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);

                dataGridView2.DataSource = OracleDataProvider.Instance.ExecuteQuery(query_1);


                // Tạo một cột DataGridViewButtonColumn cho nút xóa
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "DeleteButtonColumn";
                deleteButtonColumn.HeaderText = "";
                deleteButtonColumn.Text = "🗑️";
                deleteButtonColumn.UseColumnTextForButtonValue = true;

                
                // Thêm cột vào DataGridView1 nếu nó chưa tồn tại
                if (!dataGridView1.Columns.Contains("DeleteButtonColumn"))
                {
                    dataGridView1.Columns.Add(deleteButtonColumn);
                }


                // Kiểm tra xem dataGridView2 có dữ liệu hay không
                if (dataGridView2.RowCount > 1)
                {
                    // Tạo một cột DataGridViewButtonColumn cho nút xóa
                    DataGridViewButtonColumn deleteButtonColumn_1 = new DataGridViewButtonColumn();
                    deleteButtonColumn_1.Name = "DeleteButtonColumn_1";
                    deleteButtonColumn_1.HeaderText = "";
                    deleteButtonColumn_1.Text = "🗑️";
                    deleteButtonColumn_1.UseColumnTextForButtonValue = true;

                    // Thêm cột vào DataGridView2 nếu nó chưa tồn tại
                    if (!dataGridView2.Columns.Contains("DeleteButtonColumn_1"))
                    {
                        dataGridView2.Columns.Add(deleteButtonColumn_1);
                    }

                    // Hiển thị panel chứa dataGridView2 nếu có dữ liệu
                    panel1.Visible = true;
                }
                else
                {
                    // Ẩn panel nếu không có dữ liệu
                    panel1.Visible = false;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã nhấn vào nút xóa hay không
                if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButtonColumn")
                {
                    // Lấy giá trị của cột "GRANTEE" và "TABLE_NAME" từ hàng tương ứng
                    string grantee = dataGridView1.Rows[e.RowIndex].Cells["GRANTEE"].Value.ToString();
                    string tableName = dataGridView1.Rows[e.RowIndex].Cells["TABLE_NAME"].Value.ToString();
                    string privilege = dataGridView1.Rows[e.RowIndex].Cells["PRIVILEGE"].Value.ToString();


                    // Hiển thị hộp thoại xác nhận xóa
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa quyền '" + privilege + "' trên bảng '" + tableName + "' của '"+grantee+"' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Nếu người dùng xác nhận muốn xóa
                    if (result == DialogResult.Yes)
                    {
                        
                        string revokeQuery = "REVOKE " + privilege + " ON PHANHE2." + tableName + " FROM " + grantee;

                        OracleDataProvider.Instance.ExecuteNonQuery(revokeQuery);

                        // Sau khi thực hiện xóa, cần cập nhật lại DataGridView để hiển thị dữ liệu mới
                        RefreshDataGridView();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            
            // Thực hiện lại truy vấn để lấy dữ liệu mới từ cơ sở dữ liệu
            string name = textBox1.Text.Trim().ToUpper();
            string query = "SELECT GRANTEE, OWNER, TABLE_NAME, PRIVILEGE, COLUMN_NAME, GRANTOR, GRANTABLE\r\n FROM dba_col_privs\r\n WHERE GRANTEE = '" + name + "'";
            query += "UNION ALL\r\nSELECT GRANTEE, OWNER, TABLE_NAME, PRIVILEGE, NULL AS COLUMN_NAME, GRANTOR , GRANTABLE\r\nFROM dba_tab_privs\r\nWHERE GRANTEE = '" + name + "'";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            try
            {
                // Lấy dữ liệu từ cơ sở dữ liệu và gán cho DataGridView
                dataGridView1.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView2.Columns[e.ColumnIndex].Name == "DeleteButtonColumn_1")
                {
                    string grantee = dataGridView2.Rows[e.RowIndex].Cells["GRANTEE"].Value.ToString();
                    string roleName = dataGridView2.Rows[e.RowIndex].Cells["GRANTED_ROLE"].Value.ToString();

                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa vai trò '" + roleName + "' cho '" + grantee + "' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string revokeRoleQuery = "REVOKE " + roleName + " FROM " + grantee;

                        OracleDataProvider.Instance.ExecuteNonQuery(revokeRoleQuery);

                        RefreshDataGridView2();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshDataGridView2()
        {
            string name = textBox1.Text.Trim().ToUpper();
            string query = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + name + "'";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            try
            {
                dataGridView2.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRevoke_Load(object sender, EventArgs e)
        {

        }
    }
}
