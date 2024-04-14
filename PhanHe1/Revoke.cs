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
            string query = "select * form " + name + ";";
           
            //try
            //{
            //    dataGridView1.DataSource = OracleDataProvider.Instance.ExecuteQuery(query);
            //}
            //catch (OracleException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            // db.ExecuteQuery

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string role = textBox2.Text.Trim();
            string query = "";
            //if(radioButtonRU.Checked)
            //{
            //    query= "REVOKE "+ role+" ON BH_KHACHHANG FROM king;"
            //}

        }
    }
}
