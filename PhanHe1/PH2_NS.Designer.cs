namespace PhanHe1
{
    partial class PH2_NS
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
            this.SDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_i = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_u = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.phucap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.in_s = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mans = new System.Windows.Forms.TextBox();
            this.MaDV = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(770, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(500, 312);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(109, 26);
            this.SDT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số Điện Thoại";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_i
            // 
            this.btn_i.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_i.Location = new System.Drawing.Point(615, 277);
            this.btn_i.Name = "btn_i";
            this.btn_i.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_i.Size = new System.Drawing.Size(142, 44);
            this.btn_i.TabIndex = 3;
            this.btn_i.Text = "Thêm Nhân sự";
            this.btn_i.UseVisualStyleBackColor = true;
            this.btn_i.Click += new System.EventHandler(this.btn_i_Click);
            // 
            // btn_d
            // 
            this.btn_d.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_d.Location = new System.Drawing.Point(615, 394);
            this.btn_d.Name = "btn_d";
            this.btn_d.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_d.Size = new System.Drawing.Size(142, 44);
            this.btn_d.TabIndex = 4;
            this.btn_d.Text = "Xoá Nhân sự";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // btn_u
            // 
            this.btn_u.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_u.Location = new System.Drawing.Point(615, 339);
            this.btn_u.Name = "btn_u";
            this.btn_u.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_u.Size = new System.Drawing.Size(142, 44);
            this.btn_u.TabIndex = 5;
            this.btn_u.Text = "Cập nhật";
            this.btn_u.UseVisualStyleBackColor = true;
            this.btn_u.Click += new System.EventHandler(this.btn_u_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.phucap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.role);
            this.panel1.Controls.Add(this.birth);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.in_s);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.hoten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mans);
            this.panel1.Location = new System.Drawing.Point(17, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 173);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Phụ cấp";
            // 
            // phucap
            // 
            this.phucap.Location = new System.Drawing.Point(336, 120);
            this.phucap.Name = "phucap";
            this.phucap.Size = new System.Drawing.Size(109, 26);
            this.phucap.TabIndex = 28;
            this.phucap.TextChanged += new System.EventHandler(this.phucap_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Vai Trò";
            // 
            // role
            // 
            this.role.Location = new System.Drawing.Point(190, 120);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(109, 26);
            this.role.TabIndex = 26;
            this.role.TextChanged += new System.EventHandler(this.role_TextChanged);
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Location = new System.Drawing.Point(31, 97);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(78, 20);
            this.birth.TabIndex = 25;
            this.birth.Text = "Ngày sinh";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phái";
            // 
            // in_s
            // 
            this.in_s.Location = new System.Drawing.Point(340, 55);
            this.in_s.Name = "in_s";
            this.in_s.Size = new System.Drawing.Size(109, 26);
            this.in_s.TabIndex = 22;
            this.in_s.TextChanged += new System.EventHandler(this.in_s_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Họ tên";
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(194, 55);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(109, 26);
            this.hoten.TabIndex = 20;
            this.hoten.TextChanged += new System.EventHandler(this.hoten_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã NS";
            // 
            // mans
            // 
            this.mans.Location = new System.Drawing.Point(35, 55);
            this.mans.Name = "mans";
            this.mans.Size = new System.Drawing.Size(109, 26);
            this.mans.TabIndex = 18;
            this.mans.TextChanged += new System.EventHandler(this.mans_TextChanged);
            // 
            // MaDV
            // 
            this.MaDV.AutoSize = true;
            this.MaDV.Location = new System.Drawing.Point(504, 354);
            this.MaDV.Name = "MaDV";
            this.MaDV.Size = new System.Drawing.Size(76, 20);
            this.MaDV.TabIndex = 8;
            this.MaDV.Text = "Mã đơn vị";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(504, 377);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 26);
            this.textBox2.TabIndex = 7;
            // 
            // PH2_NS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.MaDV);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_u);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_i);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PH2_NS";
            this.Text = "PH2_NS";
            this.Load += new System.EventHandler(this.PH2_NS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_i;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_u;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phucap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox in_s;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mans;
        private System.Windows.Forms.Label MaDV;
        private System.Windows.Forms.TextBox textBox2;
    }
}