
namespace CapaPresentación.FomsModulos
{
    partial class frmInventarios
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
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuCatalogoProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGestionProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSucursales = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuResguardoDatos = new FontAwesome.Sharp.IconMenuItem();
            this.menuGestionUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.menuFiscalidad = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuParametrosFiscal = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuTiposContribuyentes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuTasaImpuestos = new FontAwesome.Sharp.IconMenuItem();
            this.menuFormasPagos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuMetodosPagos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuHistorialPagos = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tssHora
            // 
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(36, 17);
            this.tssHora.Text = "Hora:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 696);
            this.panel1.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 674);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1210, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatalogoProductos,
            this.menuGestionUsuarios,
            this.menuFiscalidad,
            this.menuFormasPagos});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1210, 54);
            this.menu.TabIndex = 6;
            this.menu.Text = "menu";
            // 
            // menuCatalogoProductos
            // 
            this.menuCatalogoProductos.AutoSize = false;
            this.menuCatalogoProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuGestionProductos,
            this.subMenuSucursales,
            this.subMenuResguardoDatos});
            this.menuCatalogoProductos.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.menuCatalogoProductos.IconColor = System.Drawing.Color.Black;
            this.menuCatalogoProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCatalogoProductos.IconSize = 35;
            this.menuCatalogoProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCatalogoProductos.Name = "menuCatalogoProductos";
            this.menuCatalogoProductos.Size = new System.Drawing.Size(122, 50);
            this.menuCatalogoProductos.Text = "Catálogo";
            this.menuCatalogoProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuGestionProductos
            // 
            this.subMenuGestionProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuGestionProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuGestionProductos.IconColor = System.Drawing.Color.Black;
            this.subMenuGestionProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuGestionProductos.Name = "subMenuGestionProductos";
            this.subMenuGestionProductos.Size = new System.Drawing.Size(201, 22);
            this.subMenuGestionProductos.Text = "Gestión de Productos";
            this.subMenuGestionProductos.Click += new System.EventHandler(this.subMenuGestionProductos_Click);
            // 
            // subMenuSucursales
            // 
            this.subMenuSucursales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuSucursales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSucursales.IconColor = System.Drawing.Color.Black;
            this.subMenuSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSucursales.Name = "subMenuSucursales";
            this.subMenuSucursales.Size = new System.Drawing.Size(201, 22);
            this.subMenuSucursales.Text = "Sucursales";
            // 
            // subMenuResguardoDatos
            // 
            this.subMenuResguardoDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuResguardoDatos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuResguardoDatos.IconColor = System.Drawing.Color.Black;
            this.subMenuResguardoDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuResguardoDatos.Name = "subMenuResguardoDatos";
            this.subMenuResguardoDatos.Size = new System.Drawing.Size(201, 22);
            this.subMenuResguardoDatos.Text = "Resguardo Datos";
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
            this.subMenuUsuarios.Size = new System.Drawing.Size(193, 22);
            this.subMenuUsuarios.Text = "Gestión de Usuarios";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(193, 22);
            this.iconMenuItem3.Text = "Roles y Permisos";
            // 
            // menuFiscalidad
            // 
            this.menuFiscalidad.AutoSize = false;
            this.menuFiscalidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuParametrosFiscal,
            this.subMenuTiposContribuyentes,
            this.subMenuTasaImpuestos});
            this.menuFiscalidad.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.menuFiscalidad.IconColor = System.Drawing.Color.Black;
            this.menuFiscalidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuFiscalidad.IconSize = 35;
            this.menuFiscalidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFiscalidad.Name = "menuFiscalidad";
            this.menuFiscalidad.Size = new System.Drawing.Size(122, 50);
            this.menuFiscalidad.Text = "Fiscalización";
            this.menuFiscalidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuParametrosFiscal
            // 
            this.subMenuParametrosFiscal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subMenuParametrosFiscal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuParametrosFiscal.IconColor = System.Drawing.Color.Black;
            this.subMenuParametrosFiscal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuParametrosFiscal.Name = "subMenuParametrosFiscal";
            this.subMenuParametrosFiscal.Size = new System.Drawing.Size(184, 22);
            this.subMenuParametrosFiscal.Text = "Parámetros Fiscal";
            // 
            // subMenuTiposContribuyentes
            // 
            this.subMenuTiposContribuyentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuTiposContribuyentes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuTiposContribuyentes.IconColor = System.Drawing.Color.Black;
            this.subMenuTiposContribuyentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuTiposContribuyentes.Name = "subMenuTiposContribuyentes";
            this.subMenuTiposContribuyentes.Size = new System.Drawing.Size(184, 22);
            this.subMenuTiposContribuyentes.Text = "Contribuyentes";
            // 
            // subMenuTasaImpuestos
            // 
            this.subMenuTasaImpuestos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subMenuTasaImpuestos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuTasaImpuestos.IconColor = System.Drawing.Color.Black;
            this.subMenuTasaImpuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuTasaImpuestos.Name = "subMenuTasaImpuestos";
            this.subMenuTasaImpuestos.Size = new System.Drawing.Size(184, 22);
            this.subMenuTasaImpuestos.Text = "Tasa de Impuestos";
            // 
            // menuFormasPagos
            // 
            this.menuFormasPagos.AutoSize = false;
            this.menuFormasPagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuMetodosPagos,
            this.subMenuHistorialPagos});
            this.menuFormasPagos.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.menuFormasPagos.IconColor = System.Drawing.Color.Black;
            this.menuFormasPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuFormasPagos.IconSize = 35;
            this.menuFormasPagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFormasPagos.Name = "menuFormasPagos";
            this.menuFormasPagos.Size = new System.Drawing.Size(122, 50);
            this.menuFormasPagos.Text = "Pagos";
            this.menuFormasPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuMetodosPagos
            // 
            this.subMenuMetodosPagos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subMenuMetodosPagos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuMetodosPagos.IconColor = System.Drawing.Color.Black;
            this.subMenuMetodosPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuMetodosPagos.Name = "subMenuMetodosPagos";
            this.subMenuMetodosPagos.Size = new System.Drawing.Size(187, 22);
            this.subMenuMetodosPagos.Text = "Metódos de Pagos";
            // 
            // subMenuHistorialPagos
            // 
            this.subMenuHistorialPagos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuHistorialPagos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuHistorialPagos.IconColor = System.Drawing.Color.Black;
            this.subMenuHistorialPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuHistorialPagos.Name = "subMenuHistorialPagos";
            this.subMenuHistorialPagos.Size = new System.Drawing.Size(187, 22);
            this.subMenuHistorialPagos.Text = "Historial de Pagos";
            // 
            // frmInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Name = "frmInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private FontAwesome.Sharp.IconMenuItem subMenuHistorialPagos;
        private FontAwesome.Sharp.IconMenuItem subMenuMetodosPagos;
        private FontAwesome.Sharp.IconMenuItem menuFormasPagos;
        private FontAwesome.Sharp.IconMenuItem subMenuTasaImpuestos;
        private FontAwesome.Sharp.IconMenuItem subMenuTiposContribuyentes;
        private FontAwesome.Sharp.IconMenuItem subMenuParametrosFiscal;
        private FontAwesome.Sharp.IconMenuItem menuFiscalidad;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem subMenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuGestionUsuarios;
        private FontAwesome.Sharp.IconMenuItem subMenuResguardoDatos;
        private FontAwesome.Sharp.IconMenuItem subMenuSucursales;
        private FontAwesome.Sharp.IconMenuItem subMenuGestionProductos;
        private FontAwesome.Sharp.IconMenuItem menuCatalogoProductos;
        private System.Windows.Forms.MenuStrip menu;
    }
}