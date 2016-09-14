namespace DQ_Manager
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vDQBATCHLEVELRESULTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aF_TESTDataSet = new DQ_Manager.AF_TESTDataSet();
            this.v_DQ_BATCH_LEVEL_RESULTSTableAdapter = new DQ_Manager.AF_TESTDataSetTableAdapters.V_DQ_BATCH_LEVEL_RESULTSTableAdapter();
            this.batchcheckokDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.batchnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchlogidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.batchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.databaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDQBATCHLEVELRESULTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aF_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 266);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchcheckokDataGridViewCheckBoxColumn,
            this.batchnameDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.batchlogidDataGridViewTextBoxColumn,
            this.batchidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vDQBATCHLEVELRESULTSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(460, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // vDQBATCHLEVELRESULTSBindingSource
            // 
            this.vDQBATCHLEVELRESULTSBindingSource.DataMember = "V_DQ_BATCH_LEVEL_RESULTS";
            this.vDQBATCHLEVELRESULTSBindingSource.DataSource = this.aF_TESTDataSet;
            // 
            // aF_TESTDataSet
            // 
            this.aF_TESTDataSet.DataSetName = "AF_TESTDataSet";
            this.aF_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DQ_BATCH_LEVEL_RESULTSTableAdapter
            // 
            this.v_DQ_BATCH_LEVEL_RESULTSTableAdapter.ClearBeforeFill = true;
            // 
            // batchcheckokDataGridViewCheckBoxColumn
            // 
            this.batchcheckokDataGridViewCheckBoxColumn.DataPropertyName = "batch_check_ok";
            this.batchcheckokDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.batchcheckokDataGridViewCheckBoxColumn.Name = "batchcheckokDataGridViewCheckBoxColumn";
            this.batchcheckokDataGridViewCheckBoxColumn.ReadOnly = true;
            this.batchcheckokDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // batchnameDataGridViewTextBoxColumn
            // 
            this.batchnameDataGridViewTextBoxColumn.DataPropertyName = "batch_name";
            this.batchnameDataGridViewTextBoxColumn.HeaderText = "Batch Name";
            this.batchnameDataGridViewTextBoxColumn.Name = "batchnameDataGridViewTextBoxColumn";
            this.batchnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchlogidDataGridViewTextBoxColumn
            // 
            this.batchlogidDataGridViewTextBoxColumn.DataPropertyName = "batch_log_id";
            this.batchlogidDataGridViewTextBoxColumn.HeaderText = "batch_log_id";
            this.batchlogidDataGridViewTextBoxColumn.Name = "batchlogidDataGridViewTextBoxColumn";
            this.batchlogidDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchlogidDataGridViewTextBoxColumn.Visible = false;
            // 
            // batchidDataGridViewTextBoxColumn
            // 
            this.batchidDataGridViewTextBoxColumn.DataPropertyName = "batch_id";
            this.batchidDataGridViewTextBoxColumn.HeaderText = "batch_id";
            this.batchidDataGridViewTextBoxColumn.Name = "batchidDataGridViewTextBoxColumn";
            this.batchidDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchName});
            this.dataGridView2.Location = new System.Drawing.Point(8, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(198, 214);
            this.dataGridView2.TabIndex = 0;
            // 
            // batchName
            // 
            this.batchName.HeaderText = "Batch Name";
            this.batchName.Name = "batchName";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.databaseName,
            this.tableName,
            this.fieldName});
            this.dataGridView3.Location = new System.Drawing.Point(213, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(421, 150);
            this.dataGridView3.TabIndex = 1;
            // 
            // databaseName
            // 
            this.databaseName.HeaderText = "Database";
            this.databaseName.Name = "databaseName";
            // 
            // tableName
            // 
            this.tableName.HeaderText = "Table";
            this.tableName.Name = "tableName";
            // 
            // fieldName
            // 
            this.fieldName.HeaderText = "Field";
            this.fieldName.Name = "fieldName";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 266);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "DQ Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDQBATCHLEVELRESULTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aF_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AF_TESTDataSet aF_TESTDataSet;
        private System.Windows.Forms.BindingSource vDQBATCHLEVELRESULTSBindingSource;
        private DQ_Manager.AF_TESTDataSetTableAdapters.V_DQ_BATCH_LEVEL_RESULTSTableAdapter v_DQ_BATCH_LEVEL_RESULTSTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn batchcheckokDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchlogidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchName;

    }
}

