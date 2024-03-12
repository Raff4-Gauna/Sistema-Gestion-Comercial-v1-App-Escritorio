
namespace CapaPresentación
{
    partial class frmModulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModulos));
            this.label1 = new System.Windows.Forms.Label();
            this.mdVentas = new FontAwesome.Sharp.IconButton();
            this.mdInventarios = new FontAwesome.Sharp.IconButton();
            this.mdSocios = new FontAwesome.Sharp.IconButton();
            this.mdConfiguracion = new FontAwesome.Sharp.IconButton();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mdCompras = new FontAwesome.Sharp.IconButton();
            this.mdReportes = new FontAwesome.Sharp.IconButton();
            this.mdLicencia = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 33);
            this.label1.TabIndex = 89;
            this.label1.Text = "Sistema de Gestión Comercial ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mdVentas
            // 
            this.mdVentas.BackColor = System.Drawing.Color.CadetBlue;
            this.mdVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdVentas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdVentas.ForeColor = System.Drawing.Color.Black;
            this.mdVentas.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.mdVentas.IconColor = System.Drawing.Color.Black;
            this.mdVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdVentas.IconSize = 27;
            this.mdVentas.Location = new System.Drawing.Point(344, 48);
            this.mdVentas.Name = "mdVentas";
            this.mdVentas.Size = new System.Drawing.Size(108, 58);
            this.mdVentas.TabIndex = 93;
            this.mdVentas.Text = "Ventas";
            this.mdVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdVentas.UseVisualStyleBackColor = false;
            this.mdVentas.Click += new System.EventHandler(this.mdVentas_Click);
            // 
            // mdInventarios
            // 
            this.mdInventarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mdInventarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdInventarios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdInventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdInventarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdInventarios.ForeColor = System.Drawing.Color.Black;
            this.mdInventarios.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.mdInventarios.IconColor = System.Drawing.Color.Black;
            this.mdInventarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdInventarios.IconSize = 27;
            this.mdInventarios.Location = new System.Drawing.Point(230, 48);
            this.mdInventarios.Name = "mdInventarios";
            this.mdInventarios.Size = new System.Drawing.Size(108, 58);
            this.mdInventarios.TabIndex = 92;
            this.mdInventarios.Text = "Inventarios";
            this.mdInventarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdInventarios.UseVisualStyleBackColor = false;
            this.mdInventarios.Click += new System.EventHandler(this.mdInventarios_Click);
            // 
            // mdSocios
            // 
            this.mdSocios.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mdSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdSocios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdSocios.ForeColor = System.Drawing.Color.Black;
            this.mdSocios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.mdSocios.IconColor = System.Drawing.Color.Black;
            this.mdSocios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdSocios.IconSize = 27;
            this.mdSocios.Location = new System.Drawing.Point(116, 48);
            this.mdSocios.Name = "mdSocios";
            this.mdSocios.Size = new System.Drawing.Size(108, 58);
            this.mdSocios.TabIndex = 91;
            this.mdSocios.Text = "Socios";
            this.mdSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdSocios.UseVisualStyleBackColor = false;
            this.mdSocios.Click += new System.EventHandler(this.mdSocios_Click);
            // 
            // mdConfiguracion
            // 
            this.mdConfiguracion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mdConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdConfiguracion.ForeColor = System.Drawing.Color.Black;
            this.mdConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.mdConfiguracion.IconColor = System.Drawing.Color.Black;
            this.mdConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdConfiguracion.IconSize = 27;
            this.mdConfiguracion.Location = new System.Drawing.Point(2, 48);
            this.mdConfiguracion.Name = "mdConfiguracion";
            this.mdConfiguracion.Size = new System.Drawing.Size(108, 58);
            this.mdConfiguracion.TabIndex = 88;
            this.mdConfiguracion.Text = "Configuración";
            this.mdConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdConfiguracion.UseVisualStyleBackColor = false;
            this.mdConfiguracion.Click += new System.EventHandler(this.mdConfiguracion_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(74, 4);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(61, 13);
            this.lblusuario.TabIndex = 95;
            this.lblusuario.Text = "lblusuario";
            this.lblusuario.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // mdCompras
            // 
            this.mdCompras.BackColor = System.Drawing.Color.DarkKhaki;
            this.mdCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdCompras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdCompras.ForeColor = System.Drawing.Color.Black;
            this.mdCompras.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.mdCompras.IconColor = System.Drawing.Color.Black;
            this.mdCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdCompras.IconSize = 27;
            this.mdCompras.Location = new System.Drawing.Point(458, 48);
            this.mdCompras.Name = "mdCompras";
            this.mdCompras.Size = new System.Drawing.Size(108, 58);
            this.mdCompras.TabIndex = 97;
            this.mdCompras.Text = "Compras";
            this.mdCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdCompras.UseVisualStyleBackColor = false;
            this.mdCompras.Click += new System.EventHandler(this.mdCompras_Click);
            // 
            // mdReportes
            // 
            this.mdReportes.BackColor = System.Drawing.Color.DarkSalmon;
            this.mdReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdReportes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdReportes.ForeColor = System.Drawing.Color.Black;
            this.mdReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.mdReportes.IconColor = System.Drawing.Color.Black;
            this.mdReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdReportes.IconSize = 27;
            this.mdReportes.Location = new System.Drawing.Point(572, 48);
            this.mdReportes.Name = "mdReportes";
            this.mdReportes.Size = new System.Drawing.Size(108, 58);
            this.mdReportes.TabIndex = 98;
            this.mdReportes.Text = "Reportes";
            this.mdReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdReportes.UseVisualStyleBackColor = false;
            this.mdReportes.Click += new System.EventHandler(this.mdReportes_Click);
            // 
            // mdLicencia
            // 
            this.mdLicencia.BackColor = System.Drawing.Color.LightSlateGray;
            this.mdLicencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdLicencia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdLicencia.ForeColor = System.Drawing.Color.Black;
            this.mdLicencia.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.mdLicencia.IconColor = System.Drawing.Color.Black;
            this.mdLicencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdLicencia.IconSize = 27;
            this.mdLicencia.Location = new System.Drawing.Point(686, 48);
            this.mdLicencia.Name = "mdLicencia";
            this.mdLicencia.Size = new System.Drawing.Size(108, 58);
            this.mdLicencia.TabIndex = 99;
            this.mdLicencia.Text = "Licencia";
            this.mdLicencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdLicencia.UseVisualStyleBackColor = false;
            this.mdLicencia.Click += new System.EventHandler(this.mdLicencia_Click);
            // 
            // frmModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 111);
            this.Controls.Add(this.mdLicencia);
            this.Controls.Add(this.mdReportes);
            this.Controls.Add(this.mdCompras);
            this.Controls.Add(this.mdConfiguracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mdSocios);
            this.Controls.Add(this.mdInventarios);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.mdVentas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmModulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos";
            this.Load += new System.EventHandler(this.frmModulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconButton mdConfiguracion;
        public FontAwesome.Sharp.IconButton mdSocios;
        public FontAwesome.Sharp.IconButton mdInventarios;
        public FontAwesome.Sharp.IconButton mdVentas;
        public FontAwesome.Sharp.IconButton mdCompras;
        public FontAwesome.Sharp.IconButton mdReportes;
        public FontAwesome.Sharp.IconButton mdLicencia;
    }
}