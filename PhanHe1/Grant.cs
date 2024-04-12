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
            if(radioButtonRole.Checked)
            {

            }
        }

        private void radioButtonRole_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRole.Checked)
            {
                labelName = "Tên Role: ";
                changeLabelName(labelName);
            }

        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButtonUser.Checked)
            {
                labelName = "Tên User: ";
                changeLabelName(labelName); 
            }

        }
        private void changeLabelName(string t)
        {
            labelNameG.Text = t;
        }


        private void labelNameG_Click(object sender, EventArgs e)
        {

        }
    }
}
