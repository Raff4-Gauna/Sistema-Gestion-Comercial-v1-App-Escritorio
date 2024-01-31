
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtcodbarraproducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdocumentocliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtmetodopago = new System.Windows.Forms.TextBox();
            this.txtCodproducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnverificarprecio = new FontAwesome.Sharp.IconButton();
            this.btnlimpiarcampos = new FontAwesome.Sharp.IconButton();
            this.btncrearventa = new FontAwesome.Sharp.IconButton();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.btnbuscarmetodospagos = new FontAwesome.Sharp.IconButton();
            this.btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(393, 10);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(32, 20);
            this.txtidproducto.TabIndex = 0;
            this.txtidproducto.Visible = false;
            // 
            // txtcodbarraproducto
            // 
            this.txtcodbarraproducto.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtcodbarraproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodbarraproducto.Location = new System.Drawing.Point(124, 55);
            this.txtcodbarraproducto.Name = "txtcodbarraproducto";
            this.txtcodbarraproducto.Size = new System.Drawing.Size(213, 21);
            this.txtcodbarraproducto.TabIndex = 1;
            this.txtcodbarraproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodbarraproducto_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(121, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 96;
            this.label9.Text = "Cod. Barra";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.BurlyWood;
            this.txtproducto.Enabled = false;
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(6, 95);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(274, 24);
            this.txtproducto.TabIndex = 3;
            // 
            // txtcantidad
            // 
            this.txtcantidad.DecimalPlaces = 2;
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtcantidad.Location = new System.Drawing.Point(307, 126);
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
            this.txtcantidad.Size = new System.Drawing.Size(109, 38);
            this.txtcantidad.TabIndex = 6;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.Location = new System.Drawing.Point(6, 6);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(570, 311);
            this.dgvdata.TabIndex = 208;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // txtpagocon
            // 
            this.txtpagocon.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagocon.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtpagocon.Location = new System.Drawing.Point(686, 109);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(248, 47);
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
            this.label16.Location = new System.Drawing.Point(684, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 24);
            this.label16.TabIndex = 209;
            this.label16.Text = "Cambio";
            // 
            // txtcambio
            // 
            this.txtcambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcambio.Enabled = false;
            this.txtcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcambio.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtcambio.Location = new System.Drawing.Point(688, 190);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(246, 47);
            this.txtcambio.TabIndex = 214;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(684, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 24);
            this.label13.TabIndex = 210;
            this.label13.Text = "Paga con";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(682, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 211;
            this.label1.Text = "Total a Pagar";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttotalpagar.Enabled = false;
            this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.ForeColor = System.Drawing.Color.DarkGreen;
            this.txttotalpagar.Location = new System.Drawing.Point(686, 28);
            this.txttotalpagar.Multiline = true;
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(248, 49);
            this.txttotalpagar.TabIndex = 212;
            this.txttotalpagar.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(304, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "Cantidad U/Kg:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(471, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "DocClien";
            this.label14.Visible = false;
            // 
            // txtdocumentocliente
            // 
            this.txtdocumentocliente.Enabled = false;
            this.txtdocumentocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumentocliente.Location = new System.Drawing.Point(431, 7);
            this.txtdocumentocliente.Name = "txtdocumentocliente";
            this.txtdocumentocliente.Size = new System.Drawing.Size(34, 24);
            this.txtdocumentocliente.TabIndex = 85;
            this.txtdocumentocliente.Visible = false;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Enabled = false;
            this.txtnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(787, 80);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(134, 22);
            this.txtnombrecliente.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(785, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 15);
            this.label15.TabIndex = 83;
            this.label15.Text = "Nombre Cliente";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(784, 107);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 15);
            this.label25.TabIndex = 214;
            this.label25.Text = "Método Pago";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblusuario.Location = new System.Drawing.Point(881, 6);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(81, 18);
            this.lblusuario.TabIndex = 216;
            this.lblusuario.Text = "lblusuario";
            // 
            // txtmetodopago
            // 
            this.txtmetodopago.Enabled = false;
            this.txtmetodopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetodopago.Location = new System.Drawing.Point(787, 130);
            this.txtmetodopago.Name = "txtmetodopago";
            this.txtmetodopago.Size = new System.Drawing.Size(134, 22);
            this.txtmetodopago.TabIndex = 215;
            // 
            // txtCodproducto
            // 
            this.txtCodproducto.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtCodproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodproducto.Location = new System.Drawing.Point(5, 55);
            this.txtCodproducto.Name = "txtCodproducto";
            this.txtCodproducto.Size = new System.Drawing.Size(113, 22);
            this.txtCodproducto.TabIndex = 105;
            this.txtCodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodproducto_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(2, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 106;
            this.label11.Text = "Cod. Interno";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(110, 136);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(98, 24);
            this.txtstock.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 97;
            this.label8.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(107, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "Stock Actual";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(6, 137);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(98, 24);
            this.txtprecio.TabIndex = 4;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 99;
            this.label6.Text = "Precio Venta";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 382);
            this.tabControl1.TabIndex = 209;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnverificarprecio);
            this.tabPage1.Controls.Add(this.btnlimpiarcampos);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.btncrearventa);
            this.tabPage1.Controls.Add(this.txtcambio);
            this.tabPage1.Controls.Add(this.dgvdata);
            this.tabPage1.Controls.Add(this.txtpagocon);
            this.tabPage1.Controls.Add(this.txttotalpagar);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.btnagregarproducto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta";
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
            this.btnverificarprecio.Location = new System.Drawing.Point(6, 319);
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
            this.btnlimpiarcampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarcampos.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarcampos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarcampos.IconColor = System.Drawing.Color.CadetBlue;
            this.btnlimpiarcampos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnlimpiarcampos.IconSize = 30;
            this.btnlimpiarcampos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpiarcampos.Location = new System.Drawing.Point(582, 73);
            this.btnlimpiarcampos.Name = "btnlimpiarcampos";
            this.btnlimpiarcampos.Size = new System.Drawing.Size(66, 62);
            this.btnlimpiarcampos.TabIndex = 216;
            this.btnlimpiarcampos.Text = "Limpiar (F2)";
            this.btnlimpiarcampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnlimpiarcampos.UseVisualStyleBackColor = false;
            this.btnlimpiarcampos.Click += new System.EventHandler(this.btnlimpiarcampos_Click);
            // 
            // btncrearventa
            // 
            this.btncrearventa.BackColor = System.Drawing.Color.Transparent;
            this.btncrearventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrearventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearventa.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btncrearventa.IconColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btncrearventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrearventa.IconSize = 30;
            this.btncrearventa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncrearventa.Location = new System.Drawing.Point(688, 243);
            this.btncrearventa.Name = "btncrearventa";
            this.btncrearventa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btncrearventa.Size = new System.Drawing.Size(78, 65);
            this.btncrearventa.TabIndex = 215;
            this.btncrearventa.Text = "Grabar (F5)";
            this.btncrearventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncrearventa.UseVisualStyleBackColor = false;
            this.btncrearventa.Click += new System.EventHandler(this.btncrearventa_Click);
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.Black;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnagregarproducto.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnagregarproducto.IconSize = 30;
            this.btnagregarproducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregarproducto.Location = new System.Drawing.Point(582, 6);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(66, 61);
            this.btnagregarproducto.TabIndex = 206;
            this.btnagregarproducto.Text = "Agregar (F1)";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproducto.UseVisualStyleBackColor = false;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::CapaPresentación.Properties.Resources.vertical_line;
            this.pictureBox2.Location = new System.Drawing.Point(631, -24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 378);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 220;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle de Venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(180, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Doc.";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(254, 4);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(131, 24);
            this.cbotipodocumento.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha";
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(55, 4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(119, 21);
            this.txtfecha.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-8, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1099, 21);
            this.label2.TabIndex = 210;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(714, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(91, 21);
            this.textBox3.TabIndex = 212;
            this.textBox3.Text = "0000-000001";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(687, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 211;
            this.label10.Text = "N°";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(811, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 15);
            this.label27.TabIndex = 217;
            this.label27.Text = "Vendedor";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(-6, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1099, 21);
            this.label12.TabIndex = 218;
            this.label12.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CapaPresentación.Properties.Resources.vertical_line;
            this.pictureBox1.Location = new System.Drawing.Point(632, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 219;
            this.pictureBox1.TabStop = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarproducto.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarproducto.IconSize = 20;
            this.btnbuscarproducto.Location = new System.Drawing.Point(357, 39);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarproducto.Size = new System.Drawing.Size(68, 38);
            this.btnbuscarproducto.TabIndex = 2;
            this.btnbuscarproducto.Text = "(F10)";
            this.btnbuscarproducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarproducto.UseVisualStyleBackColor = true;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnbuscarmetodospagos
            // 
            this.btnbuscarmetodospagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarmetodospagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnbuscarmetodospagos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarmetodospagos.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarmetodospagos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarmetodospagos.IconSize = 20;
            this.btnbuscarmetodospagos.Location = new System.Drawing.Point(927, 123);
            this.btnbuscarmetodospagos.Name = "btnbuscarmetodospagos";
            this.btnbuscarmetodospagos.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarmetodospagos.Size = new System.Drawing.Size(37, 31);
            this.btnbuscarmetodospagos.TabIndex = 217;
            this.btnbuscarmetodospagos.UseVisualStyleBackColor = true;
            this.btnbuscarmetodospagos.Click += new System.EventHandler(this.btnbuscarmetodospagos_Click);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarcliente.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarcliente.IconSize = 20;
            this.btnbuscarcliente.Location = new System.Drawing.Point(927, 74);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnbuscarcliente.Size = new System.Drawing.Size(37, 31);
            this.btnbuscarcliente.TabIndex = 87;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
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
            this.Producto.Width = 250;
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
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubTotal.Width = 110;
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
            // frmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.txtCodproducto);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnbuscarproducto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtcodbarraproducto);
            this.Controls.Add(this.txtmetodopago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnbuscarmetodospagos);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.txtdocumentocliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbotipodocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPuntoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            this.Load += new System.EventHandler(this.frmPuntoVenta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPuntoVenta_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodproducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtmetodopago;
        private FontAwesome.Sharp.IconButton btnbuscarmetodospagos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnlimpiarcampos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnverificarprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}