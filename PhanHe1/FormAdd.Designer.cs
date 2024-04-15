namespace PhanHe1
{
    partial class FormAdd
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
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelRole = new System.Windows.Forms.Panel();
            this.panelRolePassword = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSeePassword2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.labelRoleName = new System.Windows.Forms.Label();
            this.cbxUsePassword = new System.Windows.Forms.CheckBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.cbxSeePassword = new System.Windows.Forms.CheckBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonRole = new System.Windows.Forms.RadioButton();
            this.panelUser.SuspendLayout();
            this.panelRole.SuspendLayout();
            this.panelRolePassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.labelWarning);
            this.panelUser.Controls.Add(this.cbbRole);
            this.panelUser.Controls.Add(this.cbxSeePassword);
            this.panelUser.Controls.Add(this.labelRole);
            this.panelUser.Controls.Add(this.txtConfirm);
            this.panelUser.Controls.Add(this.labelConfirm);
            this.panelUser.Controls.Add(this.txtPassword);
            this.panelUser.Controls.Add(this.labelPassword);
            this.panelUser.Controls.Add(this.txtUserName);
            this.panelUser.Controls.Add(this.labelUserName);
            this.panelUser.Location = new System.Drawing.Point(27, 96);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(441, 220);
            this.panelUser.TabIndex = 0;
            // 
            // panelRole
            // 
            this.panelRole.Controls.Add(this.panelRolePassword);
            this.panelRole.Controls.Add(this.txtRoleName);
            this.panelRole.Controls.Add(this.labelRoleName);
            this.panelRole.Controls.Add(this.cbxUsePassword);
            this.panelRole.Location = new System.Drawing.Point(40, 96);
            this.panelRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRole.Name = "panelRole";
            this.panelRole.Size = new System.Drawing.Size(441, 220);
            this.panelRole.TabIndex = 1;
            this.panelRole.Visible = false;
            // 
            // panelRolePassword
            // 
            this.panelRolePassword.Controls.Add(this.label3);
            this.panelRolePassword.Controls.Add(this.cbxSeePassword2);
            this.panelRolePassword.Controls.Add(this.textBox1);
            this.panelRolePassword.Controls.Add(this.label1);
            this.panelRolePassword.Controls.Add(this.textBox2);
            this.panelRolePassword.Controls.Add(this.label2);
            this.panelRolePassword.Location = new System.Drawing.Point(30, 81);
            this.panelRolePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRolePassword.Name = "panelRolePassword";
            this.panelRolePassword.Size = new System.Drawing.Size(395, 126);
            this.panelRolePassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // cbxSeePassword2
            // 
            this.cbxSeePassword2.AutoSize = true;
            this.cbxSeePassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeePassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.cbxSeePassword2.Location = new System.Drawing.Point(213, 92);
            this.cbxSeePassword2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSeePassword2.Name = "cbxSeePassword2";
            this.cbxSeePassword2.Size = new System.Drawing.Size(176, 24);
            this.cbxSeePassword2.TabIndex = 5;
            this.cbxSeePassword2.Text = "Hiển thị mật khẩu";
            this.cbxSeePassword2.UseVisualStyleBackColor = true;
            this.cbxSeePassword2.CheckedChanged += new System.EventHandler(this.cbxSeePassword_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xác nhận";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(156, 14);
            this.txtRoleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(265, 26);
            this.txtRoleName.TabIndex = 1;
            // 
            // labelRoleName
            // 
            this.labelRoleName.AutoSize = true;
            this.labelRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelRoleName.Location = new System.Drawing.Point(34, 14);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(107, 25);
            this.labelRoleName.TabIndex = 0;
            this.labelRoleName.Text = "Tên Role";
            // 
            // cbxUsePassword
            // 
            this.cbxUsePassword.AutoSize = true;
            this.cbxUsePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUsePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.cbxUsePassword.Location = new System.Drawing.Point(210, 49);
            this.cbxUsePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxUsePassword.Name = "cbxUsePassword";
            this.cbxUsePassword.Size = new System.Drawing.Size(210, 24);
            this.cbxUsePassword.TabIndex = 2;
            this.cbxUsePassword.Text = "Không dùng mật khẩu";
            this.cbxUsePassword.UseVisualStyleBackColor = true;
            this.cbxUsePassword.CheckedChanged += new System.EventHandler(this.cbxUsePassword_CheckedChanged);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(45, 146);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 20);
            this.labelWarning.TabIndex = 6;
            // 
            // cbbRole
            // 
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(160, 172);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(265, 28);
            this.cbbRole.TabIndex = 5;
            // 
            // cbxSeePassword
            // 
            this.cbxSeePassword.AutoSize = true;
            this.cbxSeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.cbxSeePassword.Location = new System.Drawing.Point(249, 145);
            this.cbxSeePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSeePassword.Name = "cbxSeePassword";
            this.cbxSeePassword.Size = new System.Drawing.Size(176, 24);
            this.cbxSeePassword.TabIndex = 4;
            this.cbxSeePassword.Text = "Hiển thị mật khẩu";
            this.cbxSeePassword.UseVisualStyleBackColor = true;
            this.cbxSeePassword.CheckedChanged += new System.EventHandler(this.cbxSeePassword_CheckedChanged);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelRole.Location = new System.Drawing.Point(80, 178);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(60, 25);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Role";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(160, 105);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(265, 26);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelConfirm.Location = new System.Drawing.Point(34, 110);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(111, 25);
            this.labelConfirm.TabIndex = 0;
            this.labelConfirm.Text = "Xác nhận";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(160, 60);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelPassword.Location = new System.Drawing.Point(37, 62);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 25);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(160, 11);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(265, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelUserName.Location = new System.Drawing.Point(3, 14);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(156, 25);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Tên tài khoản";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(234, 325);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(356, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tạo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelMode.Location = new System.Drawing.Point(3, 24);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(145, 25);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Chọn chế độ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonUser);
            this.panel1.Controls.Add(this.radioButtonRole);
            this.panel1.Controls.Add(this.labelMode);
            this.panel1.Location = new System.Drawing.Point(27, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 74);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Checked = true;
            this.radioButtonUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButtonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.radioButtonUser.Location = new System.Drawing.Point(298, 0);
            this.radioButtonUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(72, 74);
            this.radioButtonUser.TabIndex = 1;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // radioButtonRole
            // 
            this.radioButtonRole.AutoSize = true;
            this.radioButtonRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButtonRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.radioButtonRole.Location = new System.Drawing.Point(370, 0);
            this.radioButtonRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonRole.Name = "radioButtonRole";
            this.radioButtonRole.Size = new System.Drawing.Size(71, 74);
            this.radioButtonRole.TabIndex = 2;
            this.radioButtonRole.Text = "Role";
            this.radioButtonRole.UseVisualStyleBackColor = true;
            this.radioButtonRole.CheckedChanged += new System.EventHandler(this.radioButtonRole_CheckedChanged);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 380);
            this.Controls.Add(this.panelRole);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm User";
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelRole.ResumeLayout(false);
            this.panelRole.PerformLayout();
            this.panelRolePassword.ResumeLayout(false);
            this.panelRolePassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonRole;
        private System.Windows.Forms.Panel panelRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.CheckBox cbxSeePassword;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label labelRoleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxUsePassword;
        private System.Windows.Forms.CheckBox cbxSeePassword2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRolePassword;
    }
}