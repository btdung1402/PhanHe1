namespace PhanHe1
{
    partial class FormAudit
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
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.radioStdAudit = new System.Windows.Forms.RadioButton();
            this.radioFGACAudit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageAudit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToOrderColumns = true;
            this.dtgv.AllowUserToResizeRows = false;
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
            this.dtgv.Location = new System.Drawing.Point(12, 59);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(853, 412);
            this.dtgv.TabIndex = 1;
            // 
            // radioStdAudit
            // 
            this.radioStdAudit.AutoSize = true;
            this.radioStdAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.radioStdAudit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.radioStdAudit.Location = new System.Drawing.Point(201, 18);
            this.radioStdAudit.Name = "radioStdAudit";
            this.radioStdAudit.Size = new System.Drawing.Size(137, 21);
            this.radioStdAudit.TabIndex = 2;
            this.radioStdAudit.Text = "Standard Audit";
            this.radioStdAudit.UseVisualStyleBackColor = true;
            this.radioStdAudit.CheckedChanged += new System.EventHandler(this.radioStdAudit_CheckedChanged);
            // 
            // radioFGACAudit
            // 
            this.radioFGACAudit.AutoSize = true;
            this.radioFGACAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.radioFGACAudit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.radioFGACAudit.Location = new System.Drawing.Point(372, 18);
            this.radioFGACAudit.Name = "radioFGACAudit";
            this.radioFGACAudit.Size = new System.Drawing.Size(259, 21);
            this.radioFGACAudit.TabIndex = 3;
            this.radioFGACAudit.Text = "Fine-graind Acess Control Audit";
            this.radioFGACAudit.UseVisualStyleBackColor = true;
            this.radioFGACAudit.CheckedChanged += new System.EventHandler(this.radioFGACAudit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn chế độ xem:";
            // 
            // btnManageAudit
            // 
            this.btnManageAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnManageAudit.FlatAppearance.BorderSize = 0;
            this.btnManageAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAudit.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageAudit.ForeColor = System.Drawing.Color.White;
            this.btnManageAudit.Location = new System.Drawing.Point(754, 11);
            this.btnManageAudit.Name = "btnManageAudit";
            this.btnManageAudit.Size = new System.Drawing.Size(111, 39);
            this.btnManageAudit.TabIndex = 5;
            this.btnManageAudit.Text = "Quản lý";
            this.btnManageAudit.UseVisualStyleBackColor = false;
            this.btnManageAudit.Click += new System.EventHandler(this.btnManageAudit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(648, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 39);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 483);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnManageAudit);
            this.Controls.Add(this.radioFGACAudit);
            this.Controls.Add(this.radioStdAudit);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label1);
            this.Name = "FormAudit";
            this.Text = "Audit";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.RadioButton radioFGACAudit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageAudit;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.RadioButton radioStdAudit;
    }
}