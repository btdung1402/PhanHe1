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
            this.textNameG.Size = new System.Drawing.Size(393, 39);
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
            // Grant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1085, 631);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.textNameG);
            this.Controls.Add(this.labelNameG);
            this.Controls.Add(this.radioButtonRU);
            this.Controls.Add(this.radioButtonRole);
            this.Controls.Add(this.Grantfor);
            this.Name = "Grant";
            this.Text = "Grant";
            this.Load += new System.EventHandler(this.Grant_Load);
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
    }
}