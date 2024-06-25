
namespace CapaPresentación.FomsModulos
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuDatosNegocio = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPuntoVenta = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuListaVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuCaja = new FontAwesome.Sharp.IconMenuItem();
            this.subAperturaCaja = new FontAwesome.Sharp.IconMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.subEstadoCaja = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.CadetBlue;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDatosNegocio,
            this.menuCaja});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1184, 45);
            this.menu.TabIndex = 6;
            this.menu.Text = "menu";
            // 
            // menuDatosNegocio
            // 
            this.menuDatosNegocio.AutoSize = false;
            this.menuDatosNegocio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuPuntoVenta,
            this.subMenuListaVenta});
            this.menuDatosNegocio.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menuDatosNegocio.IconColor = System.Drawing.Color.Black;
            this.menuDatosNegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuDatosNegocio.IconSize = 20;
            this.menuDatosNegocio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDatosNegocio.Name = "menuDatosNegocio";
            this.menuDatosNegocio.Size = new System.Drawing.Size(100, 40);
            this.menuDatosNegocio.Text = "Ventas";
            this.menuDatosNegocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuPuntoVenta
            // 
            this.subMenuPuntoVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuPuntoVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPuntoVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuPuntoVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPuntoVenta.Name = "subMenuPuntoVenta";
            this.subMenuPuntoVenta.Size = new System.Drawing.Size(180, 22);
            this.subMenuPuntoVenta.Text = "Punto de Ventas";
            this.subMenuPuntoVenta.Click += new System.EventHandler(this.subMenuPuntoVenta_Click);
            // 
            // subMenuListaVenta
            // 
            this.subMenuListaVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuListaVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuListaVenta.IconColor = System.Drawing.Color.Black;
            this.subMenuListaVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuListaVenta.Name = "subMenuListaVenta";
            this.subMenuListaVenta.Size = new System.Drawing.Size(180, 22);
            this.subMenuListaVenta.Text = "Lista de Ventas";
            this.subMenuListaVenta.Click += new System.EventHandler(this.subMenuListaVenta_Click);
            // 
            // menuCaja
            // 
            this.menuCaja.AutoSize = false;
            this.menuCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subAperturaCaja,
            this.subEstadoCaja});
            this.menuCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.menuCaja.IconColor = System.Drawing.Color.Black;
            this.menuCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCaja.IconSize = 20;
            this.menuCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCaja.Name = "menuCaja";
            this.menuCaja.Size = new System.Drawing.Size(100, 40);
            this.menuCaja.Text = "Caja";
            this.menuCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subAperturaCaja
            // 
            this.subAperturaCaja.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subAperturaCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subAperturaCaja.IconColor = System.Drawing.Color.Black;
            this.subAperturaCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subAperturaCaja.Name = "subAperturaCaja";
            this.subAperturaCaja.Size = new System.Drawing.Size(180, 22);
            this.subAperturaCaja.Text = "Apertura de Caja";
            this.subAperturaCaja.Click += new System.EventHandler(this.subAperturaCaja_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 689);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssHora
            // 
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(36, 17);
            this.tssHora.Text = "Hora:";
            // 
            // subEstadoCaja
            // 
            this.subEstadoCaja.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subEstadoCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subEstadoCaja.IconColor = System.Drawing.Color.Black;
            this.subEstadoCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subEstadoCaja.Name = "subEstadoCaja";
            this.subEstadoCaja.Size = new System.Drawing.Size(180, 22);
            this.subEstadoCaja.Text = "Estado de Caja";
            this.subEstadoCaja.Click += new System.EventHandler(this.subEstadoCaja_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuDatosNegocio;
        private FontAwesome.Sharp.IconMenuItem subMenuPuntoVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuListaVenta;
        private FontAwesome.Sharp.IconMenuItem menuCaja;
        private FontAwesome.Sharp.IconMenuItem subAperturaCaja;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private FontAwesome.Sharp.IconMenuItem subEstadoCaja;
    }
}