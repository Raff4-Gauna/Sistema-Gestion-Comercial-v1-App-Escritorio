
namespace CapaPresentación.MdInventarios
{
    partial class frmGestionProductos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalProductosNoActivas = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnExportaExel = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.treeViewDatos = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picImgProducto = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblDescripcionProd = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStockExistente = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUltPrecioCompra = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUltPrecioVenta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImportarExel = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSubcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMargenGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UbicacionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockConcatenado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.txtindice);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTotalProductosNoActivas);
            this.groupBox2.Controls.Add(this.cbobusqueda);
            this.groupBox2.Controls.Add(this.txtbusqueda);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblTotalProductos);
            this.groupBox2.Controls.Add(this.btnlimpiarbuscador);
            this.groupBox2.Location = new System.Drawing.Point(217, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 42);
            this.groupBox2.TabIndex = 166;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(26, 18);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 190;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(58, 18);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 189;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 138;
            this.label3.Text = "Prod. No Activos:";
            // 
            // lblTotalProductosNoActivas
            // 
            this.lblTotalProductosNoActivas.AutoSize = true;
            this.lblTotalProductosNoActivas.BackColor = System.Drawing.Color.Red;
            this.lblTotalProductosNoActivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductosNoActivas.Location = new System.Drawing.Point(711, 13);
            this.lblTotalProductosNoActivas.Name = "lblTotalProductosNoActivas";
            this.lblTotalProductosNoActivas.Size = new System.Drawing.Size(14, 20);
            this.lblTotalProductosNoActivas.TabIndex = 137;
            this.lblTotalProductosNoActivas.Text = ".";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(16, 14);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(142, 24);
            this.cbobusqueda.TabIndex = 102;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(164, 13);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(269, 22);
            this.txtbusqueda.TabIndex = 105;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(521, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 136;
            this.label9.Text = "Total Prod:";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductos.Location = new System.Drawing.Point(586, 15);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(12, 16);
            this.lblTotalProductos.TabIndex = 135;
            this.lblTotalProductos.Text = ".";
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.LightSalmon;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 20;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(439, 13);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(42, 23);
            this.btnlimpiarbuscador.TabIndex = 104;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnExportaExel
            // 
            this.btnExportaExel.BackColor = System.Drawing.Color.LightGray;
            this.btnExportaExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportaExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportaExel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportaExel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportaExel.IconColor = System.Drawing.Color.LimeGreen;
            this.btnExportaExel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExportaExel.IconSize = 17;
            this.btnExportaExel.Location = new System.Drawing.Point(6, 6);
            this.btnExportaExel.Name = "btnExportaExel";
            this.btnExportaExel.Size = new System.Drawing.Size(136, 30);
            this.btnExportaExel.TabIndex = 169;
            this.btnExportaExel.Text = "Exportar Exel";
            this.btnExportaExel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportaExel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportaExel.UseVisualStyleBackColor = false;
            this.btnExportaExel.Click += new System.EventHandler(this.btnExportaExel_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.IconSize = 17;
            this.btnAgregarProducto.Location = new System.Drawing.Point(2, 6);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(116, 30);
            this.btnAgregarProducto.TabIndex = 167;
            this.btnAgregarProducto.Text = "Nuevo Prod.";
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // treeViewDatos
            // 
            this.treeViewDatos.BackColor = System.Drawing.Color.White;
            this.treeViewDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewDatos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.treeViewDatos.Location = new System.Drawing.Point(12, 12);
            this.treeViewDatos.Name = "treeViewDatos";
            this.treeViewDatos.Size = new System.Drawing.Size(199, 268);
            this.treeViewDatos.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 286);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 149);
            this.tabControl1.TabIndex = 170;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.picImgProducto);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.btnAgregarProducto);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(938, 123);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picImgProducto
            // 
            this.picImgProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImgProducto.Location = new System.Drawing.Point(815, 6);
            this.picImgProducto.Name = "picImgProducto";
            this.picImgProducto.Size = new System.Drawing.Size(115, 109);
            this.picImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgProducto.TabIndex = 222;
            this.picImgProducto.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDescripcionProd);
            this.groupBox5.Location = new System.Drawing.Point(162, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(575, 41);
            this.groupBox5.TabIndex = 192;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Producto";
            // 
            // lblDescripcionProd
            // 
            this.lblDescripcionProd.AutoSize = true;
            this.lblDescripcionProd.BackColor = System.Drawing.Color.Black;
            this.lblDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDescripcionProd.Location = new System.Drawing.Point(5, 16);
            this.lblDescripcionProd.Name = "lblDescripcionProd";
            this.lblDescripcionProd.Size = new System.Drawing.Size(12, 16);
            this.lblDescripcionProd.TabIndex = 192;
            this.lblDescripcionProd.Text = ".";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStockExistente);
            this.groupBox4.Location = new System.Drawing.Point(335, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 41);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock Existente";
            // 
            // lblStockExistente
            // 
            this.lblStockExistente.AutoSize = true;
            this.lblStockExistente.BackColor = System.Drawing.Color.Black;
            this.lblStockExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockExistente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStockExistente.Location = new System.Drawing.Point(6, 18);
            this.lblStockExistente.Name = "lblStockExistente";
            this.lblStockExistente.Size = new System.Drawing.Size(14, 20);
            this.lblStockExistente.TabIndex = 193;
            this.lblStockExistente.Text = ".";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblUltPrecioCompra);
            this.groupBox3.Location = new System.Drawing.Point(508, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 41);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ult. Precio Compra";
            // 
            // lblUltPrecioCompra
            // 
            this.lblUltPrecioCompra.AutoSize = true;
            this.lblUltPrecioCompra.BackColor = System.Drawing.Color.Black;
            this.lblUltPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUltPrecioCompra.Location = new System.Drawing.Point(6, 16);
            this.lblUltPrecioCompra.Name = "lblUltPrecioCompra";
            this.lblUltPrecioCompra.Size = new System.Drawing.Size(14, 20);
            this.lblUltPrecioCompra.TabIndex = 192;
            this.lblUltPrecioCompra.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUltPrecioVenta);
            this.groupBox1.Location = new System.Drawing.Point(162, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ult. Precio Venta";
            // 
            // lblUltPrecioVenta
            // 
            this.lblUltPrecioVenta.AutoSize = true;
            this.lblUltPrecioVenta.BackColor = System.Drawing.Color.Black;
            this.lblUltPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUltPrecioVenta.Location = new System.Drawing.Point(6, 16);
            this.lblUltPrecioVenta.Name = "lblUltPrecioVenta";
            this.lblUltPrecioVenta.Size = new System.Drawing.Size(14, 20);
            this.lblUltPrecioVenta.TabIndex = 191;
            this.lblUltPrecioVenta.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CapaPresentación.Properties.Resources.vertical_line;
            this.pictureBox1.Location = new System.Drawing.Point(115, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 221;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnExportaExel);
            this.tabPage2.Controls.Add(this.btnImportarExel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(938, 123);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImportarExel
            // 
            this.btnImportarExel.BackColor = System.Drawing.Color.White;
            this.btnImportarExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarExel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarExel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnImportarExel.IconColor = System.Drawing.Color.LimeGreen;
            this.btnImportarExel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnImportarExel.IconSize = 17;
            this.btnImportarExel.Location = new System.Drawing.Point(148, 6);
            this.btnImportarExel.Name = "btnImportarExel";
            this.btnImportarExel.Size = new System.Drawing.Size(136, 30);
            this.btnImportarExel.TabIndex = 170;
            this.btnImportarExel.Text = "Importar Exel";
            this.btnImportarExel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportarExel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportarExel.UseVisualStyleBackColor = false;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.IdCategoria,
            this.DescripcionCategoria,
            this.IdSubcategoria,
            this.DescripcionSubcategoria,
            this.IdTasaImpuesto,
            this.NumeroPorcentaje,
            this.IdTipoUnidad,
            this.TipoUnidad,
            this.IdProveedor,
            this.NombreProveedor,
            this.Imagen,
            this.CodigoBarras,
            this.Codigo,
            this.DescripcionGeneral,
            this.PrecioCompra,
            this.IdMargenGanancia,
            this.DescripcionPorcentaje,
            this.PrecioFinal,
            this.UbicacionProducto,
            this.stockConcatenado,
            this.StockMinimo,
            this.EstadoValor,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.Location = new System.Drawing.Point(217, 57);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(741, 223);
            this.dgvdata.TabIndex = 171;
            this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Visible = false;
            this.btnseleccionar.Width = 30;
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
            this.IdCategoria.Width = 20;
            // 
            // DescripcionCategoria
            // 
            this.DescripcionCategoria.HeaderText = "Categoria";
            this.DescripcionCategoria.Name = "DescripcionCategoria";
            this.DescripcionCategoria.ReadOnly = true;
            this.DescripcionCategoria.Width = 120;
            // 
            // IdSubcategoria
            // 
            this.IdSubcategoria.HeaderText = "IdSubcategoria";
            this.IdSubcategoria.Name = "IdSubcategoria";
            this.IdSubcategoria.ReadOnly = true;
            this.IdSubcategoria.Visible = false;
            this.IdSubcategoria.Width = 180;
            // 
            // DescripcionSubcategoria
            // 
            this.DescripcionSubcategoria.HeaderText = "Subcategoria";
            this.DescripcionSubcategoria.Name = "DescripcionSubcategoria";
            this.DescripcionSubcategoria.ReadOnly = true;
            this.DescripcionSubcategoria.Width = 130;
            // 
            // IdTasaImpuesto
            // 
            this.IdTasaImpuesto.HeaderText = "IdTasaImpuesto";
            this.IdTasaImpuesto.Name = "IdTasaImpuesto";
            this.IdTasaImpuesto.ReadOnly = true;
            this.IdTasaImpuesto.Visible = false;
            this.IdTasaImpuesto.Width = 160;
            // 
            // NumeroPorcentaje
            // 
            this.NumeroPorcentaje.HeaderText = "IVA";
            this.NumeroPorcentaje.Name = "NumeroPorcentaje";
            this.NumeroPorcentaje.ReadOnly = true;
            this.NumeroPorcentaje.Width = 50;
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
            this.TipoUnidad.HeaderText = "Unidad";
            this.TipoUnidad.Name = "TipoUnidad";
            this.TipoUnidad.ReadOnly = true;
            this.TipoUnidad.Visible = false;
            this.TipoUnidad.Width = 80;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            this.IdProveedor.Width = 140;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.HeaderText = "Razon Social";
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            this.NombreProveedor.Visible = false;
            this.NombreProveedor.Width = 110;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.HeaderText = "CodigoBarras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            this.CodigoBarras.Width = 120;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // DescripcionGeneral
            // 
            this.DescripcionGeneral.HeaderText = "DescripcionGeneral";
            this.DescripcionGeneral.Name = "DescripcionGeneral";
            this.DescripcionGeneral.ReadOnly = true;
            this.DescripcionGeneral.Width = 130;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // IdMargenGanancia
            // 
            this.IdMargenGanancia.HeaderText = "IdMargenGanancia";
            this.IdMargenGanancia.Name = "IdMargenGanancia";
            this.IdMargenGanancia.ReadOnly = true;
            this.IdMargenGanancia.Visible = false;
            // 
            // DescripcionPorcentaje
            // 
            this.DescripcionPorcentaje.HeaderText = "Por. Ganancia";
            this.DescripcionPorcentaje.Name = "DescripcionPorcentaje";
            this.DescripcionPorcentaje.ReadOnly = true;
            this.DescripcionPorcentaje.Visible = false;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.HeaderText = "PrecioFinal";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            // 
            // UbicacionProducto
            // 
            this.UbicacionProducto.HeaderText = "UbicacionProducto";
            this.UbicacionProducto.Name = "UbicacionProducto";
            this.UbicacionProducto.ReadOnly = true;
            this.UbicacionProducto.Visible = false;
            // 
            // stockConcatenado
            // 
            this.stockConcatenado.HeaderText = "StockExistente";
            this.stockConcatenado.Name = "stockConcatenado";
            this.stockConcatenado.ReadOnly = true;
            // 
            // StockMinimo
            // 
            this.StockMinimo.HeaderText = "StockMinimo";
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 435);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.treeViewDatos);
            this.MaximizeBox = false;
            this.Name = "frmGestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.frmGestionProductos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalProductosNoActivas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private System.Windows.Forms.TreeView treeViewDatos;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton btnExportaExel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconButton btnImportarExel;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblStockExistente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUltPrecioCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUltPrecioVenta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblDescripcionProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picImgProducto;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSubcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMargenGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UbicacionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockConcatenado;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}