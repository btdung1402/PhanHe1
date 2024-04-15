namespace PhanHe1
{
    partial class FormGrant_Revoke
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
            this.radPanel = new System.Windows.Forms.Panel();
            this.radiobuttonG = new System.Windows.Forms.RadioButton();
            this.radbuttonR = new System.Windows.Forms.RadioButton();
            this.radTittleGR = new System.Windows.Forms.Label();
            this.panelExecuteGR = new System.Windows.Forms.Panel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.radPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPanel
            // 
            this.radPanel.Controls.Add(this.radiobuttonG);
            this.radPanel.Controls.Add(this.radbuttonR);
            this.radPanel.Controls.Add(this.radTittleGR);
            this.radPanel.Location = new System.Drawing.Point(154, 21);
            this.radPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPanel.Name = "radPanel";
            this.radPanel.Size = new System.Drawing.Size(651, 56);
            this.radPanel.TabIndex = 0;
            this.radPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel_Paint);
            // 
            // radiobuttonG
            // 
            this.radiobuttonG.AutoSize = true;
            this.radiobuttonG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonG.ForeColor = System.Drawing.Color.White;
            this.radiobuttonG.Location = new System.Drawing.Point(219, 14);
            this.radiobuttonG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobuttonG.Name = "radiobuttonG";
            this.radiobuttonG.Size = new System.Drawing.Size(86, 29);
            this.radiobuttonG.TabIndex = 4;
            this.radiobuttonG.Text = "Grant";
            this.radiobuttonG.UseVisualStyleBackColor = true;
            this.radiobuttonG.CheckedChanged += new System.EventHandler(this.radiobuttonG_CheckedChanged_1);
            // 
            // radbuttonR
            // 
            this.radbuttonR.AutoSize = true;
            this.radbuttonR.Checked = true;
            this.radbuttonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbuttonR.ForeColor = System.Drawing.Color.White;
            this.radbuttonR.Location = new System.Drawing.Point(353, 14);
            this.radbuttonR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radbuttonR.Name = "radbuttonR";
            this.radbuttonR.Size = new System.Drawing.Size(105, 29);
            this.radbuttonR.TabIndex = 2;
            this.radbuttonR.TabStop = true;
            this.radbuttonR.Text = "Revoke";
            this.radbuttonR.UseVisualStyleBackColor = true;
            this.radbuttonR.CheckedChanged += new System.EventHandler(this.radbuttonR_CheckedChanged);
            // 
            // radTittleGR
            // 
            this.radTittleGR.AutoSize = true;
            this.radTittleGR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTittleGR.ForeColor = System.Drawing.Color.White;
            this.radTittleGR.Location = new System.Drawing.Point(3, 14);
            this.radTittleGR.Name = "radTittleGR";
            this.radTittleGR.Size = new System.Drawing.Size(132, 29);
            this.radTittleGR.TabIndex = 0;
            this.radTittleGR.Text = "Lựa chọn: ";
            // 
            // panelExecuteGR
            // 
            this.panelExecuteGR.BackColor = System.Drawing.SystemColors.Control;
            this.panelExecuteGR.Location = new System.Drawing.Point(12, 81);
            this.panelExecuteGR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExecuteGR.Name = "panelExecuteGR";
            this.panelExecuteGR.Size = new System.Drawing.Size(833, 412);
            this.panelExecuteGR.TabIndex = 1;
            // 
            // FormGrant_Revoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(857, 504);
            this.Controls.Add(this.panelExecuteGR);
            this.Controls.Add(this.radPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGrant_Revoke";
            this.Text = "Trao/Tước quyền";
            this.radPanel.ResumeLayout(false);
            this.radPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel radPanel;
        private System.Windows.Forms.Label radTittleGR;
        private System.Windows.Forms.RadioButton radbuttonR;
        private System.Windows.Forms.Panel panelExecuteGR;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.RadioButton radiobuttonG;
    }
}