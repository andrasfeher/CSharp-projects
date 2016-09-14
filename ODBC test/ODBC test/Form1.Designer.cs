namespace WindowsApplication1
{
    partial class Form1
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
            this.mysqltable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mysqltable)).BeginInit();
            this.SuspendLayout();
            // 
            // mysqltable
            // 
            this.mysqltable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.mysqltable.Location = new System.Drawing.Point(23, 28);
            this.mysqltable.Name = "mysqltable";
            this.mysqltable.ReadOnly = true;
            this.mysqltable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mysqltable.RowHeadersWidth = 38;
            this.mysqltable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mysqltable.Size = new System.Drawing.Size(372, 150);
            this.mysqltable.TabIndex = 0;
            this.mysqltable.Text = "dataGridView1";
            this.mysqltable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 266);
            this.Controls.Add(this.mysqltable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mysqltable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mysqltable;
    }
}

