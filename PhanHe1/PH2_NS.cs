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

namespace PhanHe1
{
    public partial class PH2_NS : Form
    {
        public PH2_NS()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadNhanSuData()
        {


            try
            {
                string queryNhanSu;
                if (/*user_name == "SV"*/0 ==1)
                {
                    queryNhanSu = "SELECT * FROM PHANHE2.NhanSu";
                }

                else
                {
                    string queryRole = "SELECT Vaitro FROM PHANHE2.V_NHANSU";
                    // Use OracleDataProvider to execute the query and get the DataTable for role
                    DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);

                    if (dataRole.Rows.Count > 0)
                    {
                        // Get the role from the first row (assuming Vaitro is a single value)
                        string vaitro = dataRole.Rows[0]["Vaitro"].ToString();



                        if (vaitro == "Trưởng khoa")
                        {
                            queryNhanSu = "SELECT * FROM PHANHE2.NhanSu";
                        }
                        //
                        else if(vaitro=="Nhân viên cơ bản" || vaitro=="Giảng viên"||vaitro== "Giáo vụ" || vaitro == "Trưởng đơn vị")
                        {
                            queryNhanSu = "SELECT * FROM PHANHE2.V_NhanSu";
                            panel1.Visible = false;
                            textBox2.Visible = false;
                            MaDV.Visible = false;
                            btn_d.Visible = false;
                            btn_i.Visible = false;
                        }
                        else
                        {
                            queryNhanSu = "SELECT * FROM PHANHE2.V_NhanSu";
                            panel1.Visible = false;
                            textBox2.Visible = false;
                            MaDV.Visible = false;
                            btn_d.Visible = false;
                            btn_i.Visible = false;
                        }

                        // Use OracleDataProvider to execute the query and get the DataTable for NhanSu
                        DataTable dataNhanSu = OracleDataProvider.Instance.ExecuteQuery(queryNhanSu);


                        // Assuming you have a DataGridView control named dataGridView1
                        dataGridView1.DataSource = dataNhanSu;

                    }
                    else
                    {
                        MessageBox.Show("No role data found in V_NHANSU.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void PH2_NS_Load(object sender, EventArgs e)
        {
            LoadNhanSuData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            try
            {
                string queryRole = "SELECT Vaitro, MaNV FROM PHANHE2.V_NHANSU";
                // Execute the query to get the role and MaNV
                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);

                if (dataRole.Rows.Count > 0)
                {
                    // Get the role and MaNV from the first row
                    string vaitro = dataRole.Rows[0]["Vaitro"].ToString();
                    string MANV = dataRole.Rows[0]["MaNV"].ToString();


                    // Create the full query string
                    string queryU_sdt = $"INSERT INTO PHANHE2.NhanSu(MaNV,HOTEN,PHAI,NGSINH,PHUCAP,DT,VAITRO,MADV) VALUES('{mans.Text}','{hoten.Text}','{in_s.Text}',TO_DATE('{textBox1.Text}', 'DD-MM-YYYY'),{phucap.Text},'{SDT.Text}','{role.Text}','{textBox2.Text}') ";

                    if (vaitro == "Trưởng khoa")
                    {
                        OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                        MessageBox.Show("Delete successful.");
                    }
                    else
                    {
                        MessageBox.Show("role khong phu hơp de them.");
                    }

                    LoadNhanSuData();

                }
                else
                {
                    MessageBox.Show("No role data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            try
            {
                string queryRole = "SELECT Vaitro, MaNV FROM PHANHE2.V_NHANSU";
                // Execute the query to get the role and MaNV
                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);

                if (dataRole.Rows.Count > 0)
                {
                    // Get the role and MaNV from the first row
                    string vaitro = dataRole.Rows[0]["Vaitro"].ToString();
                    string MANV = dataRole.Rows[0]["MaNV"].ToString();

                    // Assuming you have a TextBox control named txtSDT to get the new SDT value
                    string newSDT = SDT.Text;

                    // Update query string
                    string queryU_sdt = $"UPDATE PHANHE2.V_NHANSU SET DT = '{newSDT}' WHERE MANV = '{MANV}'";

                    // Only execute the update if the role is "Nhân viên cơ bản"
                    if (vaitro == "Nhân viên cơ bản" || vaitro=="Giảng viên" || vaitro == "Giáo vụ" || vaitro == "Trưởng đơn vị" || vaitro == "Trưởng khoa")
                    {
                        OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                        MessageBox.Show("Update successful.");
                        


                    }
                    else
                    {
                        MessageBox.Show("role ko có quyền update");
                    }
                    LoadNhanSuData();
                }
                else
                {
                    MessageBox.Show("No role data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            try
            {
                string queryRole = "SELECT Vaitro, MaNV FROM PHANHE2.V_NHANSU";
                // Execute the query to get the role and MaNV
                DataTable dataRole = OracleDataProvider.Instance.ExecuteQuery(queryRole);

                if (dataRole.Rows.Count > 0)
                {
                    // Get the role and MaNV from the first row
                    string vaitro = dataRole.Rows[0]["Vaitro"].ToString();
                    string MANV = dataRole.Rows[0]["MaNV"].ToString();





                    // Create the full query string
                    string queryU_sdt = $"DELETE FROM PHANHE2.NhanSu WHERE MaNV = '{mans.Text}'";
                    
                    if (vaitro == "Trưởng khoa")
                    {
                        OracleDataProvider.Instance.ExecuteQuery(queryU_sdt);
                        MessageBox.Show("Delete successful.");
                    }
                    else
                    {
                        MessageBox.Show("role khong phu hơp de drop.");
                    }

                    LoadNhanSuData();

                }
                else
                {
                    MessageBox.Show("No role data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void mans_TextChanged(object sender, EventArgs e)
        {

        }

        private void hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void in_s_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void role_TextChanged(object sender, EventArgs e)
        {

        }

        private void phucap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
