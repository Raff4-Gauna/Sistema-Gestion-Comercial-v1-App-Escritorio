﻿
namespace CapaPresentación.MdVentas
{
    partial class frmPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoVenta));
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtcodbarraproducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdocumentocliente = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtCodproducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnverificarprecio = new FontAwesome.Sharp.IconButton();
            this.btnlimpiarcampos = new FontAwesome.Sharp.IconButton();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnlimpiarcampovrapida = new FontAwesome.Sharp.IconButton();
            this.btnCrearVentaRapida = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPagoRapido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantProdRapida = new System.Windows.Forms.NumericUpDown();
            this.txtDescripProdRapida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncrearventa = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.rbCodigoBarra = new System.Windows.Forms.RadioButton();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.label25 = new System.Windows.Forms.Label();
            this.btnbuscarmetodospagos = new FontAwesome.Sharp.IconButton();
            this.txtmetodopago = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantProdRapida)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidproducto
            // 
            this.txtidproducto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtidproducto.Location = new System.Drawing.Point(645, 55);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(32, 20);
            this.txtidproducto.TabIndex = 0;
            this.txtidproducto.Visible = false;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(5, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 96;
            this.label9.Text = "Cod. Barra";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.Azure;
            this.txtproducto.Enabled = false;
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(3, 109);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(339, 20);
            this.txtproducto.TabIndex = 3;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.DecimalPlaces = 3;
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.Black;
            this.txtcantidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtcantidad.Location = new System.Drawing.Point(375, 91);
            this.txtcantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(160, 38);
            this.txtcantidad.TabIndex = 4;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
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
            this.PrecioVenta,
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
            this.dgvdata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.Location = new System.Drawing.Point(6, 6);
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
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvdata.Size = new System.Drawing.Size(658, 256);
            this.dgvdata.TabIndex = 208;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
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
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            this.PrecioVenta.Width = 130;
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
            // txtpagocon
            // 
            this.txtpagocon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpagocon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagocon.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtpagocon.Location = new System.Drawing.Point(10, 100);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(212, 38);
            this.txtpagocon.TabIndex = 213;
            this.txtpagocon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown);
            this.txtpagocon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagocon_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label16.Location = new System.Drawing.Point(10, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 24);
            this.label16.TabIndex = 209;
            this.label16.Text = "Cambio";
            // 
            // txtcambio
            // 
            this.txtcambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcambio.Enabled = false;
            this.txtcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcambio.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtcambio.Location = new System.Drawing.Point(10, 168);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(212, 38);
            this.txtcambio.TabIndex = 214;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(10, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 24);
            this.label13.TabIndex = 210;
            this.label13.Text = "Paga Con";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 211;
            this.label1.Text = "Monto Total";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalpagar.Enabled = false;
            this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.ForeColor = System.Drawing.Color.DarkGreen;
            this.txttotalpagar.Location = new System.Drawing.Point(10, 31);
            this.txttotalpagar.Multiline = true;
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(212, 39);
            this.txttotalpagar.TabIndex = 212;
            this.txttotalpagar.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(372, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "Un. / Kg.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(656, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "DocClien";
            this.label14.Visible = false;
            // 
            // txtdocumentocliente
            // 
            this.txtdocumentocliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtdocumentocliente.Enabled = false;
            this.txtdocumentocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumentocliente.Location = new System.Drawing.Point(683, 55);
            this.txtdocumentocliente.Name = "txtdocumentocliente";
            this.txtdocumentocliente.Size = new System.Drawing.Size(34, 20);
            this.txtdocumentocliente.TabIndex = 85;
            this.txtdocumentocliente.Visible = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblusuario.Location = new System.Drawing.Point(897, 17);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(61, 13);
            this.lblusuario.TabIndex = 216;
            this.lblusuario.Text = "lblusuario";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(205, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 106;
            this.label11.Text = "Cod. Interno";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(8, 81);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(98, 22);
            this.txtstock.TabIndex = 201;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "Stock Actual";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(136, 81);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(98, 22);
            this.txtprecio.TabIndex = 200;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(133, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 99;
            this.label6.Text = "Precio Venta";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 323);
            this.tabControl1.TabIndex = 209;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnverificarprecio);
            this.tabPage1.Controls.Add(this.btnlimpiarcampos);
            this.tabPage1.Controls.Add(this.dgvdata);
            this.tabPage1.Controls.Add(this.btnagregarproducto);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta Regular";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnverificarprecio
            // 
            this.btnverificarprecio.BackColor = System.Drawing.Color.Transparent;
            this.btnverificarprecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverificarprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificarprecio.ForeColor = System.Drawing.Color.Black;
            this.btnverificarprecio.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnverificarprecio.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnverificarprecio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnverificarprecio.IconSize = 25;
            this.btnverificarprecio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnverificarprecio.Location = new System.Drawing.Point(3, 263);
            this.btnverificarprecio.Name = "btnverificarprecio";
            this.btnverificarprecio.Size = new System.Drawing.Size(145, 29);
            this.btnverificarprecio.TabIndex = 221;
            this.btnverificarprecio.Text = "Precio Prod (F9)";
            this.btnverificarprecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnverificarprecio.UseVisualStyleBackColor = false;
            this.btnverificarprecio.Click += new System.EventHandler(this.btnverificarprecio_Click);
            // 
            // btnlimpiarcampos
            // 
            this.btnlimpiarcampos.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiarcampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarcampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarcampos.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarcampos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarcampos.IconColor = System.Drawing.Color.CadetBlue;
            this.btnlimpiarcampos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiarcampos.IconSize = 20;
            this.btnlimpiarcampos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpiarcampos.Location = new System.Drawing.Point(670, 64);
            this.btnlimpiarcampos.Name = "btnlimpiarcampos";
            this.btnlimpiarcampos.Size = new System.Drawing.Size(56, 52);
            this.btnlimpiarcampos.TabIndex = 5;
            this.btnlimpiarcampos.Text = "Limpiar (F2)";
            this.btnlimpiarcampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlimpiarcampos.UseVisualStyleBackColor = false;
            this.btnlimpiarcampos.Click += new System.EventHandler(this.btnlimpiarcampos_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.Black;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnagregarproducto.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnagregarproducto.IconSize = 20;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregarproducto.Location = new System.Drawing.Point(670, 6);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(56, 52);
            this.btnagregarproducto.TabIndex = 6;
            this.btnagregarproducto.Text = "Agregar (F1)";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproducto.UseVisualStyleBackColor = false;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tabPage3.Controls.Add(this.btnlimpiarcampovrapida);
            this.tabPage3.Controls.Add(this.btnCrearVentaRapida);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtPagoRapido);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtCantProdRapida);
            this.tabPage3.Controls.Add(this.txtDescripProdRapida);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(972, 295);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Venta Express ";
            // 
            // btnlimpiarcampovrapida
            // 
            this.btnlimpiarcampovrapida.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiarcampovrapida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarcampovrapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarcampovrapida.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarcampovrapida.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarcampovrapida.IconColor = System.Drawing.Color.CadetBlue;
            this.btnlimpiarcampovrapida.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiarcampovrapida.IconSize = 20;
            this.btnlimpiarcampovrapida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpiarcampovrapida.Location = new System.Drawing.Point(667, 77);
            this.btnlimpiarcampovrapida.Name = "btnlimpiarcampovrapida";
            this.btnlimpiarcampovrapida.Size = new System.Drawing.Size(56, 46);
            this.btnlimpiarcampovrapida.TabIndex = 230;
            this.btnlimpiarcampovrapida.Text = "Limpiar";
            this.btnlimpiarcampovrapida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlimpiarcampovrapida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlimpiarcampovrapida.UseVisualStyleBackColor = false;
            this.btnlimpiarcampovrapida.Click += new System.EventHandler(this.btnlimpiarcampovrapida_Click);
            // 
            // btnCrearVentaRapida
            // 
            this.btnCrearVentaRapida.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearVentaRapida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearVentaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVentaRapida.ForeColor = System.Drawing.Color.Black;
            this.btnCrearVentaRapida.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnCrearVentaRapida.IconColor = System.Drawing.Color.Maroon;
            this.btnCrearVentaRapida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearVentaRapida.IconSize = 25;
            this.btnCrearVentaRapida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCrearVentaRapida.Location = new System.Drawing.Point(511, 77);
            this.btnCrearVentaRapida.Name = "btnCrearVentaRapida";
            this.btnCrearVentaRapida.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnCrearVentaRapida.Size = new System.Drawing.Size(85, 77);
            this.btnCrearVentaRapida.TabIndex = 229;
            this.btnCrearVentaRapida.Text = "Venta Rapida";
            this.btnCrearVentaRapida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearVentaRapida.UseVisualStyleBackColor = false;
            this.btnCrearVentaRapida.Click += new System.EventHandler(this.btnCrearVentaRapida_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(508, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 216;
            this.label10.Text = "Importe Total";
            // 
            // txtPagoRapido
            // 
            this.txtPagoRapido.BackColor = System.Drawing.Color.White;
            this.txtPagoRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagoRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoRapido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPagoRapido.Location = new System.Drawing.Point(511, 33);
            this.txtPagoRapido.Name = "txtPagoRapido";
            this.txtPagoRapido.Size = new System.Drawing.Size(212, 38);
            this.txtPagoRapido.TabIndex = 228;
            this.txtPagoRapido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoRapido_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(335, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 227;
            this.label8.Text = "Un. / Kg. *";
            // 
            // txtCantProdRapida
            // 
            this.txtCantProdRapida.BackColor = System.Drawing.Color.Honeydew;
            this.txtCantProdRapida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantProdRapida.DecimalPlaces = 3;
            this.txtCantProdRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantProdRapida.ForeColor = System.Drawing.Color.Black;
            this.txtCantProdRapida.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtCantProdRapida.Location = new System.Drawing.Point(335, 33);
            this.txtCantProdRapida.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantProdRapida.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtCantProdRapida.Name = "txtCantProdRapida";
            this.txtCantProdRapida.Size = new System.Drawing.Size(160, 38);
            this.txtCantProdRapida.TabIndex = 226;
            this.txtCantProdRapida.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantProdRapida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantProdRapida_KeyPress);
            // 
            // txtDescripProdRapida
            // 
            this.txtDescripProdRapida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDescripProdRapida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripProdRapida.BackColor = System.Drawing.Color.Linen;
            this.txtDescripProdRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripProdRapida.Location = new System.Drawing.Point(7, 33);
            this.txtDescripProdRapida.Multiline = true;
            this.txtDescripProdRapida.Name = "txtDescripProdRapida";
            this.txtDescripProdRapida.Size = new System.Drawing.Size(313, 67);
            this.txtDescripProdRapida.TabIndex = 225;
            this.txtDescripProdRapida.TextChanged += new System.EventHandler(this.txtDescripProdRapida_TextChanged);
            this.txtDescripProdRapida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripProdRapida_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 224;
            this.label3.Text = "Descripción Producto *";
            // 
            // btncrearventa
            // 
            this.btncrearventa.BackColor = System.Drawing.Color.Transparent;
            this.btncrearventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrearventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btncrearventa.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 25;
            this.btncrearventa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncrearventa.Location = new System.Drawing.Point(10, 212);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btncrearventa.Size = new System.Drawing.Size(94, 52);
            this.btncrearventa.TabIndex = 215;
            this.btncrearventa.Text = "Cobrar (F5)";
            this.btncrearventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncrearventa.UseVisualStyleBackColor = false;
            this.btncrearventa.Click += new System.EventHandler(this.btncrearventa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(642, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(644, 31);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(131, 21);
            this.cbotipodocumento.TabIndex = 93;
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(787, 105);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(119, 21);
            this.txtfecha.TabIndex = 90;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproducto.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.Location = new System.Drawing.Point(562, 97);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarproducto.Size = new System.Drawing.Size(76, 32);
            this.btnbuscarproducto.TabIndex = 6;
            this.btnbuscarproducto.Text = "(F10)";
            this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtDescripcionProd);
            this.groupBox1.Controls.Add(this.txtidproducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtdocumentocliente);
            this.groupBox1.Controls.Add(this.rbCodigoBarra);
            this.groupBox1.Controls.Add(this.txtnombrecliente);
            this.groupBox1.Controls.Add(this.txtcodbarraproducto);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.btnbuscarcliente);
            this.groupBox1.Controls.Add(this.txtCodproducto);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.btnbuscarmetodospagos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmetodopago);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(-5, -13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 140);
            this.groupBox1.TabIndex = 220;
            this.groupBox1.TabStop = false;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDescripcionProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripcionProd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProd.Location = new System.Drawing.Point(336, 31);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(302, 20);
            this.txtDescripcionProd.TabIndex = 3;
            this.txtDescripcionProd.TextChanged += new System.EventHandler(this.txtDescripcionProd_TextChanged);
            this.txtDescripcionProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcionProd_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(333, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 223;
            this.label2.Text = "Descripción";
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(240, 89);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 16);
            this.rbCodigo.TabIndex = 222;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(784, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 15);
            this.label15.TabIndex = 83;
            this.label15.Text = "Nombre Cliente";
            // 
            // rbCodigoBarra
            // 
            this.rbCodigoBarra.AutoSize = true;
            this.rbCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigoBarra.Location = new System.Drawing.Point(240, 71);
            this.rbCodigoBarra.Name = "rbCodigoBarra";
            this.rbCodigoBarra.Size = new System.Drawing.Size(94, 16);
            this.rbCodigoBarra.TabIndex = 221;
            this.rbCodigoBarra.TabStop = true;
            this.rbCodigoBarra.Text = "Código Barras";
            this.rbCodigoBarra.UseVisualStyleBackColor = true;
            this.rbCodigoBarra.CheckedChanged += new System.EventHandler(this.rbCodigoBarra_CheckedChanged);
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Enabled = false;
            this.txtnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(787, 33);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(134, 21);
            this.txtnombrecliente.TabIndex = 86;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarcliente.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarcliente.IconSize = 20;
            this.btnbuscarcliente.Location = new System.Drawing.Point(925, 31);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarcliente.Size = new System.Drawing.Size(37, 31);
            this.btnbuscarcliente.TabIndex = 87;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(784, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 15);
            this.label25.TabIndex = 214;
            this.label25.Text = "Método Pago";
            // 
            // btnbuscarmetodospagos
            // 
            this.btnbuscarmetodospagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarmetodospagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnbuscarmetodospagos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarmetodospagos.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarmetodospagos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarmetodospagos.IconSize = 20;
            this.btnbuscarmetodospagos.Location = new System.Drawing.Point(925, 72);
            this.btnbuscarmetodospagos.Name = "btnbuscarmetodospagos";
            this.btnbuscarmetodospagos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarmetodospagos.Size = new System.Drawing.Size(37, 31);
            this.btnbuscarmetodospagos.TabIndex = 217;
            this.btnbuscarmetodospagos.UseVisualStyleBackColor = true;
            this.btnbuscarmetodospagos.Click += new System.EventHandler(this.btnbuscarmetodospagos_Click);
            // 
            // txtmetodopago
            // 
            this.txtmetodopago.Enabled = false;
            this.txtmetodopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetodopago.Location = new System.Drawing.Point(787, 78);
            this.txtmetodopago.Name = "txtmetodopago";
            this.txtmetodopago.Size = new System.Drawing.Size(134, 21);
            this.txtmetodopago.TabIndex = 215;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(734, 133);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(243, 320);
            this.tabControl2.TabIndex = 222;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.txtpagocon);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txttotalpagar);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.btncrearventa);
            this.tabPage2.Controls.Add(this.txtcambio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(235, 294);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Intercambio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 456);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPuntoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPuntoVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmPuntoVenta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPuntoVenta_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantProdRapida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.TextBox txtcodbarraproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btncrearventa;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdocumentocliente;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodproducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private FontAwesome.Sharp.IconButton btnlimpiarcampos;
        private FontAwesome.Sharp.IconButton btnverificarprecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private System.Windows.Forms.Label label25;
        private FontAwesome.Sharp.IconButton btnbuscarmetodospagos;
        private System.Windows.Forms.TextBox txtmetodopago;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbCodigoBarra;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripProdRapida;
        private System.Windows.Forms.NumericUpDown txtCantProdRapida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPagoRapido;
        private FontAwesome.Sharp.IconButton btnCrearVentaRapida;
        private FontAwesome.Sharp.IconButton btnlimpiarcampovrapida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}