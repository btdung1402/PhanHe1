namespace PhanHe2
{
    partial class FormList
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
            this.btnLockUnlock = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnDelData = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
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
            this.dtgv.Location = new System.Drawing.Point(4, -1);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(556, 384);
            this.dtgv.TabIndex = 0;
            // 
            // btnLockUnlock
            // 
            this.btnLockUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnLockUnlock.FlatAppearance.BorderSize = 0;
            this.btnLockUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockUnlock.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockUnlock.ForeColor = System.Drawing.Color.White;
            this.btnLockUnlock.Location = new System.Drawing.Point(569, 236);
            this.btnLockUnlock.Name = "btnLockUnlock";
            this.btnLockUnlock.Size = new System.Drawing.Size(81, 45);
            this.btnLockUnlock.TabIndex = 1;
            this.btnLockUnlock.Text = "Lock Unlock";
            this.btnLockUnlock.UseVisualStyleBackColor = false;
            this.btnLockUnlock.Click += new System.EventHandler(this.btnLockUnlock_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(569, 338);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(81, 45);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Thêm mới";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnShowUsers.FlatAppearance.BorderSize = 0;
            this.btnShowUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUsers.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUsers.ForeColor = System.Drawing.Color.White;
            this.btnShowUsers.Location = new System.Drawing.Point(569, 83);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(81, 45);
            this.btnShowUsers.TabIndex = 1;
            this.btnShowUsers.Text = "Hiển thị lại";
            this.btnShowUsers.UseVisualStyleBackColor = false;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnDelData
            // 
            this.btnDelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnDelData.FlatAppearance.BorderSize = 0;
            this.btnDelData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelData.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelData.ForeColor = System.Drawing.Color.White;
            this.btnDelData.Location = new System.Drawing.Point(569, 32);
            this.btnDelData.Name = "btnDelData";
            this.btnDelData.Size = new System.Drawing.Size(81, 45);
            this.btnDelData.TabIndex = 1;
            this.btnDelData.Text = "Xóa dữ liệu";
            this.btnDelData.UseVisualStyleBackColor = false;
            this.btnDelData.Click += new System.EventHandler(this.btnDelData_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(569, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 45);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(569, 287);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(81, 45);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(125)))));
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.ForeColor = System.Drawing.Color.White;
            this.btnRole.Location = new System.Drawing.Point(569, 134);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(81, 45);
            this.btnRole.TabIndex = 1;
            this.btnRole.Text = "Hiển thị Role";
            this.btnRole.UseVisualStyleBackColor = false;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // FormList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(660, 395);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelData);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLockUnlock);
            this.Controls.Add(this.dtgv);
            this.Name = "FormList";
            this.Text = "Xem Users";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btnLockUnlock;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnDelData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnRole;
    }
}