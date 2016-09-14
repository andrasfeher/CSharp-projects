namespace HDCleaner
{
    partial class MainForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.pbrPassProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(103, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pbrPassProgress
            // 
            this.pbrPassProgress.Location = new System.Drawing.Point(37, 49);
            this.pbrPassProgress.Maximum = 10000;
            this.pbrPassProgress.Name = "pbrPassProgress";
            this.pbrPassProgress.Size = new System.Drawing.Size(220, 23);
            this.pbrPassProgress.Step = 1;
            this.pbrPassProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrPassProgress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pass:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(144, 23);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(24, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "0/7";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 128);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbrPassProgress);
            this.Controls.Add(this.btnOK);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDCleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ProgressBar pbrPassProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPass;
    }
}

