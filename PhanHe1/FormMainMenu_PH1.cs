using PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanHe1
{
    public partial class FormMainMenu_PH1 : Form
    {
        //Fields
        private static bool _relog = false;
        private Button currentBtn;
        private Form activeForm;
        private Point oldP;
        //Constructor
        public FormMainMenu_PH1()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty; // Disable the title text
            this.ControlBox = false; // Disable Control box
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable window resizing
            btnMaximine.Enabled = false; // Disable the custom maximine button
            oldP = lblTitle.Location;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            string color = ThemeColor.ColorList[0];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                if (currentBtn != (Button)sender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentBtn = (Button)sender;
                    currentBtn.BackColor = color;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void OpenChildForm(Form ChildForm, object sender)
        {
            if (activeForm != null && activeForm.GetType() == ChildForm.GetType())
            {
                ActivateButton(sender);
                activeForm.BringToFront();
                return;
            }

            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(sender);
            lblTitle.Text = ChildForm.Text;
            btnCloseChildForm.Visible = true;
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            lblTitle.Location = oldP;
            OpenChildForm(new FormList(), sender);
        }


        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "TRANG CHỦ";
            currentBtn = null;
            btnCloseChildForm.Visible = false;
            activeForm = null;
            lblTitle.Location = oldP;
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximine_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void btnMinimine_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;

        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_relog)
            {
                Application.Exit();
            }
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            string username = OracleDataProvider.username.ToUpper();
            lblUser.Text = $"Xin chào, {username}!";
            panel1.Size = new System.Drawing.Size(lblUser.Width + 10, 1);
        }

        private void btnPriv_Click(object sender, EventArgs e)
        {
            
            lblTitle.Location = new Point(lblTitle.Location.X - 40, lblTitle.Location.Y);
            OpenChildForm(new FormPrivilege(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _relog = true;
                this.Close();
            }
        }

        private void btnGrantRevoke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGrant_Revoke(),sender);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDel(), sender);
        }
    }
}
