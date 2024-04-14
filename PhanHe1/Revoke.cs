using PhanHe1.DAO;
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
    public partial class Revoke : Form
    {
        //OracleDataProvider db;
        public Revoke()
        {
            InitializeComponent();
   
        }

        private void labelU_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string query = "select* from  dba_tab_privs WHERE GRANTEE = '" + name + "'";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            try
            {
                // Lấy dữ liệu từ cơ sở dữ liệu và gán cho DataGridView
                dataGridView1.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);

                // Tạo một cột DataGridViewButtonColumn cho nút xóa
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "DeleteButtonColumn";
                deleteButtonColumn.HeaderText = "";
                deleteButtonColumn.Text = "🗑️";
                deleteButtonColumn.UseColumnTextForButtonValue = true;

                // Thêm cột vào DataGridView nếu nó chưa tồn tại
                if (!dataGridView1.Columns.Contains("DeleteButtonColumn"))
                {
                    dataGridView1.Columns.Add(deleteButtonColumn);
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
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa quyền cho '" + grantee + "' trên bảng '" + tableName + "' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Nếu người dùng xác nhận muốn xóa
                    if (result == DialogResult.Yes)
                    {
                        
                        string revokeQuery = "REVOKE " + privilege + " ON sys." + tableName + " FROM " + grantee;

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
            string name = textBox1.Text.Trim();
            string query = "SELECT * FROM dba_tab_privs WHERE GRANTEE = '" + name + "'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       
    }
}
