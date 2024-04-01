
namespace CapaPresentación.FomsModulos
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuOrdenCompra = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuListaCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
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
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 694);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(1186, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuOrdenCompra,
            this.subMenuListaCompra});
            this.menuCompras.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 20;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.menuCompras.Size = new System.Drawing.Size(122, 40);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuOrdenCompra
            // 
            this.subMenuOrdenCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuOrdenCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuOrdenCompra.IconColor = System.Drawing.Color.Black;
            this.subMenuOrdenCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuOrdenCompra.Name = "subMenuOrdenCompra";
            this.subMenuOrdenCompra.Size = new System.Drawing.Size(182, 22);
            this.subMenuOrdenCompra.Text = "Órden de Compra";
            this.subMenuOrdenCompra.Click += new System.EventHandler(this.subMenuOrdenCompra_Click);
            // 
            // subMenuListaCompra
            // 
            this.subMenuListaCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuListaCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuListaCompra.IconColor = System.Drawing.Color.Black;
            this.subMenuListaCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuListaCompra.Name = "subMenuListaCompra";
            this.subMenuListaCompra.Size = new System.Drawing.Size(182, 22);
            this.subMenuListaCompra.Text = "Lista de Compras";
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.DarkKhaki;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCompras});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1186, 45);
            this.menu.TabIndex = 7;
            this.menu.Text = "menu";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 716);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.StatusStrip statusStrip;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem subMenuOrdenCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuListaCompra;
        private System.Windows.Forms.MenuStrip menu;
    }
}