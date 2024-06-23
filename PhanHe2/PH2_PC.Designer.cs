namespace PhanHe2
{
    partial class PH2_PC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnthem = new System.Windows.Forms.Panel();
            this.comboBoxCT = new System.Windows.Forms.ComboBox();
            this.tbyear = new System.Windows.Forms.TextBox();
            this.tbpcid = new System.Windows.Forms.TextBox();
            this.tbnam = new System.Windows.Forms.TextBox();
            this.tbmahp = new System.Windows.Forms.TextBox();
            this.tbmagv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.pnthem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnthem
            // 
            this.pnthem.Controls.Add(this.comboBoxCT);
            this.pnthem.Controls.Add(this.tbyear);
            this.pnthem.Controls.Add(this.tbpcid);
            this.pnthem.Controls.Add(this.tbnam);
            this.pnthem.Controls.Add(this.tbmahp);
            this.pnthem.Controls.Add(this.tbmagv);
            this.pnthem.Controls.Add(this.label6);
            this.pnthem.Controls.Add(this.label5);
            this.pnthem.Controls.Add(this.label4);
            this.pnthem.Controls.Add(this.label3);
            this.pnthem.Controls.Add(this.label2);
            this.pnthem.Controls.Add(this.label1);
            this.pnthem.Location = new System.Drawing.Point(13, 438);
            this.pnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnthem.Name = "pnthem";
            this.pnthem.Size = new System.Drawing.Size(480, 138);
            this.pnthem.TabIndex = 1;
            this.pnthem.Visible = false;
            // 
            // comboBoxCT
            // 
            this.comboBoxCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCT.FormattingEnabled = true;
            this.comboBoxCT.Items.AddRange(new object[] {
            "CLC",
            "CQ"});
            this.comboBoxCT.Location = new System.Drawing.Point(195, 78);
            this.comboBoxCT.Name = "comboBoxCT";
            this.comboBoxCT.Size = new System.Drawing.Size(90, 24);
            this.comboBoxCT.TabIndex = 30;
            // 
            // tbyear
            // 
            this.tbyear.Location = new System.Drawing.Point(47, 78);
            this.tbyear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbyear.Name = "tbyear";
            this.tbyear.Size = new System.Drawing.Size(89, 22);
            this.tbyear.TabIndex = 29;
            // 
            // tbpcid
            // 
            this.tbpcid.Location = new System.Drawing.Point(343, 78);
            this.tbpcid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpcid.Name = "tbpcid";
            this.tbpcid.Size = new System.Drawing.Size(89, 22);
            this.tbpcid.TabIndex = 28;
            // 
            // tbnam
            // 
            this.tbnam.Location = new System.Drawing.Point(343, 27);
            this.tbnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnam.Name = "tbnam";
            this.tbnam.Size = new System.Drawing.Size(89, 22);
            this.tbnam.TabIndex = 27;
            // 
            // tbmahp
            // 
            this.tbmahp.Location = new System.Drawing.Point(196, 27);
            this.tbmahp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmahp.Name = "tbmahp";
            this.tbmahp.Size = new System.Drawing.Size(89, 22);
            this.tbmahp.TabIndex = 26;
            // 
            // tbmagv
            // 
            this.tbmagv.Location = new System.Drawing.Point(47, 27);
            this.tbmagv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmagv.Name = "tbmagv";
            this.tbmagv.Size = new System.Drawing.Size(89, 22);
            this.tbmagv.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mã CT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "HK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ma HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã GV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phân công Id";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(713, 516);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(160, 46);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xoá phân công";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Visible = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_capnhat.Location = new System.Drawing.Point(516, 447);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(172, 46);
            this.btn_capnhat.TabIndex = 17;
            this.btn_capnhat.Text = "Cập nhật phân công";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Visible = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnI.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.ForeColor = System.Drawing.Color.White;
            this.btnI.Location = new System.Drawing.Point(516, 516);
            this.btnI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(172, 47);
            this.btnI.TabIndex = 16;
            this.btnI.Text = "Thêm phân công";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Visible = false;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 416);
            this.dataGridView1.TabIndex = 31;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(713, 447);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(160, 46);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // PH2_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 634);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.pnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_capnhat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PH2_PC";
            this.Text = "Phân công";
            this.Load += new System.EventHandler(this.PH2_PC_Load);
            this.pnthem.ResumeLayout(false);
            this.pnthem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnthem;
        private System.Windows.Forms.TextBox tbyear;
        private System.Windows.Forms.TextBox tbpcid;
        private System.Windows.Forms.TextBox tbnam;
        private System.Windows.Forms.TextBox tbmahp;
        private System.Windows.Forms.TextBox tbmagv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBoxCT;
    }
}