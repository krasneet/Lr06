namespace _06
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kvartirsDataSet = new _06.KvartirsDataSet();
            this.kvartirsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kvartirs1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kvartirs1TableAdapter = new _06.KvartirsDataSetTableAdapters.Kvartirs1TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vladelecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozrastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartirsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartirsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartirs1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vladelecDataGridViewTextBoxColumn,
            this.размерDataGridViewTextBoxColumn,
            this.vozrastDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kvartirs1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(223, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kvartirsDataSet
            // 
            this.kvartirsDataSet.DataSetName = "KvartirsDataSet";
            this.kvartirsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvartirsDataSetBindingSource
            // 
            this.kvartirsDataSetBindingSource.DataSource = this.kvartirsDataSet;
            this.kvartirsDataSetBindingSource.Position = 0;
            // 
            // kvartirs1BindingSource
            // 
            this.kvartirs1BindingSource.DataMember = "Kvartirs1";
            this.kvartirs1BindingSource.DataSource = this.kvartirsDataSet;
            // 
            // kvartirs1TableAdapter
            // 
            this.kvartirs1TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // vladelecDataGridViewTextBoxColumn
            // 
            this.vladelecDataGridViewTextBoxColumn.DataPropertyName = "Vladelec";
            this.vladelecDataGridViewTextBoxColumn.HeaderText = "Vladelec";
            this.vladelecDataGridViewTextBoxColumn.Name = "vladelecDataGridViewTextBoxColumn";
            // 
            // размерDataGridViewTextBoxColumn
            // 
            this.размерDataGridViewTextBoxColumn.DataPropertyName = "Размер";
            this.размерDataGridViewTextBoxColumn.HeaderText = "Размер";
            this.размерDataGridViewTextBoxColumn.Name = "размерDataGridViewTextBoxColumn";
            // 
            // vozrastDataGridViewTextBoxColumn
            // 
            this.vozrastDataGridViewTextBoxColumn.DataPropertyName = "Vozrast";
            this.vozrastDataGridViewTextBoxColumn.HeaderText = "Vozrast";
            this.vozrastDataGridViewTextBoxColumn.Name = "vozrastDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartirsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartirsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartirs1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kvartirsDataSetBindingSource;
        private KvartirsDataSet kvartirsDataSet;
        private System.Windows.Forms.BindingSource kvartirs1BindingSource;
        private KvartirsDataSetTableAdapters.Kvartirs1TableAdapter kvartirs1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vladelecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozrastDataGridViewTextBoxColumn;
    }
}

