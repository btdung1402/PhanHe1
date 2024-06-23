namespace PhanHe2
{
    partial class FormAuditManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAuditUser = new System.Windows.Forms.CheckBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAction = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelObject = new System.Windows.Forms.Label();
            this.panelAuditObject = new System.Windows.Forms.Panel();
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.labelOpt = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelAuditObject.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxAuditUser);
            this.panel1.Controls.Add(this.labelMode);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 59);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxAuditUser
            // 
            this.checkBoxAuditUser.AutoSize = true;
            this.checkBoxAuditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.checkBoxAuditUser.Location = new System.Drawing.Point(279, 21);
            this.checkBoxAuditUser.Name = "checkBoxAuditUser";
            this.checkBoxAuditUser.Size = new System.Drawing.Size(91, 20);
            this.checkBoxAuditUser.TabIndex = 8;
            this.checkBoxAuditUser.Text = "Audit User";
            this.checkBoxAuditUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAuditUser.UseVisualStyleBackColor = true;
            this.checkBoxAuditUser.CheckedChanged += new System.EventHandler(this.checkBoxAuditUser_CheckedChanged);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelMode.Location = new System.Drawing.Point(30, 14);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(170, 26);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "Standard Audit";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(88, 210);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 100;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(304, 210);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelAction.Location = new System.Drawing.Point(33, 50);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(62, 20);
            this.labelAction.TabIndex = 0;
            this.labelAction.Text = "Action";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(40, 117);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 16);
            this.labelWarning.TabIndex = 6;
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelObject.Location = new System.Drawing.Point(31, 11);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(64, 20);
            this.labelObject.TabIndex = 0;
            this.labelObject.Text = "Object";
            // 
            // panelAuditObject
            // 
            this.panelAuditObject.Controls.Add(this.comboBoxOption);
            this.panelAuditObject.Controls.Add(this.comboBoxAction);
            this.panelAuditObject.Controls.Add(this.labelWarning);
            this.panelAuditObject.Controls.Add(this.labelOpt);
            this.panelAuditObject.Controls.Add(this.labelAction);
            this.panelAuditObject.Controls.Add(this.labelObject);
            this.panelAuditObject.Controls.Add(this.comboBoxObject);
            this.panelAuditObject.Controls.Add(this.comboBoxUser);
            this.panelAuditObject.Location = new System.Drawing.Point(12, 77);
            this.panelAuditObject.Name = "panelAuditObject";
            this.panelAuditObject.Size = new System.Drawing.Size(392, 126);
            this.panelAuditObject.TabIndex = 0;
            // 
            // comboBoxOption
            // 
            this.comboBoxOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.comboBoxOption.FormattingEnabled = true;
            this.comboBoxOption.Items.AddRange(new object[] {
            "BY ACCESS",
            "WHENEVER NOT SUCCESSFUL",
            "WHENEVER SUCCESSFUL"});
            this.comboBoxOption.Location = new System.Drawing.Point(141, 89);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(233, 24);
            this.comboBoxOption.TabIndex = 3;
            this.comboBoxOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxOption_SelectedIndexChanged);
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "EXECUTE",
            "ALL"});
            this.comboBoxAction.Location = new System.Drawing.Point(141, 50);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(233, 24);
            this.comboBoxAction.TabIndex = 2;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Items.AddRange(new object[] {
            "SINHVIEN",
            "DONVI",
            "NHANSU",
            "HOCPHAN",
            "KHMO",
            "PHANCONG",
            "DANGKY",
            "THONGBAO"});
            this.comboBoxObject.Location = new System.Drawing.Point(141, 11);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(233, 24);
            this.comboBoxObject.TabIndex = 1;
            this.comboBoxObject.SelectedIndexChanged += new System.EventHandler(this.comboBoxObject_SelectedIndexChanged);
            // 
            // labelOpt
            // 
            this.labelOpt.AutoSize = true;
            this.labelOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelOpt.Location = new System.Drawing.Point(33, 93);
            this.labelOpt.Name = "labelOpt";
            this.labelOpt.Size = new System.Drawing.Size(64, 20);
            this.labelOpt.TabIndex = 0;
            this.labelOpt.Text = "Option";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(196, 210);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 28);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Xóa";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "SINHVIEN",
            "DONVI",
            "NHANSU",
            "HOCPHAN",
            "KHMO",
            "PHANCONG",
            "DANGKY",
            "THONGBAO"});
            this.comboBoxUser.Location = new System.Drawing.Point(141, 11);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(233, 24);
            this.comboBoxUser.TabIndex = 10;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // FormAuditManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 269);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelAuditObject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuditManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddAudit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAuditObject.ResumeLayout(false);
            this.panelAuditObject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.Panel panelAuditObject;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxOption;
        private System.Windows.Forms.Label labelOpt;
        private System.Windows.Forms.CheckBox checkBoxAuditUser;
        private System.Windows.Forms.ComboBox comboBoxUser;
    }
}