namespace PhanHe1
{
    partial class FormMainMenu_PH1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnGrantRevoke = new System.Windows.Forms.Button();
            this.btnPriv = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimine = new System.Windows.Forms.Button();
            this.btnMaximine = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnDel);
            this.panelMenu.Controls.Add(this.btnGrantRevoke);
            this.panelMenu.Controls.Add(this.btnPriv);
            this.panelMenu.Controls.Add(this.btnList);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(303, 553);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = global::PhanHe1.Properties.Resources.icons8_logout_48;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 320);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(303, 60);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = " Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDel.Image = global::PhanHe1.Properties.Resources.icons8_delete_48;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(0, 260);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDel.Size = new System.Drawing.Size(303, 60);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = " Xoá User/Role";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGrantRevoke
            // 
            this.btnGrantRevoke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrantRevoke.FlatAppearance.BorderSize = 0;
            this.btnGrantRevoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrantRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrantRevoke.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGrantRevoke.Image = global::PhanHe1.Properties.Resources.icons8_grant_48;
            this.btnGrantRevoke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrantRevoke.Location = new System.Drawing.Point(0, 200);
            this.btnGrantRevoke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrantRevoke.Name = "btnGrantRevoke";
            this.btnGrantRevoke.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGrantRevoke.Size = new System.Drawing.Size(303, 60);
            this.btnGrantRevoke.TabIndex = 3;
            this.btnGrantRevoke.Text = " Trao/Tước quyền";
            this.btnGrantRevoke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrantRevoke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrantRevoke.UseVisualStyleBackColor = true;
            this.btnGrantRevoke.Click += new System.EventHandler(this.btnGrantRevoke_Click);
            // 
            // btnPriv
            // 
            this.btnPriv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPriv.FlatAppearance.BorderSize = 0;
            this.btnPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPriv.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPriv.Image = global::PhanHe1.Properties.Resources.icons8_privilege_48;
            this.btnPriv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPriv.Location = new System.Drawing.Point(0, 140);
            this.btnPriv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPriv.Name = "btnPriv";
            this.btnPriv.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPriv.Size = new System.Drawing.Size(303, 60);
            this.btnPriv.TabIndex = 2;
            this.btnPriv.Text = " Quyền User/Role";
            this.btnPriv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPriv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPriv.UseVisualStyleBackColor = true;
            this.btnPriv.Click += new System.EventHandler(this.btnPriv_Click);
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnList.Image = global::PhanHe1.Properties.Resources.icons8_list_48;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(0, 80);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnList.Size = new System.Drawing.Size(303, 60);
            this.btnList.TabIndex = 1;
            this.btnList.Text = " Xem tất cả User";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(303, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.panelTitleBar.Controls.Add(this.btnMinimine);
            this.panelTitleBar.Controls.Add(this.btnMaximine);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelTitleBar.Location = new System.Drawing.Point(303, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(885, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimine
            // 
            this.btnMinimine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimine.FlatAppearance.BorderSize = 0;
            this.btnMinimine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnMinimine.Location = new System.Drawing.Point(780, 0);
            this.btnMinimine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimine.Name = "btnMinimine";
            this.btnMinimine.Size = new System.Drawing.Size(29, 30);
            this.btnMinimine.TabIndex = 5;
            this.btnMinimine.Text = "-";
            this.btnMinimine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMinimine.UseVisualStyleBackColor = true;
            this.btnMinimine.Click += new System.EventHandler(this.btnMinimine_Click);
            // 
            // btnMaximine
            // 
            this.btnMaximine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximine.FlatAppearance.BorderSize = 0;
            this.btnMaximine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMaximine.Location = new System.Drawing.Point(816, 0);
            this.btnMaximine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximine.Name = "btnMaximine";
            this.btnMaximine.Size = new System.Drawing.Size(29, 30);
            this.btnMaximine.TabIndex = 6;
            this.btnMaximine.Text = "O";
            this.btnMaximine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMaximine.UseVisualStyleBackColor = true;
            this.btnMaximine.Click += new System.EventHandler(this.btnMaximine_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(852, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::PhanHe1.Properties.Resources.icons8_x_48;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(357, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRANG CHỦ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.lblGroupName);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.lblUser);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(303, 80);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(885, 473);
            this.panelDesktop.TabIndex = 2;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.lblGroupName.Location = new System.Drawing.Point(316, 242);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(346, 36);
            this.lblGroupName.TabIndex = 10;
            this.lblGroupName.Text = "Thực hiện bởi Nhóm 11";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PhanHe1.Properties.Resources.icons8_customs_officer_78;
            this.pictureBox1.Location = new System.Drawing.Point(171, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.lblUser.Location = new System.Drawing.Point(23, 32);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(150, 36);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Xin chào!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.panel1.Location = new System.Drawing.Point(29, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phân hệ 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMainMenu_PH1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1188, 553);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(899, 448);
            this.Name = "FormMainMenu_PH1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Administration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnGrantRevoke;
        private System.Windows.Forms.Button btnPriv;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimine;
        private System.Windows.Forms.Button btnMaximine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}