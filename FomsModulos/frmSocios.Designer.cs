
namespace CapaPresentación.FomsModulos
{
    partial class frmSocios
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
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGestionClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGestionProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuGestionClientes});
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 35;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(122, 50);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuGestionClientes
            // 
            this.subMenuGestionClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuGestionClientes.IconColor = System.Drawing.Color.Black;
            this.subMenuGestionClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuGestionClientes.Name = "subMenuGestionClientes";
            this.subMenuGestionClientes.Size = new System.Drawing.Size(180, 22);
            this.subMenuGestionClientes.Text = "Gestión de Clientes";
            this.subMenuGestionClientes.Click += new System.EventHandler(this.subMenuGestionClientes_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuProveedores});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1184, 57);
            this.menu.TabIndex = 17;
            this.menu.Text = "menuStrip1";
            // 
            // menuProveedores
            // 
            this.menuProveedores.AutoSize = false;
            this.menuProveedores.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuProveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuGestionProveedores});
            this.menuProveedores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckArrowRight;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuProveedores.IconSize = 35;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(122, 50);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuGestionProveedores
            // 
            this.subMenuGestionProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuGestionProveedores.IconColor = System.Drawing.Color.Black;
            this.subMenuGestionProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuGestionProveedores.Name = "subMenuGestionProveedores";
            this.subMenuGestionProveedores.Size = new System.Drawing.Size(198, 22);
            this.subMenuGestionProveedores.Text = "Gestión de Proveedores";
            this.subMenuGestionProveedores.Click += new System.EventHandler(this.subMenuGestionProveedores_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 689);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 19;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssHora
            // 
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(36, 17);
            this.tssHora.Text = "Hora:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 632);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.statusStrip);
            this.Name = "frmSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSocios_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem subMenuGestionClientes;
        private FontAwesome.Sharp.IconMenuItem subMenuGestionProveedores;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}