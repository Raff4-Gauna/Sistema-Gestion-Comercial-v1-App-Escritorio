
namespace CapaPresentación.MdVentas
{
    partial class frmListaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btngenerarpdf = new FontAwesome.Sharp.IconButton();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvdatadetalleventa = new System.Windows.Forms.DataGridView();
            this.IdDetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.chekboxMostarTodoDatagrid = new System.Windows.Forms.CheckBox();
            this.btnanularventa = new FontAwesome.Sharp.IconButton();
            this.btnvercomprobante = new FontAwesome.Sharp.IconButton();
            this.btnenviarporemail = new FontAwesome.Sharp.IconButton();
            this.btngenerarexls = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatadetalleventa)).BeginInit();
            this.SuspendLayout();
            // 
            // btngenerarpdf
            // 
            this.btngenerarpdf.BackColor = System.Drawing.Color.White;
            this.btngenerarpdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarpdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btngenerarpdf.IconColor = System.Drawing.Color.Red;
            this.btngenerarpdf.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btngenerarpdf.IconSize = 20;
            this.btngenerarpdf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngenerarpdf.Location = new System.Drawing.Point(321, 518);
            this.btngenerarpdf.Name = "btngenerarpdf";
            this.btngenerarpdf.Size = new System.Drawing.Size(151, 31);
            this.btngenerarpdf.TabIndex = 227;
            this.btngenerarpdf.Text = "Generar PDF";
            this.btngenerarpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngenerarpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerarpdf.UseVisualStyleBackColor = false;
            this.btngenerarpdf.Click += new System.EventHandler(this.btngenerarpdf_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrar.IconColor = System.Drawing.Color.Black;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnborrar.IconSize = 20;
            this.btnborrar.Location = new System.Drawing.Point(699, 2);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(92, 24);
            this.btnborrar.TabIndex = 214;
            this.btnborrar.Text = "Limpiar";
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscar.IconSize = 17;
            this.btnbuscar.Location = new System.Drawing.Point(572, 3);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(115, 24);
            this.btnbuscar.TabIndex = 212;
            this.btnbuscar.Text = "Ver Todos";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.IdVenta,
            this.NombreCompleto,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.NombreCliente,
            this.MontoTotal,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.Location = new System.Drawing.Point(5, 36);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(988, 192);
            this.dgvdata.TabIndex = 236;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnseleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnseleccionar.Width = 50;
            // 
            // IdVenta
            // 
            this.IdVenta.HeaderText = "IdVenta";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            this.IdVenta.Visible = false;
            this.IdVenta.Width = 30;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Usuario";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 180;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "N° Comprobante";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 150;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 180;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "GastoTotal";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MontoTotal.Width = 150;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(388, 4);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(97, 20);
            this.txtfechafin.TabIndex = 244;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(200, 4);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(97, 20);
            this.txtfechainicio.TabIndex = 242;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 243;
            this.label7.Text = "Fecha Desde:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 241;
            this.label8.Text = "Fecha Hasta:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 231);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 281);
            this.tabControl1.TabIndex = 245;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvdatadetalleventa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle de Venta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvdatadetalleventa
            // 
            this.dgvdatadetalleventa.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatadetalleventa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdatadetalleventa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatadetalleventa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdatadetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatadetalleventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalleVenta,
            this.DescripcionMetodoPago,
            this.DescripcionGeneral,
            this.Cantidad,
            this.TotalDetalle,
            this.MontoPago,
            this.MontoCambio,
            this.PrecioVenta,
            this.dataGridViewButtonColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatadetalleventa.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdatadetalleventa.EnableHeadersVisualStyles = false;
            this.dgvdatadetalleventa.Location = new System.Drawing.Point(6, 6);
            this.dgvdatadetalleventa.MultiSelect = false;
            this.dgvdatadetalleventa.Name = "dgvdatadetalleventa";
            this.dgvdatadetalleventa.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatadetalleventa.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatadetalleventa.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdatadetalleventa.RowTemplate.Height = 28;
            this.dgvdatadetalleventa.Size = new System.Drawing.Size(969, 243);
            this.dgvdatadetalleventa.TabIndex = 246;
            // 
            // IdDetalleVenta
            // 
            this.IdDetalleVenta.HeaderText = "IdDetalleVenta";
            this.IdDetalleVenta.Name = "IdDetalleVenta";
            this.IdDetalleVenta.ReadOnly = true;
            this.IdDetalleVenta.Visible = false;
            // 
            // DescripcionMetodoPago
            // 
            this.DescripcionMetodoPago.HeaderText = "Pago";
            this.DescripcionMetodoPago.Name = "DescripcionMetodoPago";
            this.DescripcionMetodoPago.ReadOnly = true;
            this.DescripcionMetodoPago.Width = 130;
            // 
            // DescripcionGeneral
            // 
            this.DescripcionGeneral.HeaderText = "Productos";
            this.DescripcionGeneral.Name = "DescripcionGeneral";
            this.DescripcionGeneral.ReadOnly = true;
            this.DescripcionGeneral.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cant";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 80;
            // 
            // TotalDetalle
            // 
            this.TotalDetalle.HeaderText = "ValorProd";
            this.TotalDetalle.Name = "TotalDetalle";
            this.TotalDetalle.ReadOnly = true;
            this.TotalDetalle.Width = 120;
            // 
            // MontoPago
            // 
            this.MontoPago.HeaderText = "PagoCon";
            this.MontoPago.Name = "MontoPago";
            this.MontoPago.ReadOnly = true;
            this.MontoPago.Width = 120;
            // 
            // MontoCambio
            // 
            this.MontoCambio.HeaderText = "MontoCambio";
            this.MontoCambio.Name = "MontoCambio";
            this.MontoCambio.ReadOnly = true;
            this.MontoCambio.Width = 120;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            this.PrecioVenta.Width = 120;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Width = 35;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lineas de Venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-8, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1110, 21);
            this.label2.TabIndex = 246;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______";
            // 
            // chekboxMostarTodoDatagrid
            // 
            this.chekboxMostarTodoDatagrid.AutoSize = true;
            this.chekboxMostarTodoDatagrid.Location = new System.Drawing.Point(491, 6);
            this.chekboxMostarTodoDatagrid.Name = "chekboxMostarTodoDatagrid";
            this.chekboxMostarTodoDatagrid.Size = new System.Drawing.Size(75, 17);
            this.chekboxMostarTodoDatagrid.TabIndex = 247;
            this.chekboxMostarTodoDatagrid.Text = "Ver Todos";
            this.chekboxMostarTodoDatagrid.UseVisualStyleBackColor = true;
            this.chekboxMostarTodoDatagrid.CheckedChanged += new System.EventHandler(this.chekboxMostarTodoDatagrid_CheckedChanged);
            // 
            // btnanularventa
            // 
            this.btnanularventa.BackColor = System.Drawing.Color.White;
            this.btnanularventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanularventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanularventa.IconChar = FontAwesome.Sharp.IconChar.LevelUp;
            this.btnanularventa.IconColor = System.Drawing.Color.Purple;
            this.btnanularventa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnanularventa.IconSize = 20;
            this.btnanularventa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnanularventa.Location = new System.Drawing.Point(819, 518);
            this.btnanularventa.Name = "btnanularventa";
            this.btnanularventa.Size = new System.Drawing.Size(151, 31);
            this.btnanularventa.TabIndex = 248;
            this.btnanularventa.Text = "Anular Venta";
            this.btnanularventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnanularventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnanularventa.UseVisualStyleBackColor = false;
            // 
            // btnvercomprobante
            // 
            this.btnvercomprobante.BackColor = System.Drawing.Color.White;
            this.btnvercomprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvercomprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvercomprobante.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnvercomprobante.IconColor = System.Drawing.Color.OliveDrab;
            this.btnvercomprobante.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnvercomprobante.IconSize = 20;
            this.btnvercomprobante.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnvercomprobante.Location = new System.Drawing.Point(7, 518);
            this.btnvercomprobante.Name = "btnvercomprobante";
            this.btnvercomprobante.Size = new System.Drawing.Size(151, 31);
            this.btnvercomprobante.TabIndex = 249;
            this.btnvercomprobante.Text = "Ver Comprobante";
            this.btnvercomprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvercomprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvercomprobante.UseVisualStyleBackColor = false;
            // 
            // btnenviarporemail
            // 
            this.btnenviarporemail.BackColor = System.Drawing.Color.White;
            this.btnenviarporemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenviarporemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviarporemail.IconChar = FontAwesome.Sharp.IconChar.EnvelopeCircleCheck;
            this.btnenviarporemail.IconColor = System.Drawing.Color.Brown;
            this.btnenviarporemail.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnenviarporemail.IconSize = 20;
            this.btnenviarporemail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnenviarporemail.Location = new System.Drawing.Point(164, 518);
            this.btnenviarporemail.Name = "btnenviarporemail";
            this.btnenviarporemail.Size = new System.Drawing.Size(151, 31);
            this.btnenviarporemail.TabIndex = 250;
            this.btnenviarporemail.Text = "Enviar por Email";
            this.btnenviarporemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenviarporemail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnenviarporemail.UseVisualStyleBackColor = false;
            // 
            // btngenerarexls
            // 
            this.btngenerarexls.BackColor = System.Drawing.Color.White;
            this.btngenerarexls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarexls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarexls.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btngenerarexls.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btngenerarexls.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btngenerarexls.IconSize = 20;
            this.btngenerarexls.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngenerarexls.Location = new System.Drawing.Point(478, 518);
            this.btngenerarexls.Name = "btngenerarexls";
            this.btngenerarexls.Size = new System.Drawing.Size(151, 31);
            this.btngenerarexls.TabIndex = 251;
            this.btngenerarexls.Text = "Exportar a XLS";
            this.btngenerarexls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngenerarexls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngenerarexls.UseVisualStyleBackColor = false;
            // 
            // frmListaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 561);
            this.Controls.Add(this.btngenerarexls);
            this.Controls.Add(this.btnenviarporemail);
            this.Controls.Add(this.btnvercomprobante);
            this.Controls.Add(this.btnanularventa);
            this.Controls.Add(this.btngenerarpdf);
            this.Controls.Add(this.chekboxMostarTodoDatagrid);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "frmListaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de Ventas";
            this.Load += new System.EventHandler(this.frmListaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatadetalleventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btngenerarpdf;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvdatadetalleventa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chekboxMostarTodoDatagrid;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private FontAwesome.Sharp.IconButton btnanularventa;
        private FontAwesome.Sharp.IconButton btnvercomprobante;
        private FontAwesome.Sharp.IconButton btnenviarporemail;
        private FontAwesome.Sharp.IconButton btngenerarexls;
    }
}