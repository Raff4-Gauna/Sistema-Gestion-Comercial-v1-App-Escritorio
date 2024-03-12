
namespace CapaPresentación.MdVentas.Modal
{
    partial class frmListarProductos
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockConcatenado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.picImgProducto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodigoBarras,
            this.DescripcionGeneral,
            this.DescripcionCategoria,
            this.IdTipoUnidad,
            this.TipoUnidad,
            this.stockConcatenado,
            this.PrecioCompra,
            this.NumeroPorcentaje,
            this.PrecioFinal,
            this.Imagen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.Location = new System.Drawing.Point(0, 55);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(777, 364);
            this.dgvdata.TabIndex = 82;
            this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
            this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
            this.dgvdata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvdata_KeyDown);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.HeaderText = "Codigo";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            // 
            // DescripcionGeneral
            // 
            this.DescripcionGeneral.HeaderText = "Nombre";
            this.DescripcionGeneral.Name = "DescripcionGeneral";
            this.DescripcionGeneral.ReadOnly = true;
            this.DescripcionGeneral.Width = 270;
            // 
            // DescripcionCategoria
            // 
            this.DescripcionCategoria.HeaderText = "Categoria";
            this.DescripcionCategoria.Name = "DescripcionCategoria";
            this.DescripcionCategoria.ReadOnly = true;
            this.DescripcionCategoria.Visible = false;
            this.DescripcionCategoria.Width = 180;
            // 
            // IdTipoUnidad
            // 
            this.IdTipoUnidad.HeaderText = "IdTipoUnidad";
            this.IdTipoUnidad.Name = "IdTipoUnidad";
            this.IdTipoUnidad.ReadOnly = true;
            this.IdTipoUnidad.Visible = false;
            // 
            // TipoUnidad
            // 
            this.TipoUnidad.HeaderText = "TipoUnidad";
            this.TipoUnidad.Name = "TipoUnidad";
            this.TipoUnidad.ReadOnly = true;
            this.TipoUnidad.Visible = false;
            // 
            // stockConcatenado
            // 
            this.stockConcatenado.HeaderText = "Stock";
            this.stockConcatenado.Name = "stockConcatenado";
            this.stockConcatenado.ReadOnly = true;
            this.stockConcatenado.Width = 80;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Pre.Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
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
            this.PrecioFinal.HeaderText = "PVP";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(222, 13);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(397, 29);
            this.txtbusqueda.TabIndex = 80;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.White;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(67, 13);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(149, 28);
            this.cbobusqueda.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 78;
            this.label11.Text = "Buscar:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.label10.Size = new System.Drawing.Size(930, 52);
            this.label10.TabIndex = 77;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiarbuscador.IconSize = 20;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(625, 14);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(42, 29);
            this.btnlimpiarbuscador.TabIndex = 90;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // picImgProducto
            // 
            this.picImgProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImgProducto.Location = new System.Drawing.Point(779, 83);
            this.picImgProducto.Name = "picImgProducto";
            this.picImgProducto.Size = new System.Drawing.Size(118, 122);
            this.picImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgProducto.TabIndex = 224;
            this.picImgProducto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 225;
            this.label1.Text = "Imagen";
            // 
            // frmListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picImgProducto);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarProductos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Productos";
            this.Load += new System.EventHandler(this.frmListarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picImgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockConcatenado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.Label label1;
    }
}