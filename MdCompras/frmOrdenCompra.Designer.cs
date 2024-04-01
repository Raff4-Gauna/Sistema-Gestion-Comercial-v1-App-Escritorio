
namespace CapaPresentación.MdCompras
{
    partial class frmOrdenCompra
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.btnlimpiarcampos = new FontAwesome.Sharp.IconButton();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.btncrearcompra = new FontAwesome.Sharp.IconButton();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtultpreciocompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgreProd = new FontAwesome.Sharp.IconButton();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtdocumentocliente = new System.Windows.Forms.TextBox();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.txtcodbarraproducto = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            this.txtCodproducto = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtultprecioventa = new System.Windows.Forms.TextBox();
            this.btnbuscarmetodospagos = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmetodopago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.lblusuario = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnAgregarData = new FontAwesome.Sharp.IconButton();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txttotalpagar);
            this.tabPage2.Controls.Add(this.txtprecioventa);
            this.tabPage2.Controls.Add(this.btnlimpiarcampos);
            this.tabPage2.Controls.Add(this.txtpreciocompra);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.btnagregarproducto);
            this.tabPage2.Controls.Add(this.txtcantidad);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(148, 302);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Intercambio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 218;
            this.label5.Text = "Monto Total";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalpagar.Enabled = false;
            this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.ForeColor = System.Drawing.Color.DarkBlue;
            this.txttotalpagar.Location = new System.Drawing.Point(3, 197);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(137, 29);
            this.txttotalpagar.TabIndex = 77;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecioventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioventa.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtprecioventa.Location = new System.Drawing.Point(3, 138);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(137, 29);
            this.txtprecioventa.TabIndex = 6;
            this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioventa_KeyPress);
            // 
            // btnlimpiarcampos
            // 
            this.btnlimpiarcampos.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiarcampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarcampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarcampos.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarcampos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarcampos.IconColor = System.Drawing.Color.CadetBlue;
            this.btnlimpiarcampos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiarcampos.IconSize = 20;
            this.btnlimpiarcampos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpiarcampos.Location = new System.Drawing.Point(80, 242);
            this.btnlimpiarcampos.Name = "btnlimpiarcampos";
            this.btnlimpiarcampos.Size = new System.Drawing.Size(60, 52);
            this.btnlimpiarcampos.TabIndex = 8;
            this.btnlimpiarcampos.Text = "Limpiar (F2)";
            this.btnlimpiarcampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlimpiarcampos.UseVisualStyleBackColor = false;
            this.btnlimpiarcampos.Click += new System.EventHandler(this.btnlimpiarcampos_Click);
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpreciocompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciocompra.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtpreciocompra.Location = new System.Drawing.Point(3, 83);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(137, 29);
            this.txtpreciocompra.TabIndex = 5;
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(3, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 210;
            this.label13.Text = "P. Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 211;
            this.label1.Text = "P. Compra";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label16.Location = new System.Drawing.Point(2, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 20);
            this.label16.TabIndex = 209;
            this.label16.Text = "Un. / Kg.";
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.Black;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnagregarproducto.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnagregarproducto.IconSize = 20;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregarproducto.Location = new System.Drawing.Point(1, 242);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(61, 52);
            this.btnagregarproducto.TabIndex = 7;
            this.btnagregarproducto.Text = "Agregar (F1)";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproducto.UseVisualStyleBackColor = false;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.DecimalPlaces = 2;
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.Black;
            this.txtcantidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtcantidad.Location = new System.Drawing.Point(2, 26);
            this.txtcantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(138, 31);
            this.txtcantidad.TabIndex = 4;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btncrearcompra
            // 
            this.btncrearcompra.BackColor = System.Drawing.Color.Transparent;
            this.btncrearcompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrearcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearcompra.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btncrearcompra.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btncrearcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearcompra.IconSize = 20;
            this.btncrearcompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncrearcompra.Location = new System.Drawing.Point(684, 245);
            this.btncrearcompra.Name = "btncrearcompra";
            this.btncrearcompra.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btncrearcompra.Size = new System.Drawing.Size(85, 46);
            this.btncrearcompra.TabIndex = 215;
            this.btncrearcompra.Text = "Grabar (F5)";
            this.btncrearcompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncrearcompra.UseVisualStyleBackColor = false;
            this.btncrearcompra.Click += new System.EventHandler(this.btncrearcompra_Click);
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDescripcionProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripcionProd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProd.Location = new System.Drawing.Point(342, 31);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(302, 20);
            this.txtDescripcionProd.TabIndex = 3;
            this.txtDescripcionProd.TextChanged += new System.EventHandler(this.txtDescripcionProd_TextChanged);
            this.txtDescripcionProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcionProd_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtultpreciocompra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAgreProd);
            this.groupBox1.Controls.Add(this.txtdocproveedor);
            this.groupBox1.Controls.Add(this.txtidproveedor);
            this.groupBox1.Controls.Add(this.txtDescripcionProd);
            this.groupBox1.Controls.Add(this.txtidproducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtdocumentocliente);
            this.groupBox1.Controls.Add(this.txtnombreproveedor);
            this.groupBox1.Controls.Add(this.txtcodbarraproducto);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.btnbuscarproveedor);
            this.groupBox1.Controls.Add(this.txtCodproducto);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtultprecioventa);
            this.groupBox1.Controls.Add(this.btnbuscarmetodospagos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmetodopago);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 131);
            this.groupBox1.TabIndex = 226;
            this.groupBox1.TabStop = false;
            // 
            // txtultpreciocompra
            // 
            this.txtultpreciocompra.BackColor = System.Drawing.Color.White;
            this.txtultpreciocompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtultpreciocompra.Enabled = false;
            this.txtultpreciocompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtultpreciocompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtultpreciocompra.Location = new System.Drawing.Point(213, 97);
            this.txtultpreciocompra.Name = "txtultpreciocompra";
            this.txtultpreciocompra.Size = new System.Drawing.Size(98, 17);
            this.txtultpreciocompra.TabIndex = 228;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(211, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 227;
            this.label3.Text = "Ult. P. Compra";
            // 
            // btnAgreProd
            // 
            this.btnAgreProd.BackColor = System.Drawing.Color.Transparent;
            this.btnAgreProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgreProd.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            this.btnAgreProd.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAgreProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgreProd.IconSize = 17;
            this.btnAgreProd.Location = new System.Drawing.Point(504, 54);
            this.btnAgreProd.Name = "btnAgreProd";
            this.btnAgreProd.Size = new System.Drawing.Size(140, 29);
            this.btnAgreProd.TabIndex = 226;
            this.btnAgreProd.Text = "Nuevo Prod. (F9)";
            this.btnAgreProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgreProd.UseVisualStyleBackColor = false;
            this.btnAgreProd.Click += new System.EventHandler(this.btnAgreProd_Click);
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtdocproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocproveedor.Location = new System.Drawing.Point(702, 79);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.ReadOnly = true;
            this.txtdocproveedor.Size = new System.Drawing.Size(27, 18);
            this.txtdocproveedor.TabIndex = 225;
            this.txtdocproveedor.Visible = false;
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtidproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproveedor.Location = new System.Drawing.Point(735, 78);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(34, 18);
            this.txtidproveedor.TabIndex = 224;
            this.txtidproveedor.Visible = false;
            // 
            // txtidproducto
            // 
            this.txtidproducto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtidproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproducto.Location = new System.Drawing.Point(702, 58);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(27, 18);
            this.txtidproducto.TabIndex = 0;
            this.txtidproducto.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(333, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 223;
            this.label2.Text = "Descripción";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(783, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 83;
            this.label15.Text = "Proveedor";
            // 
            // txtdocumentocliente
            // 
            this.txtdocumentocliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtdocumentocliente.Enabled = false;
            this.txtdocumentocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumentocliente.Location = new System.Drawing.Point(735, 57);
            this.txtdocumentocliente.Name = "txtdocumentocliente";
            this.txtdocumentocliente.Size = new System.Drawing.Size(34, 18);
            this.txtdocumentocliente.TabIndex = 85;
            this.txtdocumentocliente.Visible = false;
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Enabled = false;
            this.txtnombreproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreproveedor.Location = new System.Drawing.Point(787, 30);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.Size = new System.Drawing.Size(134, 21);
            this.txtnombreproveedor.TabIndex = 86;
            // 
            // txtcodbarraproducto
            // 
            this.txtcodbarraproducto.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtcodbarraproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodbarraproducto.Location = new System.Drawing.Point(8, 31);
            this.txtcodbarraproducto.Name = "txtcodbarraproducto";
            this.txtcodbarraproducto.Size = new System.Drawing.Size(194, 20);
            this.txtcodbarraproducto.TabIndex = 1;
            this.txtcodbarraproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodbarraproducto_KeyDown);
            this.txtcodbarraproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodbarraproducto_KeyPress);
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(787, 106);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(119, 21);
            this.txtfecha.TabIndex = 90;
            // 
            // btnbuscarproveedor
            // 
            this.btnbuscarproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproveedor.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarproveedor.IconSize = 20;
            this.btnbuscarproveedor.Location = new System.Drawing.Point(925, 23);
            this.btnbuscarproveedor.Name = "btnbuscarproveedor";
            this.btnbuscarproveedor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarproveedor.Size = new System.Drawing.Size(37, 31);
            this.btnbuscarproveedor.TabIndex = 87;
            this.btnbuscarproveedor.UseVisualStyleBackColor = true;
            this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscarproveedor_Click);
            // 
            // txtCodproducto
            // 
            this.txtCodproducto.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtCodproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodproducto.Location = new System.Drawing.Point(208, 29);
            this.txtCodproducto.Name = "txtCodproducto";
            this.txtCodproducto.Size = new System.Drawing.Size(122, 22);
            this.txtCodproducto.TabIndex = 2;
            this.txtCodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodproducto_KeyDown);
            this.txtCodproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodproducto_KeyPress);
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.White;
            this.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtstock.Enabled = false;
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtstock.Location = new System.Drawing.Point(6, 97);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(98, 17);
            this.txtstock.TabIndex = 201;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(783, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 15);
            this.label25.TabIndex = 214;
            this.label25.Text = "Método Pago";
            // 
            // txtultprecioventa
            // 
            this.txtultprecioventa.BackColor = System.Drawing.Color.White;
            this.txtultprecioventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtultprecioventa.Enabled = false;
            this.txtultprecioventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtultprecioventa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtultprecioventa.Location = new System.Drawing.Point(110, 97);
            this.txtultprecioventa.Name = "txtultprecioventa";
            this.txtultprecioventa.Size = new System.Drawing.Size(98, 17);
            this.txtultprecioventa.TabIndex = 200;
            // 
            // btnbuscarmetodospagos
            // 
            this.btnbuscarmetodospagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarmetodospagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnbuscarmetodospagos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarmetodospagos.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarmetodospagos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarmetodospagos.IconSize = 20;
            this.btnbuscarmetodospagos.Location = new System.Drawing.Point(926, 71);
            this.btnbuscarmetodospagos.Name = "btnbuscarmetodospagos";
            this.btnbuscarmetodospagos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarmetodospagos.Size = new System.Drawing.Size(37, 31);
            this.btnbuscarmetodospagos.TabIndex = 217;
            this.btnbuscarmetodospagos.UseVisualStyleBackColor = true;
            this.btnbuscarmetodospagos.Click += new System.EventHandler(this.btnbuscarmetodospagos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "Stock Actual";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(650, 30);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(131, 21);
            this.cbotipodocumento.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(647, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(107, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 99;
            this.label6.Text = "Ult. P. Venta";
            // 
            // txtmetodopago
            // 
            this.txtmetodopago.Enabled = false;
            this.txtmetodopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetodopago.Location = new System.Drawing.Point(786, 78);
            this.txtmetodopago.Name = "txtmetodopago";
            this.txtmetodopago.Size = new System.Drawing.Size(134, 21);
            this.txtmetodopago.TabIndex = 215;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(5, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 96;
            this.label9.Text = "Cod. Barra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(205, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 106;
            this.label11.Text = "Cod. Interno";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.White;
            this.txtproducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtproducto.Enabled = false;
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtproducto.Location = new System.Drawing.Point(2, 57);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(339, 13);
            this.txtproducto.TabIndex = 3;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproducto.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscarproducto.Location = new System.Drawing.Point(504, 89);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarproducto.Size = new System.Drawing.Size(140, 29);
            this.btnbuscarproducto.TabIndex = 6;
            this.btnbuscarproducto.Text = "Buscar (F10)";
            this.btnbuscarproducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(810, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 15);
            this.label27.TabIndex = 225;
            this.label27.Text = "Vendedor";
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dgvdata);
            this.tabPage1.Controls.Add(this.btncrearcompra);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compra";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioFinal,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.Location = new System.Drawing.Point(-1, -1);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(791, 240);
            this.dgvdata.TabIndex = 208;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(0, 122);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(156, 328);
            this.tabControl2.TabIndex = 227;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblusuario.Location = new System.Drawing.Point(880, 17);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(81, 18);
            this.lblusuario.TabIndex = 224;
            this.lblusuario.Text = "lblusuario";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(187, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 323);
            this.tabControl1.TabIndex = 223;
            // 
            // btnAgregarData
            // 
            this.btnAgregarData.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarData.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarData.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btnAgregarData.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarData.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarData.IconSize = 25;
            this.btnAgregarData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarData.Location = new System.Drawing.Point(156, 256);
            this.btnAgregarData.Name = "btnAgregarData";
            this.btnAgregarData.Size = new System.Drawing.Size(32, 29);
            this.btnAgregarData.TabIndex = 222;
            this.btnAgregarData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarData.UseVisualStyleBackColor = false;
            this.btnAgregarData.Click += new System.EventHandler(this.btnAgregarData_Click);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 300;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "P. Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 130;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.HeaderText = "P. Venta";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            this.PrecioFinal.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cant U/K";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 110;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "P. Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubTotal.Width = 130;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Width = 50;
            // 
            // frmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 456);
            this.Controls.Add(this.btnAgregarData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Órden de Compras";
            this.Load += new System.EventHandler(this.frmOrdenCompra_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmOrdenCompra_KeyUp);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton btncrearcompra;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtdocumentocliente;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.TextBox txtcodbarraproducto;
        private System.Windows.Forms.TextBox txtfecha;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private System.Windows.Forms.TextBox txtCodproducto;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.TextBox txtultprecioventa;
        private FontAwesome.Sharp.IconButton btnbuscarmetodospagos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmetodopago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.Label label27;
        private FontAwesome.Sharp.IconButton btnlimpiarcampos;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.TextBox txtprecioventa;
        private FontAwesome.Sharp.IconButton btnAgregarData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotalpagar;
        private FontAwesome.Sharp.IconButton btnAgreProd;
        private System.Windows.Forms.TextBox txtultpreciocompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}