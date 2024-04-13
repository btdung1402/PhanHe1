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
    public partial class Grant : Form
    {
        string labelName = "";

        public Grant()
        {
            InitializeComponent();
        }

        private void Grant_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonRU_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonRU.Checked)
            {
                panelNotRU.Hide(); 
                panel2.Show();
            }
        }

        private void radioButtonRole_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRole.Checked)
            {
                labelName = "Tên Role: ";
                changeLabelName(labelName);
                panelNotRU.Show();
                panel2.Hide();


            }

        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButtonUser.Checked)
            {
                labelName = "Tên User: ";
                changeLabelName(labelName);
                panelNotRU.Show();
                panel2.Hide();


            }

        }
        private void changeLabelName(string t)
        {
            labelNameG.Text = t;
        }


        private void labelNameG_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxOpion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelOption_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelOption_Click(object sender, EventArgs e)
        {

        }

        private void buttonGrant_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxU_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxU.Checked)
            {
                panel1.Show();  
            }
            else
            { 
                panel1.Hide();
            }  
        }

        private void textBoxForU_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelNotRU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
