namespace DisplayPsziche
{
    partial class Main
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDataFileName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.word,
            this.interval});
            this.dgvResult.Location = new System.Drawing.Point(1, 1);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(291, 207);
            this.dgvResult.TabIndex = 0;
            // 
            // word
            // 
            this.word.HeaderText = "Szó";
            this.word.Name = "word";
            this.word.ReadOnly = true;
            // 
            // interval
            // 
            this.interval.HeaderText = "Idő";
            this.interval.Name = "interval";
            this.interval.ReadOnly = true;
            // 
            // btnDataFileName
            // 
            this.btnDataFileName.Location = new System.Drawing.Point(104, 214);
            this.btnDataFileName.Name = "btnDataFileName";
            this.btnDataFileName.Size = new System.Drawing.Size(75, 23);
            this.btnDataFileName.TabIndex = 1;
            this.btnDataFileName.Text = "Adatfile";
            this.btnDataFileName.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 248);
            this.Controls.Add(this.btnDataFileName);
            this.Controls.Add(this.dgvResult);
            this.Name = "Main";
            this.Text = "Display Psziche";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn interval;
        private System.Windows.Forms.Button btnDataFileName;
    }
}

