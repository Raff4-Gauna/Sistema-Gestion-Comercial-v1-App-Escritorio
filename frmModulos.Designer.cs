
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
            this.label1 = new System.Windows.Forms.Label();
            this.mdVentas = new FontAwesome.Sharp.IconButton();
            this.mdInventarios = new FontAwesome.Sharp.IconButton();
            this.mdSocios = new FontAwesome.Sharp.IconButton();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.mdConfiguracion = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 34);
            this.label1.TabIndex = 89;
            this.label1.Text = "Sistema de Gestión Comercial ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mdVentas
            // 
            this.mdVentas.BackColor = System.Drawing.Color.CadetBlue;
            this.mdVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdVentas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdVentas.ForeColor = System.Drawing.Color.Black;
            this.mdVentas.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.mdVentas.IconColor = System.Drawing.Color.Black;
            this.mdVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdVentas.IconSize = 30;
            this.mdVentas.Location = new System.Drawing.Point(483, 3);
            this.mdVentas.Name = "mdVentas";
            this.mdVentas.Size = new System.Drawing.Size(154, 66);
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
            this.mdInventarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdInventarios.ForeColor = System.Drawing.Color.Black;
            this.mdInventarios.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.mdInventarios.IconColor = System.Drawing.Color.Black;
            this.mdInventarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdInventarios.IconSize = 30;
            this.mdInventarios.Location = new System.Drawing.Point(323, 3);
            this.mdInventarios.Name = "mdInventarios";
            this.mdInventarios.Size = new System.Drawing.Size(154, 66);
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
            this.mdSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdSocios.ForeColor = System.Drawing.Color.Black;
            this.mdSocios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.mdSocios.IconColor = System.Drawing.Color.Black;
            this.mdSocios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdSocios.IconSize = 30;
            this.mdSocios.Location = new System.Drawing.Point(163, 3);
            this.mdSocios.Name = "mdSocios";
            this.mdSocios.Size = new System.Drawing.Size(154, 66);
            this.mdSocios.TabIndex = 91;
            this.mdSocios.Text = "Socios";
            this.mdSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdSocios.UseVisualStyleBackColor = false;
            this.mdSocios.Click += new System.EventHandler(this.mdSocios_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 40;
            this.btnsalir.Location = new System.Drawing.Point(585, 122);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(71, 36);
            this.btnsalir.TabIndex = 90;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // mdConfiguracion
            // 
            this.mdConfiguracion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mdConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mdConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mdConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdConfiguracion.ForeColor = System.Drawing.Color.Black;
            this.mdConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.mdConfiguracion.IconColor = System.Drawing.Color.Black;
            this.mdConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mdConfiguracion.IconSize = 30;
            this.mdConfiguracion.Location = new System.Drawing.Point(3, 3);
            this.mdConfiguracion.Name = "mdConfiguracion";
            this.mdConfiguracion.Size = new System.Drawing.Size(154, 66);
            this.mdConfiguracion.TabIndex = 88;
            this.mdConfiguracion.Text = "Configuraciónes";
            this.mdConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mdConfiguracion.UseVisualStyleBackColor = false;
            this.mdConfiguracion.Click += new System.EventHandler(this.mdConfiguracion_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.mdConfiguracion);
            this.flowLayoutPanel1.Controls.Add(this.mdSocios);
            this.flowLayoutPanel1.Controls.Add(this.mdInventarios);
            this.flowLayoutPanel1.Controls.Add(this.mdVentas);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 75);
            this.flowLayoutPanel1.TabIndex = 94;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(111, 128);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(128, 29);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 96;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // frmModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmModulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos";
            this.Load += new System.EventHandler(this.frmModulos_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton mdConfiguracion;
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton mdSocios;
        private FontAwesome.Sharp.IconButton mdInventarios;
        private FontAwesome.Sharp.IconButton mdVentas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label2;
    }
}