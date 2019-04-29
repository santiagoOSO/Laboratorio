namespace Sucursales
{
    partial class FSucursales
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSucursales));
            this.gbxSucursal = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ltbCiudad = new System.Windows.Forms.ListBox();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSucursal
            // 
            this.gbxSucursal.Controls.Add(this.btnSalir);
            this.gbxSucursal.Controls.Add(this.btnLimpiar);
            this.gbxSucursal.Controls.Add(this.ltbCiudad);
            this.gbxSucursal.Controls.Add(this.dgvSucursal);
            this.gbxSucursal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSucursal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxSucursal.Location = new System.Drawing.Point(25, 27);
            this.gbxSucursal.Name = "gbxSucursal";
            this.gbxSucursal.Size = new System.Drawing.Size(1332, 496);
            this.gbxSucursal.TabIndex = 0;
            this.gbxSucursal.TabStop = false;
            this.gbxSucursal.Text = "Seleccionar Ciudad";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(286, 59);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 34);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(286, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 34);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // ltbCiudad
            // 
            this.ltbCiudad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ltbCiudad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbCiudad.FormattingEnabled = true;
            this.ltbCiudad.ItemHeight = 20;
            this.ltbCiudad.Location = new System.Drawing.Point(21, 25);
            this.ltbCiudad.Name = "ltbCiudad";
            this.ltbCiudad.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ltbCiudad.Size = new System.Drawing.Size(237, 64);
            this.ltbCiudad.TabIndex = 10;
            this.ltbCiudad.SelectedIndexChanged += new System.EventHandler(this.ltbCiudad_SelectedIndexChanged_1);
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.AllowUserToAddRows = false;
            this.dgvSucursal.AllowUserToDeleteRows = false;
            this.dgvSucursal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSucursal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSucursal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSucursal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvSucursal.EnableHeadersVisualStyles = false;
            this.dgvSucursal.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvSucursal.Location = new System.Drawing.Point(21, 104);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.ReadOnly = true;
            this.dgvSucursal.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSucursal.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSucursal.Size = new System.Drawing.Size(1290, 377);
            this.dgvSucursal.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ciudad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 86;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Direccion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 103;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 99;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Correo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 84;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Horario Entrega Semana";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 198;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Horario Entrega Fin Semana";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 167;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Horario Toma Semana";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 184;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Horario Toma Fin Semana";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 153;
            // 
            // FSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1385, 543);
            this.Controls.Add(this.gbxSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.Sucursales_Load);
            this.gbxSucursal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSucursal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox ltbCiudad;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;

    }
}

