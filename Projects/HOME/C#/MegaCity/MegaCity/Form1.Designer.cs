namespace MegaCity
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
            this.components = new System.ComponentModel.Container();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesDbDataSet = new MegaCity.citiesDbDataSet();
            this.citiesTableAdapter = new MegaCity.citiesDbDataSetTableAdapters.citiesTableAdapter();
            this.tableAdapterManager = new MegaCity.citiesDbDataSetTableAdapters.TableAdapterManager();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowMonetary = new System.Windows.Forms.Button();
            this.btnOrder2005 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "cities";
            this.citiesBindingSource.DataSource = this.citiesDbDataSet;
            // 
            // citiesDbDataSet
            // 
            this.citiesDbDataSet.DataSetName = "citiesDbDataSet";
            this.citiesDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.citiesTableAdapter = this.citiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = MegaCity.citiesDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.AutoGenerateColumns = false;
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.citiesDataGridView.DataSource = this.citiesBindingSource;
            this.citiesDataGridView.Location = new System.Drawing.Point(12, 130);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.Size = new System.Drawing.Size(784, 316);
            this.citiesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn2.HeaderText = "city";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "countryName";
            this.dataGridViewTextBoxColumn3.HeaderText = "countryName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pop2005";
            this.dataGridViewTextBoxColumn4.HeaderText = "pop2005";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pop2015";
            this.dataGridViewTextBoxColumn5.HeaderText = "pop2015";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "monetaryData";
            this.dataGridViewTextBoxColumn6.HeaderText = "monetaryData";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "monetaryUnit";
            this.dataGridViewTextBoxColumn7.HeaderText = "monetaryUnit";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnShowMonetary
            // 
            this.btnShowMonetary.Location = new System.Drawing.Point(481, 59);
            this.btnShowMonetary.Name = "btnShowMonetary";
            this.btnShowMonetary.Size = new System.Drawing.Size(265, 48);
            this.btnShowMonetary.TabIndex = 5;
            this.btnShowMonetary.Text = "Show Monetary Unit";
            this.btnShowMonetary.UseVisualStyleBackColor = true;
            // 
            // btnOrder2005
            // 
            this.btnOrder2005.Location = new System.Drawing.Point(51, 59);
            this.btnOrder2005.Name = "btnOrder2005";
            this.btnOrder2005.Size = new System.Drawing.Size(265, 48);
            this.btnOrder2005.TabIndex = 4;
            this.btnOrder2005.Text = "Order Population By 2005";
            this.btnOrder2005.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.btnShowMonetary);
            this.Controls.Add(this.btnOrder2005);
            this.Controls.Add(this.citiesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private citiesDbDataSet citiesDbDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private citiesDbDataSetTableAdapters.citiesTableAdapter citiesTableAdapter;
        private citiesDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView citiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnShowMonetary;
        private System.Windows.Forms.Button btnOrder2005;
    }
}

