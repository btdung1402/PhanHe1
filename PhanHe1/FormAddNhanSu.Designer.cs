namespace PhanHe1
{
    partial class FormAddNhanSu
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelMode = new System.Windows.Forms.Label();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxDept = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelBDay = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(190, 414);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 113;
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
            this.buttonAdd.Location = new System.Drawing.Point(298, 414);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 112;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelMode);
            this.panelTitle.Location = new System.Drawing.Point(6, 8);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(392, 59);
            this.panelTitle.TabIndex = 110;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.labelMode.Location = new System.Drawing.Point(99, 12);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(216, 36);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "Thêm nhân sự";
            // 
            // panelInformation
            // 
            this.panelInformation.Controls.Add(this.comboBoxRole);
            this.panelInformation.Controls.Add(this.dateTimePicker1);
            this.panelInformation.Controls.Add(this.radioButtonFemale);
            this.panelInformation.Controls.Add(this.radioButtonMale);
            this.panelInformation.Controls.Add(this.textBoxDept);
            this.panelInformation.Controls.Add(this.textBoxPhone);
            this.panelInformation.Controls.Add(this.textBoxSalary);
            this.panelInformation.Controls.Add(this.textBoxName);
            this.panelInformation.Controls.Add(this.textBoxID);
            this.panelInformation.Controls.Add(this.labelWarning);
            this.panelInformation.Controls.Add(this.labelDept);
            this.panelInformation.Controls.Add(this.labelRole);
            this.panelInformation.Controls.Add(this.labelPhone);
            this.panelInformation.Controls.Add(this.labelSalary);
            this.panelInformation.Controls.Add(this.labelBDay);
            this.panelInformation.Controls.Add(this.labelSex);
            this.panelInformation.Controls.Add(this.labelName);
            this.panelInformation.Controls.Add(this.labelID);
            this.panelInformation.Location = new System.Drawing.Point(6, 73);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(392, 334);
            this.panelInformation.TabIndex = 111;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Nhân viên cơ bản",
            "Giảng viên",
            "Giáo vụ",
            "Trưởng đơn vị",
            "Trưởng khoa"});
            this.comboBoxRole.Location = new System.Drawing.Point(110, 255);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(253, 24);
            this.comboBoxRole.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 135);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.radioButtonFemale.Location = new System.Drawing.Point(318, 95);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(45, 20);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.Text = "Nữ";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.radioButtonMale.Location = new System.Drawing.Point(236, 95);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(57, 20);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Nam";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxDept
            // 
            this.textBoxDept.Location = new System.Drawing.Point(110, 295);
            this.textBoxDept.Name = "textBoxDept";
            this.textBoxDept.Size = new System.Drawing.Size(253, 22);
            this.textBoxDept.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(111, 215);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(253, 22);
            this.textBoxPhone.TabIndex = 7;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(110, 175);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(253, 22);
            this.textBoxSalary.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(253, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(110, 15);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(253, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(40, 117);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 16);
            this.labelWarning.TabIndex = 6;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(175)))));
            this.labelDept.Location = new System.Drawing.Point(11, 295);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(90, 20);
            this.labelDept.TabIndex = 0;
            this.labelDept.Text = "Mã đơn vị";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(175)))));
            this.labelRole.Location = new System.Drawing.Point(11, 255);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(65, 20);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Vai trò";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(175)))));
            this.labelPhone.Location = new System.Drawing.Point(11, 215);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(94, 20);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Điện thoại";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(175)))));
            this.labelSalary.Location = new System.Drawing.Point(11, 175);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(77, 20);
            this.labelSalary.TabIndex = 0;
            this.labelSalary.Text = "Phụ cấp";
            // 
            // labelBDay
            // 
            this.labelBDay.AutoSize = true;
            this.labelBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelBDay.Location = new System.Drawing.Point(11, 135);
            this.labelBDay.Name = "labelBDay";
            this.labelBDay.Size = new System.Drawing.Size(92, 20);
            this.labelBDay.TabIndex = 0;
            this.labelBDay.Text = "Ngày sinh";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelSex.Location = new System.Drawing.Point(11, 95);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(46, 20);
            this.labelSex.TabIndex = 0;
            this.labelSex.Text = "Phái";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelName.Location = new System.Drawing.Point(11, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Họ tên";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.labelID.Location = new System.Drawing.Point(11, 15);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(65, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Mã NV";
            // 
            // FormAddNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân sự";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxDept;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelBDay;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
    }
}