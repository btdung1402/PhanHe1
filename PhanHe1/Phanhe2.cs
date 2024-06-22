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
    public partial class Phanhe2 : Form
    {
        private Form currentChildForm;
        private string user_name;
       // string loggedInUsername = OracleDataProvider.username.ToUpper();
        public Phanhe2()
        {
            InitializeComponent();
            //if (loggedInUsername.Contains("SV"))
            //{
            //    user_name = "SV";
            //}
            //else if (loggedInUsername.Contains("NS"))
            //{
            //    user_name = "NS";
            //}
            //else
            //{
            //    user_name = "";
            //}
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PH2_SV(), sender);
        }

        private void btn_HP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PH2_HP(), sender);
        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PH2_DK(), sender);
        }

        private void btn_khmo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PH2_KHMO(), sender);
        }

        private void btn_NS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PH2_NS(), sender);
        }

        private void btn_DV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PH2_DV(), sender);
        }

        private void btn_PC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PH2_PC(), sender);
        }
    }
}
