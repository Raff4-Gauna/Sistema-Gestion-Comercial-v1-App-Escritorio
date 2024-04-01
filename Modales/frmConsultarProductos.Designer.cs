
namespace CapaPresentación.Modales
{
    partial class frmConsultarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarProductos));
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picImgProducto = new System.Windows.Forms.PictureBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockConcatenado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblUltActPrecioVenta = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCopiCodBarra = new FontAwesome.Sharp.IconButton();
            this.lblCodBarra = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCodInterno = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblDescripcionProd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUltPrecioVenta = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStockExistente = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUltPrecioCompra = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiarbuscador.IconSize = 15;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(607, 7);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(42, 23);
            this.btnlimpiarbuscador.TabIndex = 231;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(206, 8);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(397, 22);
            this.txtbusqueda.TabIndex = 229;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.White;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(51, 9);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(149, 21);
            this.cbobusqueda.TabIndex = 228;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 227;
            this.label11.Text = "Buscar:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-3, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.label10.Size = new System.Drawing.Size(930, 36);
            this.label10.TabIndex = 226;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picImgProducto
            // 
            this.picImgProducto.Location = new System.Drawing.Point(5, 14);
            this.picImgProducto.Name = "picImgProducto";
            this.picImgProducto.Size = new System.Drawing.Size(118, 122);
            this.picImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgProducto.TabIndex = 232;
            this.picImgProducto.TabStop = false;
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodigoBarras,
            this.Codigo,
            this.DescripcionGeneral,
            this.IdTasaImpuesto,
            this.NumeroPorcentaje,
            this.IdProveedor,
            this.RazonSocial,
            this.PrecioFinal,
            this.PrecioCompra,
            this.IdTipoUnidad,
            this.TipoUnidad,
            this.stockConcatenado,
            this.Imagen,
            this.FechaActualizacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.Location = new System.Drawing.Point(0, 37);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
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
            this.dgvdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(445, 375);
            this.dgvdata.TabIndex = 230;
            this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
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
            this.CodigoBarras.HeaderText = "Cod. Barras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Cod. Interno";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // DescripcionGeneral
            // 
            this.DescripcionGeneral.HeaderText = "Descripción";
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
            this.NumeroPorcentaje.Visible = false;
            this.NumeroPorcentaje.Width = 60;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "RazonSocial";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Visible = false;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.HeaderText = "PrecioVenta";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            this.PrecioFinal.Visible = false;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Visible = false;
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
            this.stockConcatenado.Visible = false;
            this.stockConcatenado.Width = 80;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // FechaActualizacion
            // 
            this.FechaActualizacion.HeaderText = "FechaActualizacion";
            this.FechaActualizacion.Name = "FechaActualizacion";
            this.FechaActualizacion.ReadOnly = true;
            this.FechaActualizacion.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(451, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 377);
            this.tabControl1.TabIndex = 234;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.linkLabel2);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ficha del Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblUltActPrecioVenta);
            this.groupBox10.Location = new System.Drawing.Point(6, 149);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(167, 41);
            this.groupBox10.TabIndex = 236;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ult. Act. Precio Venta";
            // 
            // lblUltActPrecioVenta
            // 
            this.lblUltActPrecioVenta.AutoSize = true;
            this.lblUltActPrecioVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblUltActPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltActPrecioVenta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUltActPrecioVenta.Location = new System.Drawing.Point(6, 16);
            this.lblUltActPrecioVenta.Name = "lblUltActPrecioVenta";
            this.lblUltActPrecioVenta.Size = new System.Drawing.Size(14, 20);
            this.lblUltActPrecioVenta.TabIndex = 191;
            this.lblUltActPrecioVenta.Text = ".";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblProveedor);
            this.groupBox9.Location = new System.Drawing.Point(169, 49);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(145, 41);
            this.groupBox9.TabIndex = 237;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Proveedor";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblProveedor.Location = new System.Drawing.Point(6, 16);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(11, 15);
            this.lblProveedor.TabIndex = 191;
            this.lblProveedor.Text = ".";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblImpuestos);
            this.groupBox8.Location = new System.Drawing.Point(6, 49);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(141, 41);
            this.groupBox8.TabIndex = 236;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Impuestos";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblImpuestos.Location = new System.Drawing.Point(6, 16);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(11, 15);
            this.lblImpuestos.TabIndex = 191;
            this.lblImpuestos.Text = ".";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnCopiCodBarra);
            this.groupBox7.Controls.Add(this.lblCodBarra);
            this.groupBox7.Location = new System.Drawing.Point(6, 207);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(271, 41);
            this.groupBox7.TabIndex = 239;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cod. Barras";
            // 
            // btnCopiCodBarra
            // 
            this.btnCopiCodBarra.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCopiCodBarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiCodBarra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopiCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiCodBarra.ForeColor = System.Drawing.Color.Black;
            this.btnCopiCodBarra.IconChar = FontAwesome.Sharp.IconChar.LevelUp;
            this.btnCopiCodBarra.IconColor = System.Drawing.Color.Black;
            this.btnCopiCodBarra.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCopiCodBarra.IconSize = 17;
            this.btnCopiCodBarra.Location = new System.Drawing.Point(223, 10);
            this.btnCopiCodBarra.Name = "btnCopiCodBarra";
            this.btnCopiCodBarra.Size = new System.Drawing.Size(42, 28);
            this.btnCopiCodBarra.TabIndex = 237;
            this.btnCopiCodBarra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopiCodBarra.UseVisualStyleBackColor = false;
            this.btnCopiCodBarra.Click += new System.EventHandler(this.btnCopiCodBarra_Click);
            // 
            // lblCodBarra
            // 
            this.lblCodBarra.AutoSize = true;
            this.lblCodBarra.BackColor = System.Drawing.Color.Transparent;
            this.lblCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarra.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCodBarra.Location = new System.Drawing.Point(6, 18);
            this.lblCodBarra.Name = "lblCodBarra";
            this.lblCodBarra.Size = new System.Drawing.Size(12, 16);
            this.lblCodBarra.TabIndex = 193;
            this.lblCodBarra.Text = ".";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCodInterno);
            this.groupBox6.Location = new System.Drawing.Point(6, 254);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 41);
            this.groupBox6.TabIndex = 238;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cod. Interno";
            // 
            // lblCodInterno
            // 
            this.lblCodInterno.AutoSize = true;
            this.lblCodInterno.BackColor = System.Drawing.Color.Transparent;
            this.lblCodInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodInterno.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCodInterno.Location = new System.Drawing.Point(6, 18);
            this.lblCodInterno.Name = "lblCodInterno";
            this.lblCodInterno.Size = new System.Drawing.Size(12, 16);
            this.lblCodInterno.TabIndex = 193;
            this.lblCodInterno.Text = ".";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picImgProducto);
            this.groupBox2.Location = new System.Drawing.Point(308, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 141);
            this.groupBox2.TabIndex = 238;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDescripcionProd);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 41);
            this.groupBox5.TabIndex = 238;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Descripción";
            // 
            // lblDescripcionProd
            // 
            this.lblDescripcionProd.AutoSize = true;
            this.lblDescripcionProd.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProd.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDescripcionProd.Location = new System.Drawing.Point(5, 16);
            this.lblDescripcionProd.Name = "lblDescripcionProd";
            this.lblDescripcionProd.Size = new System.Drawing.Size(11, 15);
            this.lblDescripcionProd.TabIndex = 192;
            this.lblDescripcionProd.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUltPrecioVenta);
            this.groupBox1.Location = new System.Drawing.Point(6, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 41);
            this.groupBox1.TabIndex = 235;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ult. Precio Venta";
            // 
            // lblUltPrecioVenta
            // 
            this.lblUltPrecioVenta.AutoSize = true;
            this.lblUltPrecioVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblUltPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltPrecioVenta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUltPrecioVenta.Location = new System.Drawing.Point(6, 16);
            this.lblUltPrecioVenta.Name = "lblUltPrecioVenta";
            this.lblUltPrecioVenta.Size = new System.Drawing.Size(14, 20);
            this.lblUltPrecioVenta.TabIndex = 191;
            this.lblUltPrecioVenta.Text = ".";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStockExistente);
            this.groupBox4.Location = new System.Drawing.Point(300, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 41);
            this.groupBox4.TabIndex = 237;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock Existente";
            // 
            // lblStockExistente
            // 
            this.lblStockExistente.AutoSize = true;
            this.lblStockExistente.BackColor = System.Drawing.Color.Transparent;
            this.lblStockExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockExistente.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStockExistente.Location = new System.Drawing.Point(6, 18);
            this.lblStockExistente.Name = "lblStockExistente";
            this.lblStockExistente.Size = new System.Drawing.Size(14, 20);
            this.lblStockExistente.TabIndex = 193;
            this.lblStockExistente.Text = ".";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblUltPrecioCompra);
            this.groupBox3.Location = new System.Drawing.Point(153, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 41);
            this.groupBox3.TabIndex = 236;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ult. Precio Compra";
            // 
            // lblUltPrecioCompra
            // 
            this.lblUltPrecioCompra.AutoSize = true;
            this.lblUltPrecioCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblUltPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltPrecioCompra.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUltPrecioCompra.Location = new System.Drawing.Point(6, 16);
            this.lblUltPrecioCompra.Name = "lblUltPrecioCompra";
            this.lblUltPrecioCompra.Size = new System.Drawing.Size(14, 20);
            this.lblUltPrecioCompra.TabIndex = 192;
            this.lblUltPrecioCompra.Text = ".";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel2.Location = new System.Drawing.Point(-10, 83);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(577, 14);
            this.linkLabel2.TabIndex = 240;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(-4, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(577, 14);
            this.linkLabel1.TabIndex = 241;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sucursales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(657, 10);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 236;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(689, 10);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 235;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // frmConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 425);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha Productos / Artículos";
            this.Load += new System.EventHandler(this.frmConsultarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picImgProducto;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblDescripcionProd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblStockExistente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUltPrecioCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblCodBarra;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblCodInterno;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton btnCopiCodBarra;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblUltActPrecioVenta;
        private System.Windows.Forms.Label lblUltPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockConcatenado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaActualizacion;
    }
}