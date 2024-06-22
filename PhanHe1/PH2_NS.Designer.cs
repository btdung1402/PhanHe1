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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_i = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_u = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_i
            // 
            this.btn_i.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_i.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_i.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_i.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btn_i.ForeColor = System.Drawing.Color.White;
            this.btn_i.Location = new System.Drawing.Point(338, 432);
            this.btn_i.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_i.Name = "btn_i";
            this.btn_i.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_i.Size = new System.Drawing.Size(143, 32);
            this.btn_i.TabIndex = 3;
            this.btn_i.Text = "Thêm Nhân sự";
            this.btn_i.UseVisualStyleBackColor = false;
            this.btn_i.Click += new System.EventHandler(this.btn_i_Click);
            // 
            // btn_d
            // 
            this.btn_d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_d.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_d.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btn_d.ForeColor = System.Drawing.Color.White;
            this.btn_d.Location = new System.Drawing.Point(619, 432);
            this.btn_d.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_d.Name = "btn_d";
            this.btn_d.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_d.Size = new System.Drawing.Size(126, 32);
            this.btn_d.TabIndex = 4;
            this.btn_d.Text = "Xoá Nhân sự";
            this.btn_d.UseVisualStyleBackColor = false;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // btn_u
            // 
            this.btn_u.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btn_u.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_u.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btn_u.ForeColor = System.Drawing.Color.White;
            this.btn_u.Location = new System.Drawing.Point(487, 432);
            this.btn_u.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_u.Name = "btn_u";
            this.btn_u.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_u.Size = new System.Drawing.Size(126, 32);
            this.btn_u.TabIndex = 5;
            this.btn_u.Text = "Cập nhật";
            this.btn_u.UseVisualStyleBackColor = false;
            this.btn_u.Click += new System.EventHandler(this.btn_u_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(752, 432);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonRefresh.Size = new System.Drawing.Size(126, 32);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToOrderColumns = true;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.dtgv.Location = new System.Drawing.Point(12, 12);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(866, 415);
            this.dtgv.TabIndex = 10;
            // 
            // PH2_NS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 474);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.btn_u);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_i);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PH2_NS";
            this.Text = "Nhân sự";
            this.Load += new System.EventHandler(this.PH2_NS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_i;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_u;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dtgv;
    }
}