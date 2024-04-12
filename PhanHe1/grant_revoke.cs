using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhanHe1
{
    public partial class grant_revoke : Form
    {
        Grant grant;
        Revoke revoke;
        public grant_revoke()
        {

            InitializeComponent();
            
        }

       
        private void panelExecuteGR_Paint(object sender, PaintEventArgs e)
        {
            
        }



        private void radbuttonR_CheckedChanged(object sender, EventArgs e)
        {
            if (radbuttonR.Checked)
            {
                if (revoke == null)
                {
                    revoke = new Revoke();
                    SetupForm(revoke);
                }
                revoke.Show();
                if (grant != null)
                    grant.Hide();
            }
        }

        private void radiobuttonG_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radiobuttonG.Checked)
            {
                if (grant == null)
                {
                    grant = new Grant();
                    SetupForm(grant);
                }
                grant.Show();
                if (revoke != null)
                    revoke.Hide();
            }
        }

        private void SetupForm(Form form)
        {
            form.TopLevel = false;
            form.Size = panelExecuteGR.Size;
            form.Visible = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            form.AutoSize = true;
            form.Location = new Point(0, 0);
            panelExecuteGR.Controls.Add(form);
        }



        private void radPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
