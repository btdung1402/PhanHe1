namespace PhanHe1
{
    partial class Grant
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
            this.Grantfor = new System.Windows.Forms.Label();
            this.radioButtonRole = new System.Windows.Forms.RadioButton();
            this.radioButtonRU = new System.Windows.Forms.RadioButton();
            this.labelNameG = new System.Windows.Forms.Label();
            this.textNameG = new System.Windows.Forms.TextBox();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.checkBoxOpion = new System.Windows.Forms.CheckBox();
            this.panelOption = new System.Windows.Forms.Panel();
            this.checkBoxU = new System.Windows.Forms.CheckBox();
            this.checkBoxS = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxI = new System.Windows.Forms.CheckBox();
            this.labelOption = new System.Windows.Forms.Label();
            this.labelTable = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.buttonGrant = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxForU = new System.Windows.Forms.TextBox();
            this.labelForU = new System.Windows.Forms.Label();
            this.panelNotRU = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRU = new System.Windows.Forms.Button();
            this.textBoxRU = new System.Windows.Forms.TextBox();
            this.labelRU = new System.Windows.Forms.Label();
            this.panelOption.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNotRU.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grantfor
            // 
            this.Grantfor.AutoSize = true;
            this.Grantfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grantfor.Location = new System.Drawing.Point(1, 27);
            this.Grantfor.Name = "Grantfor";
            this.Grantfor.Size = new System.Drawing.Size(78, 32);
            this.Grantfor.TabIndex = 0;
            this.Grantfor.Text = "Cấp:";
            // 
            // radioButtonRole
            // 
            this.radioButtonRole.AutoSize = true;
            this.radioButtonRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRole.Location = new System.Drawing.Point(424, 26);
            this.radioButtonRole.Name = "radioButtonRole";
            this.radioButtonRole.Size = new System.Drawing.Size(215, 33);
            this.radioButtonRole.TabIndex = 2;
            this.radioButtonRole.Text = "Quyền cho role";
            this.radioButtonRole.UseVisualStyleBackColor = true;
            this.radioButtonRole.CheckedChanged += new System.EventHandler(this.radioButtonRole_CheckedChanged);
            // 
            // radioButtonRU
            // 
            this.radioButtonRU.AutoSize = true;
            this.radioButtonRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRU.Location = new System.Drawing.Point(756, 26);
            this.radioButtonRU.Name = "radioButtonRU";
            this.radioButtonRU.Size = new System.Drawing.Size(200, 33);
            this.radioButtonRU.TabIndex = 3;
            this.radioButtonRU.Text = "Role cho user";
            this.radioButtonRU.UseVisualStyleBackColor = true;
            this.radioButtonRU.CheckedChanged += new System.EventHandler(this.radioButtonRU_CheckedChanged);
            // 
            // labelNameG
            // 
            this.labelNameG.AutoSize = true;
            this.labelNameG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameG.Location = new System.Drawing.Point(2, 107);
            this.labelNameG.Name = "labelNameG";
            this.labelNameG.Size = new System.Drawing.Size(121, 29);
            this.labelNameG.TabIndex = 4;
            this.labelNameG.Text = "Tên User";
            this.labelNameG.Click += new System.EventHandler(this.labelNameG_Click);
            // 
            // textNameG
            // 
            this.textNameG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameG.Location = new System.Drawing.Point(170, 101);
            this.textNameG.Name = "textNameG";
            this.textNameG.Size = new System.Drawing.Size(327, 39);
            this.textNameG.TabIndex = 5;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Checked = true;
            this.radioButtonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUser.Location = new System.Drawing.Point(140, 26);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(220, 33);
            this.radioButtonUser.TabIndex = 6;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "Quyền cho user";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // checkBoxOpion
            // 
            this.checkBoxOpion.AutoSize = true;
            this.checkBoxOpion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOpion.Location = new System.Drawing.Point(166, 14);
            this.checkBoxOpion.Name = "checkBoxOpion";
            this.checkBoxOpion.Size = new System.Drawing.Size(266, 36);
            this.checkBoxOpion.TabIndex = 7;
            this.checkBoxOpion.Text = "with grant option";
            this.checkBoxOpion.UseVisualStyleBackColor = true;
            this.checkBoxOpion.CheckedChanged += new System.EventHandler(this.checkBoxOpion_CheckedChanged);
            // 
            // panelOption
            // 
            this.panelOption.Controls.Add(this.checkBoxU);
            this.panelOption.Controls.Add(this.checkBoxS);
            this.panelOption.Controls.Add(this.checkBoxD);
            this.panelOption.Controls.Add(this.checkBoxI);
            this.panelOption.Controls.Add(this.labelOption);
            this.panelOption.Location = new System.Drawing.Point(0, 77);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(935, 139);
            this.panelOption.TabIndex = 8;
            this.panelOption.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOption_Paint);
            // 
            // checkBoxU
            // 
            this.checkBoxU.AutoSize = true;
            this.checkBoxU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxU.Location = new System.Drawing.Point(520, 76);
            this.checkBoxU.Name = "checkBoxU";
            this.checkBoxU.Size = new System.Drawing.Size(138, 36);
            this.checkBoxU.TabIndex = 4;
            this.checkBoxU.Text = "Update";
            this.checkBoxU.UseVisualStyleBackColor = true;
            this.checkBoxU.CheckedChanged += new System.EventHandler(this.checkBoxU_CheckedChanged);
            // 
            // checkBoxS
            // 
            this.checkBoxS.AutoSize = true;
            this.checkBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxS.Location = new System.Drawing.Point(520, 24);
            this.checkBoxS.Name = "checkBoxS";
            this.checkBoxS.Size = new System.Drawing.Size(126, 36);
            this.checkBoxS.TabIndex = 3;
            this.checkBoxS.Text = "Select";
            this.checkBoxS.UseVisualStyleBackColor = true;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxD.Location = new System.Drawing.Point(237, 76);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(129, 36);
            this.checkBoxD.TabIndex = 2;
            this.checkBoxD.Text = "Delete";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // checkBoxI
            // 
            this.checkBoxI.AutoSize = true;
            this.checkBoxI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxI.Location = new System.Drawing.Point(237, 24);
            this.checkBoxI.Name = "checkBoxI";
            this.checkBoxI.Size = new System.Drawing.Size(116, 36);
            this.checkBoxI.TabIndex = 1;
            this.checkBoxI.Text = "Insert";
            this.checkBoxI.UseVisualStyleBackColor = true;
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption.Location = new System.Drawing.Point(3, 24);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(194, 32);
            this.labelOption.TabIndex = 0;
            this.labelOption.Text = "Chọn quyền: ";
            this.labelOption.Click += new System.EventHandler(this.labelOption_Click);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.Location = new System.Drawing.Point(6, 238);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(124, 29);
            this.labelTable.TabIndex = 9;
            this.labelTable.Text = "Tên bảng";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTable.Location = new System.Drawing.Point(166, 222);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(324, 39);
            this.textBoxTable.TabIndex = 10;
            // 
            // buttonGrant
            // 
            this.buttonGrant.AutoSize = true;
            this.buttonGrant.BackColor = System.Drawing.Color.Gold;
            this.buttonGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrant.ForeColor = System.Drawing.Color.White;
            this.buttonGrant.Location = new System.Drawing.Point(749, 371);
            this.buttonGrant.Name = "buttonGrant";
            this.buttonGrant.Size = new System.Drawing.Size(215, 48);
            this.buttonGrant.TabIndex = 11;
            this.buttonGrant.Text = "Thực hiện cấp";
            this.buttonGrant.UseVisualStyleBackColor = false;
            this.buttonGrant.Click += new System.EventHandler(this.buttonGrant_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxForU);
            this.panel1.Controls.Add(this.labelForU);
            this.panel1.Location = new System.Drawing.Point(3, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 52);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxForU
            // 
            this.textBoxForU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForU.Location = new System.Drawing.Point(163, 4);
            this.textBoxForU.Name = "textBoxForU";
            this.textBoxForU.Size = new System.Drawing.Size(324, 39);
            this.textBoxForU.TabIndex = 13;
            this.textBoxForU.TextChanged += new System.EventHandler(this.textBoxForU_TextChanged);
            // 
            // labelForU
            // 
            this.labelForU.AutoSize = true;
            this.labelForU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForU.Location = new System.Drawing.Point(3, 10);
            this.labelForU.Name = "labelForU";
            this.labelForU.Size = new System.Drawing.Size(113, 29);
            this.labelForU.TabIndex = 13;
            this.labelForU.Text = "Tên Cột:";
            // 
            // panelNotRU
            // 
            this.panelNotRU.Controls.Add(this.checkBoxOpion);
            this.panelNotRU.Controls.Add(this.buttonGrant);
            this.panelNotRU.Controls.Add(this.panel1);
            this.panelNotRU.Controls.Add(this.panelOption);
            this.panelNotRU.Controls.Add(this.labelTable);
            this.panelNotRU.Controls.Add(this.textBoxTable);
            this.panelNotRU.Location = new System.Drawing.Point(7, 165);
            this.panelNotRU.Name = "panelNotRU";
            this.panelNotRU.Size = new System.Drawing.Size(1028, 422);
            this.panelNotRU.TabIndex = 13;
            this.panelNotRU.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNotRU_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRU);
            this.panel2.Controls.Add(this.textBoxRU);
            this.panel2.Controls.Add(this.labelRU);
            this.panel2.Location = new System.Drawing.Point(527, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 128);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // buttonRU
            // 
            this.buttonRU.AutoSize = true;
            this.buttonRU.BackColor = System.Drawing.Color.Gold;
            this.buttonRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRU.ForeColor = System.Drawing.Color.White;
            this.buttonRU.Location = new System.Drawing.Point(229, 77);
            this.buttonRU.Name = "buttonRU";
            this.buttonRU.Size = new System.Drawing.Size(215, 48);
            this.buttonRU.TabIndex = 13;
            this.buttonRU.Text = "Thực hiện cấp";
            this.buttonRU.UseVisualStyleBackColor = false;
            this.buttonRU.Click += new System.EventHandler(this.buttonRU_Click);
            // 
            // textBoxRU
            // 
            this.textBoxRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRU.Location = new System.Drawing.Point(154, 20);
            this.textBoxRU.Name = "textBoxRU";
            this.textBoxRU.Size = new System.Drawing.Size(327, 39);
            this.textBoxRU.TabIndex = 15;
            this.textBoxRU.TextChanged += new System.EventHandler(this.textBoxRU_TextChanged);
            // 
            // labelRU
            // 
            this.labelRU.AutoSize = true;
            this.labelRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRU.Location = new System.Drawing.Point(3, 24);
            this.labelRU.Name = "labelRU";
            this.labelRU.Size = new System.Drawing.Size(121, 29);
            this.labelRU.TabIndex = 15;
            this.labelRU.Text = "Tên Role";
            // 
            // Grant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1085, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNotRU);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.textNameG);
            this.Controls.Add(this.labelNameG);
            this.Controls.Add(this.radioButtonRU);
            this.Controls.Add(this.radioButtonRole);
            this.Controls.Add(this.Grantfor);
            this.Name = "Grant";
            this.Text = "Grant";
            this.Load += new System.EventHandler(this.Grant_Load);
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNotRU.ResumeLayout(false);
            this.panelNotRU.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Grantfor;
        private System.Windows.Forms.RadioButton radioButtonRole;
        private System.Windows.Forms.RadioButton radioButtonRU;
        private System.Windows.Forms.Label labelNameG;
        private System.Windows.Forms.TextBox textNameG;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.CheckBox checkBoxOpion;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.CheckBox checkBoxU;
        private System.Windows.Forms.CheckBox checkBoxS;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.CheckBox checkBoxI;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Button buttonGrant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelForU;
        private System.Windows.Forms.TextBox textBoxForU;
        private System.Windows.Forms.Panel panelNotRU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRU;
        private System.Windows.Forms.TextBox textBoxRU;
        private System.Windows.Forms.Label labelRU;
    }
}