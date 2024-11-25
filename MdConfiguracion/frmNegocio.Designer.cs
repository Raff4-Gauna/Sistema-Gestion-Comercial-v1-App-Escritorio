
namespace CapaPresentación.MdConfiguracion
{
    partial class frmNegocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNegocio));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEnviaCorreo = new FontAwesome.Sharp.IconButton();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.btnGuardarCredenCorreo = new FontAwesome.Sharp.IconButton();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbocajaopcionapertura = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncajaopcionapertura = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.cbolistadoimpresoras = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtingresosbrutos = new System.Windows.Forms.TextBox();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.txttitular = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsubir = new FontAwesome.Sharp.IconButton();
            this.btnguardarcambios = new FontAwesome.Sharp.IconButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnimpreguardar = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.btnimpreguardar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(871, 366);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Correo Electronico";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEnviaCorreo);
            this.groupBox4.Controls.Add(this.txtMensaje);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtDestinatario);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(53, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 201);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enviar Prueba";
            // 
            // btnEnviaCorreo
            // 
            this.btnEnviaCorreo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEnviaCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviaCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviaCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviaCorreo.IconChar = FontAwesome.Sharp.IconChar.LevelUp;
            this.btnEnviaCorreo.IconColor = System.Drawing.Color.Black;
            this.btnEnviaCorreo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEnviaCorreo.IconSize = 25;
            this.btnEnviaCorreo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviaCorreo.Location = new System.Drawing.Point(574, 99);
            this.btnEnviaCorreo.Name = "btnEnviaCorreo";
            this.btnEnviaCorreo.Size = new System.Drawing.Size(180, 34);
            this.btnEnviaCorreo.TabIndex = 77;
            this.btnEnviaCorreo.Text = "Envia Correo";
            this.btnEnviaCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviaCorreo.UseVisualStyleBackColor = false;
            this.btnEnviaCorreo.Click += new System.EventHandler(this.btnEnviaCorreo_Click_1);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(216, 76);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(331, 109);
            this.txtMensaje.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correo del Destinatario: *";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinatario.Location = new System.Drawing.Point(216, 24);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(331, 26);
            this.txtDestinatario.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Mensaje / Asunto: *";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtRemitente);
            this.groupBox3.Controls.Add(this.btnGuardarCredenCorreo);
            this.groupBox3.Controls.Add(this.txtContraseña);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(53, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 132);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Credenciales";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Clave de Aplicación: *";
            // 
            // txtRemitente
            // 
            this.txtRemitente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRemitente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemitente.Location = new System.Drawing.Point(216, 21);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(321, 26);
            this.txtRemitente.TabIndex = 3;
            // 
            // btnGuardarCredenCorreo
            // 
            this.btnGuardarCredenCorreo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarCredenCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCredenCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCredenCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCredenCorreo.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarCredenCorreo.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCredenCorreo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardarCredenCorreo.IconSize = 25;
            this.btnGuardarCredenCorreo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarCredenCorreo.Location = new System.Drawing.Point(574, 47);
            this.btnGuardarCredenCorreo.Name = "btnGuardarCredenCorreo";
            this.btnGuardarCredenCorreo.Size = new System.Drawing.Size(180, 34);
            this.btnGuardarCredenCorreo.TabIndex = 76;
            this.btnGuardarCredenCorreo.Text = "Guardar Cambios";
            this.btnGuardarCredenCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCredenCorreo.UseVisualStyleBackColor = false;
            this.btnGuardarCredenCorreo.Click += new System.EventHandler(this.btnGuardarCredenCorreo_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(216, 79);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(321, 26);
            this.txtContraseña.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Correo del Remitente: *";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbocajaopcionapertura);
            this.groupBox1.Controls.Add(this.btncajaopcionapertura);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 77);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // cbocajaopcionapertura
            // 
            this.cbocajaopcionapertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocajaopcionapertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocajaopcionapertura.FormattingEnabled = true;
            this.cbocajaopcionapertura.Location = new System.Drawing.Point(9, 39);
            this.cbocajaopcionapertura.Name = "cbocajaopcionapertura";
            this.cbocajaopcionapertura.Size = new System.Drawing.Size(165, 24);
            this.cbocajaopcionapertura.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Apertura Caja";
            // 
            // btncajaopcionapertura
            // 
            this.btncajaopcionapertura.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btncajaopcionapertura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncajaopcionapertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncajaopcionapertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncajaopcionapertura.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btncajaopcionapertura.IconColor = System.Drawing.Color.Black;
            this.btncajaopcionapertura.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncajaopcionapertura.IconSize = 1;
            this.btncajaopcionapertura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncajaopcionapertura.Location = new System.Drawing.Point(203, 40);
            this.btncajaopcionapertura.Name = "btncajaopcionapertura";
            this.btncajaopcionapertura.Size = new System.Drawing.Size(73, 24);
            this.btncajaopcionapertura.TabIndex = 98;
            this.btncajaopcionapertura.Text = "Guardar";
            this.btncajaopcionapertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncajaopcionapertura.UseVisualStyleBackColor = false;
            this.btncajaopcionapertura.Click += new System.EventHandler(this.btncajaopcionapertura_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iconButton3);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cbolistadoimpresoras);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(294, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 77);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impresiones";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 1;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton3.Location = new System.Drawing.Point(203, 40);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(73, 24);
            this.iconButton3.TabIndex = 101;
            this.iconButton3.Text = "Guardar";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Impresoras";
            // 
            // cbolistadoimpresoras
            // 
            this.cbolistadoimpresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbolistadoimpresoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbolistadoimpresoras.FormattingEnabled = true;
            this.cbolistadoimpresoras.Location = new System.Drawing.Point(9, 40);
            this.cbolistadoimpresoras.Name = "cbolistadoimpresoras";
            this.cbolistadoimpresoras.Size = new System.Drawing.Size(165, 24);
            this.cbolistadoimpresoras.TabIndex = 97;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtingresosbrutos);
            this.tabPage1.Controls.Add(this.txtcuit);
            this.tabPage1.Controls.Add(this.txttitular);
            this.tabPage1.Controls.Add(this.txtdireccion);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.txttelefono);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnsubir);
            this.tabPage1.Controls.Add(this.btnguardarcambios);
            this.tabPage1.Controls.Add(this.picLogo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos de Negocio";
            // 
            // txtingresosbrutos
            // 
            this.txtingresosbrutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtingresosbrutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtingresosbrutos.Location = new System.Drawing.Point(572, 256);
            this.txtingresosbrutos.Name = "txtingresosbrutos";
            this.txtingresosbrutos.Size = new System.Drawing.Size(236, 29);
            this.txtingresosbrutos.TabIndex = 81;
            // 
            // txtcuit
            // 
            this.txtcuit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuit.Location = new System.Drawing.Point(571, 186);
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(236, 29);
            this.txtcuit.TabIndex = 79;
            // 
            // txttitular
            // 
            this.txttitular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitular.Location = new System.Drawing.Point(570, 124);
            this.txttitular.Name = "txttitular";
            this.txttitular.Size = new System.Drawing.Size(236, 29);
            this.txttitular.TabIndex = 77;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(293, 256);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(238, 29);
            this.txtdireccion.TabIndex = 73;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(295, 124);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(237, 29);
            this.txtnombre.TabIndex = 71;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(295, 186);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(236, 29);
            this.txttelefono.TabIndex = 72;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(569, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "N° Ingreso Brutos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(568, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "C.U.I.T:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(567, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Titular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(293, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Nombre del Negocio: *";
            // 
            // btnsubir
            // 
            this.btnsubir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnsubir.IconColor = System.Drawing.Color.Black;
            this.btnsubir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnsubir.IconSize = 25;
            this.btnsubir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsubir.Location = new System.Drawing.Point(80, 321);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(182, 34);
            this.btnsubir.TabIndex = 68;
            this.btnsubir.Text = "Modificar";
            this.btnsubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsubir.UseVisualStyleBackColor = false;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnguardarcambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarcambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcambios.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnguardarcambios.IconColor = System.Drawing.Color.Black;
            this.btnguardarcambios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarcambios.IconSize = 25;
            this.btnguardarcambios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardarcambios.Location = new System.Drawing.Point(570, 321);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(235, 34);
            this.btnguardarcambios.TabIndex = 75;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarcambios.UseVisualStyleBackColor = false;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(80, 113);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(182, 172);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 66;
            this.picLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(292, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Telefono: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(292, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ubicación del Negocio: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Logo";
            // 
            // btnimpreguardar
            // 
            this.btnimpreguardar.Controls.Add(this.tabPage1);
            this.btnimpreguardar.Controls.Add(this.tabPage2);
            this.btnimpreguardar.Controls.Add(this.tabPage4);
            this.btnimpreguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimpreguardar.Location = new System.Drawing.Point(12, 12);
            this.btnimpreguardar.Name = "btnimpreguardar";
            this.btnimpreguardar.SelectedIndex = 0;
            this.btnimpreguardar.Size = new System.Drawing.Size(879, 395);
            this.btnimpreguardar.TabIndex = 77;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 411);
            this.Controls.Add(this.btnimpreguardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNegocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferencias del Negocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.btnimpreguardar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btnEnviaCorreo;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemitente;
        private FontAwesome.Sharp.IconButton btnGuardarCredenCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbocajaopcionapertura;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btncajaopcionapertura;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbolistadoimpresoras;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtingresosbrutos;
        private System.Windows.Forms.TextBox txtcuit;
        private System.Windows.Forms.TextBox txttitular;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnsubir;
        private FontAwesome.Sharp.IconButton btnguardarcambios;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl btnimpreguardar;
    }
}