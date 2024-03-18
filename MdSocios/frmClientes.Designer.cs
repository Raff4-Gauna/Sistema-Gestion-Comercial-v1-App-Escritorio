
namespace CapaPresentación.MdSocios
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoContribuyentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoContribuyentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoContribuyente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalSucursales = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox1.Location = new System.Drawing.Point(198, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 107;
            this.checkBox1.Text = "Generar Nro";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(160, 14);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(222, 23);
            this.txtbusqueda.TabIndex = 105;
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(124, 417);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 106;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.IdTipoContribuyentes,
            this.TipoContribuyentes,
            this.NombreCompleto,
            this.Documento,
            this.CUIT,
            this.Correo,
            this.Telefono,
            this.Notas,
            this.EstadoValor,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.Location = new System.Drawing.Point(0, 250);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(922, 154);
            this.dgvdata.TabIndex = 98;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IdTipoContribuyentes
            // 
            this.IdTipoContribuyentes.HeaderText = "IdTipoContribuyentes";
            this.IdTipoContribuyentes.Name = "IdTipoContribuyentes";
            this.IdTipoContribuyentes.ReadOnly = true;
            this.IdTipoContribuyentes.Visible = false;
            this.IdTipoContribuyentes.Width = 20;
            // 
            // TipoContribuyentes
            // 
            this.TipoContribuyentes.HeaderText = "Contribuyentes";
            this.TipoContribuyentes.Name = "TipoContribuyentes";
            this.TipoContribuyentes.ReadOnly = true;
            this.TipoContribuyentes.Width = 170;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 180;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 160;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.Width = 130;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 140;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Notas
            // 
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            this.Notas.ReadOnly = true;
            this.Notas.Visible = false;
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
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.LightSalmon;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 20;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(466, 15);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(72, 22);
            this.btnlimpiarbuscador.TabIndex = 104;
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 20;
            this.btnbuscar.Location = new System.Drawing.Point(388, 15);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(72, 22);
            this.btnbuscar.TabIndex = 103;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(5, 14);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(149, 24);
            this.cbobusqueda.TabIndex = 102;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(156, 417);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 100;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 16;
            this.btneliminar.Location = new System.Drawing.Point(572, 410);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(165, 30);
            this.btneliminar.TabIndex = 96;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Wheat;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 18;
            this.btnlimpiar.Location = new System.Drawing.Point(389, 410);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(165, 30);
            this.btnlimpiar.TabIndex = 95;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 16;
            this.btnguardar.Location = new System.Drawing.Point(204, 410);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(165, 30);
            this.btnguardar.TabIndex = 94;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 93;
            this.label8.Text = "Estado:";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(12, 173);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(165, 24);
            this.cboestado.TabIndex = 92;
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(329, 90);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(212, 22);
            this.txttelefono.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(326, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "Telefono:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(328, 41);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(213, 22);
            this.txtcorreo.TabIndex = 89;
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtnombrecompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecompleto.Location = new System.Drawing.Point(10, 41);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(182, 22);
            this.txtnombrecompleto.TabIndex = 88;
            this.txtnombrecompleto.TextChanged += new System.EventHandler(this.txtnombrecompleto_TextChanged);
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.Location = new System.Drawing.Point(10, 85);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(182, 22);
            this.txtdocumento.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(325, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 85;
            this.label3.Text = "Nombre: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "N° Documento: *";
            // 
            // cboTipoContribuyente
            // 
            this.cboTipoContribuyente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoContribuyente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoContribuyente.FormattingEnabled = true;
            this.cboTipoContribuyente.Location = new System.Drawing.Point(608, 41);
            this.cboTipoContribuyente.Name = "cboTipoContribuyente";
            this.cboTipoContribuyente.Size = new System.Drawing.Size(199, 24);
            this.cboTipoContribuyente.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(605, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 131;
            this.label7.Text = "Condición IVA: *";
            // 
            // txtNotas
            // 
            this.txtNotas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(329, 143);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(225, 51);
            this.txtNotas.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(326, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 130;
            this.label13.Text = "Notas:";
            // 
            // txtcuit
            // 
            this.txtcuit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuit.Location = new System.Drawing.Point(10, 130);
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(188, 22);
            this.txtcuit.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "C.U.I.T:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbobusqueda);
            this.groupBox2.Controls.Add(this.txtbusqueda);
            this.groupBox2.Controls.Add(this.lblTotalSucursales);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.btnlimpiarbuscador);
            this.groupBox2.Location = new System.Drawing.Point(0, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 44);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(782, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 136;
            this.label9.Text = "Total:";
            // 
            // lblTotalSucursales
            // 
            this.lblTotalSucursales.AutoSize = true;
            this.lblTotalSucursales.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTotalSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSucursales.Location = new System.Drawing.Point(830, 16);
            this.lblTotalSucursales.Name = "lblTotalSucursales";
            this.lblTotalSucursales.Size = new System.Drawing.Size(49, 20);
            this.lblTotalSucursales.TabIndex = 135;
            this.lblTotalSucursales.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 133;
            this.label10.Text = "Persona Física";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-3, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 21);
            this.label6.TabIndex = 211;
            this.label6.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(605, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 16);
            this.label12.TabIndex = 213;
            this.label12.Text = "Datos para Facturación";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(591, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 21);
            this.label14.TabIndex = 214;
            this.label14.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(326, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 16);
            this.label15.TabIndex = 215;
            this.label15.Text = "Datos del Contacto";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(312, 5);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(242, 21);
            this.label16.TabIndex = 216;
            this.label16.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______";
            // 
            // frmClientes
            // 
            this.AcceptButton = this.btnguardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 445);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtcuit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboTipoContribuyente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Gestión de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboTipoContribuyente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalSucursales;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoContribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoContribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}