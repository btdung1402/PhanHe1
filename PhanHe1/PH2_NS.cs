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

namespace PhanHe1
{
    public partial class PH2_NS : Form
    {
        private string workingtable = null;
        public PH2_NS()
        {
            InitializeComponent();
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv.EnableHeadersVisualStyles = false;
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 122, 125);
            dtgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            workingtable = getWorkingTable();
        }


        private string getWorkingTable()
        {
            string table = string.Empty;

            // Allows SinhVien to select to show privileges.
            if (OracleDataProvider.ROLE.ToUpper() == "SINHVIEN"
                || OracleDataProvider.ROLE.ToUpper() == "TRUONGKHOA"
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
        private void LoadData()
        {

            try
            {
                string queryNhanSu = $"SELECT * FROM {workingtable} ORDER BY MANV";

                if (string.IsNullOrEmpty(queryNhanSu))
                {
                    MessageBox.Show("Không thể truy vấn đến bảng NhanSu.");
                    return;
                }

                // Use OracleDataProvider to execute the query and get the DataTable for NhanSu
                DataTable dataNhanSu = OracleDataProvider.Instance.ExecuteQuery(queryNhanSu);


                // Assuming you have a DataGridView control named dataGridView1
                dtgv.DataSource = dataNhanSu;


            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng NhanSu.");
                }
                else
                {
                    // Handle other Oracle exceptions
                    MessageBox.Show("Oracle Error: " + ex.Message);
                }
            }

        }

        private void PH2_NS_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void btn_i_Click(object sender, EventArgs e)
        {
            FormAddNhanSu f = new FormAddNhanSu();
            f.ShowDialog();

        }

        private void btn_u_Click(object sender, EventArgs e)
        {
           FormUpdateNhanSu f = new FormUpdateNhanSu();
            f.ShowDialog();
            LoadData();
        }



        private void btn_d_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            try
            {
                selectedRow = dtgv.SelectedRows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xử lý.");
                return;
            }

            string selectedID = selectedRow.Cells["MANV"].Value.ToString();

            string query = $"DELETE FROM {workingtable} where MANV = '{selectedID}'";
            try
            {
                if(OracleDataProvider.Instance.ExecuteNonQuery(query) != 0);
                    MessageBox.Show($"Đã xóa {selectedID} thành công.");
            }
            catch (OracleException ex)
            {
                if (ex.Number == 942) // ORA-00942: table or view does not exist
                {
                    // Handle the specific error here
                    MessageBox.Show("Bạn không có quyền truy cập bảng NhanSu.");
                }
                //  insufficient privileges
                else if (ex.Number == 1031)
                {
                    MessageBox.Show("Tài khoản không có đủ quyền.");
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadData();
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
