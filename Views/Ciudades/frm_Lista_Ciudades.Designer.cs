﻿
namespace _06Publicaciones.Views.Ciudades
{
    partial class frm_Lista_Ciudades
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubsDataSet = new _06Publicaciones.pubsDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadesTableAdapter = new _06Publicaciones.pubsDataSetTableAdapters.CiudadesTableAdapter();
            this.paisesTableAdapter = new _06Publicaciones.pubsDataSetTableAdapters.PaisesTableAdapter();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.pubsDataSet1 = new _06Publicaciones.pubsDataSet1();
            this.paisesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paisesTableAdapter1 = new _06Publicaciones.pubsDataSet1TableAdapters.PaisesTableAdapter();
            this.idPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Editar,
            this.idPaisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paisesBindingSource2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(609, 296);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdPais";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 120;
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "IdPais";
            this.Editar.HeaderText = "Acciones";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 99;
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "Paises";
            this.paisesBindingSource.DataSource = this.pubsDataSet;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Ciudades";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nueva Ciudad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar Ciudad";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            this.ciudadesBindingSource.DataSource = this.pubsDataSet;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Location = new System.Drawing.Point(19, 45);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.RowHeadersWidth = 51;
            this.dgvCiudades.RowTemplate.Height = 24;
            this.dgvCiudades.Size = new System.Drawing.Size(495, 388);
            this.dgvCiudades.TabIndex = 4;
            this.dgvCiudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudades_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Actualizar Ciudad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pubsDataSet1
            // 
            this.pubsDataSet1.DataSetName = "pubsDataSet1";
            this.pubsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisesBindingSource1
            // 
            this.paisesBindingSource1.DataMember = "Paises";
            this.paisesBindingSource1.DataSource = this.pubsDataSet1;
            // 
            // paisesTableAdapter1
            // 
            this.paisesTableAdapter1.ClearBeforeFill = true;
            // 
            // idPaisDataGridViewTextBoxColumn
            // 
            this.idPaisDataGridViewTextBoxColumn.DataPropertyName = "IdPais";
            this.idPaisDataGridViewTextBoxColumn.HeaderText = "IdPais";
            this.idPaisDataGridViewTextBoxColumn.Name = "idPaisDataGridViewTextBoxColumn";
            this.idPaisDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPaisDataGridViewTextBoxColumn.Width = 78;
            // 
            // paisesBindingSource2
            // 
            this.paisesBindingSource2.DataMember = "Paises";
            this.paisesBindingSource2.DataSource = this.pubsDataSet1;
            // 
            // frm_Lista_Ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 637);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvCiudades);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Lista_Ciudades";
            this.Text = "frm_Lista_Ciudades";
            this.Load += new System.EventHandler(this.frm_Lista_Ciudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private pubsDataSetTableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private pubsDataSetTableAdapters.PaisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridView dgvCiudades;
        private System.Windows.Forms.Button button3;
        private pubsDataSet1 pubsDataSet1;
        private System.Windows.Forms.BindingSource paisesBindingSource1;
        private pubsDataSet1TableAdapters.PaisesTableAdapter paisesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paisesBindingSource2;
    }
}