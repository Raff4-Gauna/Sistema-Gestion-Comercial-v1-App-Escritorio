
namespace CapaPresentación.MdInventarios
{
    partial class frmActMasivaProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label24 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbosubcategoria = new System.Windows.Forms.ComboBox();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.cbomargenganancias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(250, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 31);
            this.label24.TabIndex = 177;
            this.label24.Text = "→";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(295, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 18);
            this.label12.TabIndex = 173;
            this.label12.Text = "Sub Categorias";
            // 
            // cbosubcategoria
            // 
            this.cbosubcategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbosubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosubcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosubcategoria.FormattingEnabled = true;
            this.cbosubcategoria.Location = new System.Drawing.Point(298, 38);
            this.cbosubcategoria.Name = "cbosubcategoria";
            this.cbosubcategoria.Size = new System.Drawing.Size(234, 24);
            this.cbosubcategoria.TabIndex = 174;
            // 
            // cbocategoria
            // 
            this.cbocategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(10, 38);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(234, 24);
            this.cbocategoria.TabIndex = 172;
            this.cbocategoria.SelectedIndexChanged += new System.EventHandler(this.cbocategoria_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 18);
            this.label11.TabIndex = 171;
            this.label11.Text = "Categorias";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 16;
            this.btnguardar.Location = new System.Drawing.Point(605, 464);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(165, 30);
            this.btnguardar.TabIndex = 176;
            this.btnguardar.Text = "Actualizar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Wheat;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 18;
            this.btnlimpiar.Location = new System.Drawing.Point(4, 464);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(165, 30);
            this.btnlimpiar.TabIndex = 178;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // cbomargenganancias
            // 
            this.cbomargenganancias.BackColor = System.Drawing.Color.White;
            this.cbomargenganancias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomargenganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomargenganancias.ForeColor = System.Drawing.Color.Black;
            this.cbomargenganancias.FormattingEnabled = true;
            this.cbomargenganancias.Location = new System.Drawing.Point(586, 34);
            this.cbomargenganancias.Name = "cbomargenganancias";
            this.cbomargenganancias.Size = new System.Drawing.Size(88, 28);
            this.cbomargenganancias.TabIndex = 232;
            this.cbomargenganancias.SelectedIndexChanged += new System.EventHandler(this.cbomargenganancias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(583, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 233;
            this.label1.Text = "Porcentaje de Aumento";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdCategoria,
            this.DescripcionCategoria,
            this.IdSubcategoria,
            this.DescripcionSubcategoria,
            this.DescripcionGeneral,
            this.IdTasaImpuesto,
            this.NumeroPorcentaje,
            this.PrecioFinal,
            this.FechaActualizacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.Location = new System.Drawing.Point(4, 86);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(878, 372);
            this.dgvdata.TabIndex = 234;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbocategoria);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbosubcategoria);
            this.groupBox1.Controls.Add(this.cbomargenganancias);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(-2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 81);
            this.groupBox1.TabIndex = 235;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(538, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 234;
            this.label2.Text = "→";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            this.IdCategoria.Width = 150;
            // 
            // DescripcionCategoria
            // 
            this.DescripcionCategoria.HeaderText = "Categoria";
            this.DescripcionCategoria.Name = "DescripcionCategoria";
            this.DescripcionCategoria.ReadOnly = true;
            // 
            // IdSubcategoria
            // 
            this.IdSubcategoria.HeaderText = "IdSubcategoria";
            this.IdSubcategoria.Name = "IdSubcategoria";
            this.IdSubcategoria.ReadOnly = true;
            this.IdSubcategoria.Visible = false;
            // 
            // DescripcionSubcategoria
            // 
            this.DescripcionSubcategoria.HeaderText = "Subcategoria";
            this.DescripcionSubcategoria.Name = "DescripcionSubcategoria";
            this.DescripcionSubcategoria.ReadOnly = true;
            // 
            // DescripcionGeneral
            // 
            this.DescripcionGeneral.HeaderText = "Nombre";
            this.DescripcionGeneral.Name = "DescripcionGeneral";
            this.DescripcionGeneral.ReadOnly = true;
            this.DescripcionGeneral.Width = 270;
            // 
            // IdTasaImpuesto
            // 
            this.IdTasaImpuesto.HeaderText = "IdTasaImpuesto";
            this.IdTasaImpuesto.Name = "IdTasaImpuesto";
            this.IdTasaImpuesto.ReadOnly = true;
            this.IdTasaImpuesto.Visible = false;
            // 
            // NumeroPorcentaje
            // 
            this.NumeroPorcentaje.HeaderText = "IVA";
            this.NumeroPorcentaje.Name = "NumeroPorcentaje";
            this.NumeroPorcentaje.ReadOnly = true;
            this.NumeroPorcentaje.Width = 60;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.HeaderText = "Precio Final";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            this.PrecioFinal.Width = 140;
            // 
            // FechaActualizacion
            // 
            this.FechaActualizacion.HeaderText = "Ult. Pre. Cambio";
            this.FechaActualizacion.Name = "FechaActualizacion";
            this.FechaActualizacion.ReadOnly = true;
            this.FechaActualizacion.Width = 150;
            // 
            // frmActMasivaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.MaximizeBox = false;
            this.Name = "frmActMasivaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Precios Masivamente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmActMasivaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbosubcategoria;
        public System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.ComboBox cbomargenganancias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaActualizacion;
    }
}