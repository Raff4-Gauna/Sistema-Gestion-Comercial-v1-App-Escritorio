
namespace CapaPresentación.FomsModulos
{
    partial class frmConfiguracion
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuDatosNegocio = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuDatosNegocio = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSucursales = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuResguardoDatos = new FontAwesome.Sharp.IconMenuItem();
            this.menuGestionUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.menuFiscalidad = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuTiposContribuyentes = new FontAwesome.Sharp.IconMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDatosNegocio,
            this.menuGestionUsuarios,
            this.menuFiscalidad});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1229, 54);
            this.menu.TabIndex = 4;
            this.menu.Text = "menu";
            // 
            // menuDatosNegocio
            // 
            this.menuDatosNegocio.AutoSize = false;
            this.menuDatosNegocio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDatosNegocio,
            this.subMenuSucursales,
            this.subMenuResguardoDatos});
            this.menuDatosNegocio.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menuDatosNegocio.IconColor = System.Drawing.Color.Black;
            this.menuDatosNegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuDatosNegocio.IconSize = 35;
            this.menuDatosNegocio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDatosNegocio.Name = "menuDatosNegocio";
            this.menuDatosNegocio.Size = new System.Drawing.Size(122, 50);
            this.menuDatosNegocio.Text = "Negocio";
            this.menuDatosNegocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuDatosNegocio
            // 
            this.subMenuDatosNegocio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuDatosNegocio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuDatosNegocio.IconColor = System.Drawing.Color.Black;
            this.subMenuDatosNegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuDatosNegocio.Name = "subMenuDatosNegocio";
            this.subMenuDatosNegocio.Size = new System.Drawing.Size(180, 22);
            this.subMenuDatosNegocio.Text = "Preferencias";
            this.subMenuDatosNegocio.Click += new System.EventHandler(this.subMenuDatosNegocio_Click);
            // 
            // subMenuSucursales
            // 
            this.subMenuSucursales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuSucursales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSucursales.IconColor = System.Drawing.Color.Black;
            this.subMenuSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSucursales.Name = "subMenuSucursales";
            this.subMenuSucursales.Size = new System.Drawing.Size(180, 22);
            this.subMenuSucursales.Text = "Sucursales";
            this.subMenuSucursales.Click += new System.EventHandler(this.subMenuSucursales_Click);
            // 
            // subMenuResguardoDatos
            // 
            this.subMenuResguardoDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuResguardoDatos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuResguardoDatos.IconColor = System.Drawing.Color.Black;
            this.subMenuResguardoDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuResguardoDatos.Name = "subMenuResguardoDatos";
            this.subMenuResguardoDatos.Size = new System.Drawing.Size(180, 22);
            this.subMenuResguardoDatos.Text = "Resguardo Datos";
            this.subMenuResguardoDatos.Click += new System.EventHandler(this.subMenuResguardoDatos_Click);
            // 
            // menuGestionUsuarios
            // 
            this.menuGestionUsuarios.AutoSize = false;
            this.menuGestionUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuUsuarios,
            this.iconMenuItem3});
            this.menuGestionUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuGestionUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuGestionUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuGestionUsuarios.IconSize = 35;
            this.menuGestionUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuGestionUsuarios.Name = "menuGestionUsuarios";
            this.menuGestionUsuarios.Size = new System.Drawing.Size(122, 50);
            this.menuGestionUsuarios.Text = "Gestión";
            this.menuGestionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuUsuarios
            // 
            this.subMenuUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuUsuarios.IconColor = System.Drawing.Color.Black;
            this.subMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuUsuarios.Name = "subMenuUsuarios";
            this.subMenuUsuarios.Size = new System.Drawing.Size(180, 22);
            this.subMenuUsuarios.Text = "Usuarios";
            this.subMenuUsuarios.Click += new System.EventHandler(this.subMenuUsuarios_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.iconMenuItem3.Text = "Roles y Permisos";
            // 
            // menuFiscalidad
            // 
            this.menuFiscalidad.AutoSize = false;
            this.menuFiscalidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuTiposContribuyentes});
            this.menuFiscalidad.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.menuFiscalidad.IconColor = System.Drawing.Color.Black;
            this.menuFiscalidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuFiscalidad.IconSize = 35;
            this.menuFiscalidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFiscalidad.Name = "menuFiscalidad";
            this.menuFiscalidad.Size = new System.Drawing.Size(122, 50);
            this.menuFiscalidad.Text = "Fiscalidad";
            this.menuFiscalidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuTiposContribuyentes
            // 
            this.subMenuTiposContribuyentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuTiposContribuyentes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuTiposContribuyentes.IconColor = System.Drawing.Color.Black;
            this.subMenuTiposContribuyentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuTiposContribuyentes.Name = "subMenuTiposContribuyentes";
            this.subMenuTiposContribuyentes.Size = new System.Drawing.Size(180, 22);
            this.subMenuTiposContribuyentes.Text = "Contribuyentes";
            this.subMenuTiposContribuyentes.Click += new System.EventHandler(this.subMenuTiposContribuyentes_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 632);
            this.panel1.TabIndex = 5;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 610);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1229, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssHora
            // 
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(36, 17);
            this.tssHora.Text = "Hora:";
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion del sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuDatosNegocio;
        private FontAwesome.Sharp.IconMenuItem subMenuDatosNegocio;
        private FontAwesome.Sharp.IconMenuItem subMenuSucursales;
        private FontAwesome.Sharp.IconMenuItem subMenuResguardoDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private FontAwesome.Sharp.IconMenuItem menuGestionUsuarios;
        private FontAwesome.Sharp.IconMenuItem subMenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem menuFiscalidad;
        private FontAwesome.Sharp.IconMenuItem subMenuTiposContribuyentes;
    }
}