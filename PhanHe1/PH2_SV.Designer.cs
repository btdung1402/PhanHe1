namespace PhanHe1
{
    partial class PH2_SV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ttSV = new System.Windows.Forms.Panel();
            this.tbMSV = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBS = new System.Windows.Forms.TextBox();
            this.tBDate = new System.Windows.Forms.TextBox();
            this.tBAddr = new System.Windows.Forms.TextBox();
            this.tBPhone = new System.Windows.Forms.TextBox();
            this.tBMCT = new System.Windows.Forms.TextBox();
            this.tBMj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_i = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ttSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // ttSV
            // 
            this.ttSV.Controls.Add(this.label8);
            this.ttSV.Controls.Add(this.label7);
            this.ttSV.Controls.Add(this.label6);
            this.ttSV.Controls.Add(this.label5);
            this.ttSV.Controls.Add(this.label4);
            this.ttSV.Controls.Add(this.label3);
            this.ttSV.Controls.Add(this.label2);
            this.ttSV.Controls.Add(this.label1);
            this.ttSV.Controls.Add(this.tBMj);
            this.ttSV.Controls.Add(this.tBMCT);
            this.ttSV.Controls.Add(this.tBPhone);
            this.ttSV.Controls.Add(this.tBAddr);
            this.ttSV.Controls.Add(this.tBDate);
            this.ttSV.Controls.Add(this.tBS);
            this.ttSV.Controls.Add(this.tBName);
            this.ttSV.Controls.Add(this.tbMSV);
            this.ttSV.Location = new System.Drawing.Point(45, 349);
            this.ttSV.Name = "ttSV";
            this.ttSV.Size = new System.Drawing.Size(633, 148);
            this.ttSV.TabIndex = 1;
            this.ttSV.Visible = false;
            this.ttSV.Paint += new System.Windows.Forms.PaintEventHandler(this.ttSV_Paint);
            // 
            // tbMSV
            // 
            this.tbMSV.Location = new System.Drawing.Point(34, 34);
            this.tbMSV.Name = "tbMSV";
            this.tbMSV.Size = new System.Drawing.Size(100, 26);
            this.tbMSV.TabIndex = 0;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(172, 34);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 26);
            this.tBName.TabIndex = 1;
            // 
            // tBS
            // 
            this.tBS.Location = new System.Drawing.Point(313, 34);
            this.tBS.Name = "tBS";
            this.tBS.Size = new System.Drawing.Size(100, 26);
            this.tBS.TabIndex = 2;
            // 
            // tBDate
            // 
            this.tBDate.Location = new System.Drawing.Point(442, 34);
            this.tBDate.Name = "tBDate";
            this.tBDate.Size = new System.Drawing.Size(100, 26);
            this.tBDate.TabIndex = 3;
            // 
            // tBAddr
            // 
            this.tBAddr.Location = new System.Drawing.Point(34, 108);
            this.tBAddr.Name = "tBAddr";
            this.tBAddr.Size = new System.Drawing.Size(100, 26);
            this.tBAddr.TabIndex = 4;
            // 
            // tBPhone
            // 
            this.tBPhone.Location = new System.Drawing.Point(172, 108);
            this.tBPhone.Name = "tBPhone";
            this.tBPhone.Size = new System.Drawing.Size(100, 26);
            this.tBPhone.TabIndex = 5;
            // 
            // tBMCT
            // 
            this.tBMCT.Location = new System.Drawing.Point(313, 108);
            this.tBMCT.Name = "tBMCT";
            this.tBMCT.Size = new System.Drawing.Size(100, 26);
            this.tBMCT.TabIndex = 6;
            // 
            // tBMj
            // 
            this.tBMj.Location = new System.Drawing.Point(442, 108);
            this.tBMj.Name = "tBMj";
            this.tBMj.Size = new System.Drawing.Size(100, 26);
            this.tBMj.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã CT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã ngành";
            // 
            // btn_i
            // 
            this.btn_i.Location = new System.Drawing.Point(710, 349);
            this.btn_i.Name = "btn_i";
            this.btn_i.Size = new System.Drawing.Size(163, 49);
            this.btn_i.TabIndex = 2;
            this.btn_i.Text = "Thêm sinh viên";
            this.btn_i.UseVisualStyleBackColor = true;
            this.btn_i.Visible = false;
            this.btn_i.Click += new System.EventHandler(this.btn_i_Click);
            // 
            // PH2_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 537);
            this.Controls.Add(this.btn_i);
            this.Controls.Add(this.ttSV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PH2_SV";
            this.Text = "PH2_SV";
            this.Load += new System.EventHandler(this.PH2_SV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ttSV.ResumeLayout(false);
            this.ttSV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ttSV;
        private System.Windows.Forms.TextBox tBMj;
        private System.Windows.Forms.TextBox tBMCT;
        private System.Windows.Forms.TextBox tBPhone;
        private System.Windows.Forms.TextBox tBAddr;
        private System.Windows.Forms.TextBox tBDate;
        private System.Windows.Forms.TextBox tBS;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tbMSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_i;
    }
}