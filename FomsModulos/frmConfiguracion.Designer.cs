
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
            this.menuDatosNegocio});
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
            this.subMenuDatosNegocio.Size = new System.Drawing.Size(182, 22);
            this.subMenuDatosNegocio.Text = "Datos de Negocio";
            this.subMenuDatosNegocio.Click += new System.EventHandler(this.subMenuDatosNegocio_Click);
            // 
            // subMenuSucursales
            // 
            this.subMenuSucursales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuSucursales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSucursales.IconColor = System.Drawing.Color.Black;
            this.subMenuSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSucursales.Name = "subMenuSucursales";
            this.subMenuSucursales.Size = new System.Drawing.Size(182, 22);
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
            this.subMenuResguardoDatos.Size = new System.Drawing.Size(182, 22);
            this.subMenuResguardoDatos.Text = "Resguardo Datos";
            this.subMenuResguardoDatos.Click += new System.EventHandler(this.subMenuResguardoDatos_Click);
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
    }
}