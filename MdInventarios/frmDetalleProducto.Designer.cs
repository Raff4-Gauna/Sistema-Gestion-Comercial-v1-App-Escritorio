
namespace CapaPresentación.MdInventarios
{
    partial class frmDetalleProducto
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcodigobarra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregarImg = new FontAwesome.Sharp.IconButton();
            this.picImgProducto = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtpreciofinal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtstockexistente = new System.Windows.Forms.TextBox();
            this.txtstockminimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdescripciongeneral = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(249, 31);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(136, 24);
            this.txtcodigo.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(246, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 128;
            this.label13.Text = "Código: *";
            // 
            // txtcodigobarra
            // 
            this.txtcodigobarra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcodigobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigobarra.Location = new System.Drawing.Point(6, 32);
            this.txtcodigobarra.Name = "txtcodigobarra";
            this.txtcodigobarra.Size = new System.Drawing.Size(237, 24);
            this.txtcodigobarra.TabIndex = 127;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 15);
            this.label10.TabIndex = 126;
            this.label10.Text = "Código de Barra: *";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 360);
            this.tabControl1.TabIndex = 130;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnAgregarImg);
            this.tabPage1.Controls.Add(this.picImgProducto);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImg.IconChar = FontAwesome.Sharp.IconChar.CameraRetro;
            this.btnAgregarImg.IconColor = System.Drawing.Color.Black;
            this.btnAgregarImg.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarImg.IconSize = 25;
            this.btnAgregarImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarImg.Location = new System.Drawing.Point(540, 184);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(182, 34);
            this.btnAgregarImg.TabIndex = 148;
            this.btnAgregarImg.Text = "Agregar";
            this.btnAgregarImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarImg.UseVisualStyleBackColor = false;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // picImgProducto
            // 
            this.picImgProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImgProducto.Location = new System.Drawing.Point(540, 6);
            this.picImgProducto.Name = "picImgProducto";
            this.picImgProducto.Size = new System.Drawing.Size(182, 172);
            this.picImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImgProducto.TabIndex = 147;
            this.picImgProducto.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtpreciofinal);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtpreciocompra);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(6, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 86);
            this.groupBox4.TabIndex = 140;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cotización";
            // 
            // txtpreciofinal
            // 
            this.txtpreciofinal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtpreciofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciofinal.Location = new System.Drawing.Point(220, 32);
            this.txtpreciofinal.Multiline = true;
            this.txtpreciofinal.Name = "txtpreciofinal";
            this.txtpreciofinal.Size = new System.Drawing.Size(235, 44);
            this.txtpreciofinal.TabIndex = 229;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(217, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 13);
            this.label20.TabIndex = 228;
            this.label20.Text = "Precio Final Consumidor *";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtpreciocompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreciocompra.Location = new System.Drawing.Point(7, 32);
            this.txtpreciocompra.Multiline = true;
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(207, 44);
            this.txtpreciocompra.TabIndex = 226;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(4, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 13);
            this.label22.TabIndex = 225;
            this.label22.Text = "Precio de Compra *";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtstockexistente);
            this.groupBox3.Controls.Add(this.txtstockminimo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(6, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 70);
            this.groupBox3.TabIndex = 139;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventario";
            // 
            // txtstockexistente
            // 
            this.txtstockexistente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstockexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockexistente.Location = new System.Drawing.Point(7, 32);
            this.txtstockexistente.Name = "txtstockexistente";
            this.txtstockexistente.Size = new System.Drawing.Size(182, 29);
            this.txtstockexistente.TabIndex = 136;
            // 
            // txtstockminimo
            // 
            this.txtstockminimo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstockminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockminimo.Location = new System.Drawing.Point(195, 32);
            this.txtstockminimo.Name = "txtstockminimo";
            this.txtstockminimo.Size = new System.Drawing.Size(181, 29);
            this.txtstockminimo.TabIndex = 138;
            this.txtstockminimo.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(193, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 137;
            this.label5.Text = "Stock Mínimo: *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 135;
            this.label15.Text = "Stock Existente: *";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdescripciongeneral);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 66);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // txtdescripciongeneral
            // 
            this.txtdescripciongeneral.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtdescripciongeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripciongeneral.Location = new System.Drawing.Point(6, 31);
            this.txtdescripciongeneral.Name = "txtdescripciongeneral";
            this.txtdescripciongeneral.Size = new System.Drawing.Size(386, 24);
            this.txtdescripciongeneral.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Descripción General: *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtcodigobarra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 63);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cod Productos";
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
            this.btnguardar.Location = new System.Drawing.Point(180, 375);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(165, 30);
            this.btnguardar.TabIndex = 166;
            this.btnguardar.Text = "Grabar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 16;
            this.btneliminar.Location = new System.Drawing.Point(351, 375);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(165, 30);
            this.btneliminar.TabIndex = 168;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(624, 385);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(26, 20);
            this.txtindice.TabIndex = 171;
            this.txtindice.Text = "-1";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(656, 385);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 170;
            this.txtid.Text = "0";
            // 
            // frmDetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(735, 417);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Producto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImgProducto)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtcodigobarra;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txtdescripciongeneral;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtstockexistente;
        public System.Windows.Forms.TextBox txtstockminimo;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label15;
        public FontAwesome.Sharp.IconButton btnguardar;
        public FontAwesome.Sharp.IconButton btneliminar;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txtpreciocompra;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtpreciofinal;
        public System.Windows.Forms.Label label20;
        public FontAwesome.Sharp.IconButton btnAgregarImg;
        public System.Windows.Forms.PictureBox picImgProducto;
        public System.Windows.Forms.TextBox txtindice;
        public System.Windows.Forms.TextBox txtid;
    }
}