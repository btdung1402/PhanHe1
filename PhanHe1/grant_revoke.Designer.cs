namespace PhanHe1
{
    partial class grant_revoke
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
            this.radbuttonR = new System.Windows.Forms.RadioButton();
            this.radTittleGR = new System.Windows.Forms.Label();
            this.panelExecuteGR = new System.Windows.Forms.Panel();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.radiobuttonG = new System.Windows.Forms.RadioButton();
            this.radPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPanel
            // 
            this.radPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radPanel.Controls.Add(this.radiobuttonG);
            this.radPanel.Controls.Add(this.radbuttonR);
            this.radPanel.Controls.Add(this.radTittleGR);
            this.radPanel.Location = new System.Drawing.Point(20, 26);
            this.radPanel.Name = "radPanel";
            this.radPanel.Size = new System.Drawing.Size(1075, 70);
            this.radPanel.TabIndex = 0;
            this.radPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.radPanel_Paint);
            // 
            // radbuttonR
            // 
            this.radbuttonR.AutoSize = true;
            this.radbuttonR.Checked = true;
            this.radbuttonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbuttonR.Location = new System.Drawing.Point(397, 18);
            this.radbuttonR.Name = "radbuttonR";
            this.radbuttonR.Size = new System.Drawing.Size(126, 33);
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
            this.radTittleGR.Location = new System.Drawing.Point(3, 17);
            this.radTittleGR.Name = "radTittleGR";
            this.radTittleGR.Size = new System.Drawing.Size(156, 32);
            this.radTittleGR.TabIndex = 0;
            this.radTittleGR.Text = "Lựa chọn: ";
            // 
            // panelExecuteGR
            // 
            this.panelExecuteGR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelExecuteGR.BackColor = System.Drawing.SystemColors.Info;
            this.panelExecuteGR.Location = new System.Drawing.Point(20, 102);
            this.panelExecuteGR.Name = "panelExecuteGR";
            this.panelExecuteGR.Size = new System.Drawing.Size(1074, 591);
            this.panelExecuteGR.TabIndex = 1;
            this.panelExecuteGR.Paint += new System.Windows.Forms.PaintEventHandler(this.panelExecuteGR_Paint);
            // 
            // radiobuttonG
            // 
            this.radiobuttonG.AutoSize = true;
            this.radiobuttonG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonG.Location = new System.Drawing.Point(246, 18);
            this.radiobuttonG.Name = "radiobuttonG";
            this.radiobuttonG.Size = new System.Drawing.Size(101, 33);
            this.radiobuttonG.TabIndex = 4;
            this.radiobuttonG.Text = "Grant";
            this.radiobuttonG.UseVisualStyleBackColor = true;
            this.radiobuttonG.CheckedChanged += new System.EventHandler(this.radiobuttonG_CheckedChanged_1);
            // 
            // grant_revoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 721);
            this.Controls.Add(this.panelExecuteGR);
            this.Controls.Add(this.radPanel);
            this.Name = "grant_revoke";
            this.Text = "Form2";
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