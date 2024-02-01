
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuCatalogoProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGestionProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuUnidadesMedidas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSubCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.menuGestionUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPrecioIndividual = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPrecioMasivo = new FontAwesome.Sharp.IconMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.subMenuMargenesGanancias = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatalogoProductos,
            this.menuGestionUsuarios});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1184, 54);
            this.menu.TabIndex = 6;
            this.menu.Text = "menu";
            // 
            // menuCatalogoProductos
            // 
            this.menuCatalogoProductos.AutoSize = false;
            this.menuCatalogoProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuGestionProductos,
            this.subMenuUnidadesMedidas,
            this.subMenuCategorias,
            this.subMenuSubCategorias});
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
            this.subMenuGestionProductos.Size = new System.Drawing.Size(228, 22);
            this.subMenuGestionProductos.Text = "Gestionar Productos";
            this.subMenuGestionProductos.Click += new System.EventHandler(this.subMenuGestionProductos_Click);
            // 
            // subMenuUnidadesMedidas
            // 
            this.subMenuUnidadesMedidas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuUnidadesMedidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuUnidadesMedidas.IconColor = System.Drawing.Color.Black;
            this.subMenuUnidadesMedidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuUnidadesMedidas.Name = "subMenuUnidadesMedidas";
            this.subMenuUnidadesMedidas.Size = new System.Drawing.Size(228, 22);
            this.subMenuUnidadesMedidas.Text = "Unidades de Medidas";
            this.subMenuUnidadesMedidas.Click += new System.EventHandler(this.subMenuUnidadesMedidas_Click);
            // 
            // subMenuCategorias
            // 
            this.subMenuCategorias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategorias.IconColor = System.Drawing.Color.Black;
            this.subMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategorias.Name = "subMenuCategorias";
            this.subMenuCategorias.Size = new System.Drawing.Size(228, 22);
            this.subMenuCategorias.Text = "Gestionar Categorías ";
            this.subMenuCategorias.Click += new System.EventHandler(this.subMenuCategorias_Click);
            // 
            // subMenuSubCategorias
            // 
            this.subMenuSubCategorias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuSubCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSubCategorias.IconColor = System.Drawing.Color.Black;
            this.subMenuSubCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSubCategorias.Name = "subMenuSubCategorias";
            this.subMenuSubCategorias.Size = new System.Drawing.Size(228, 22);
            this.subMenuSubCategorias.Text = "Gestionar Sub Categorías ";
            this.subMenuSubCategorias.Click += new System.EventHandler(this.subMenuSubCategorias_Click);
            // 
            // menuGestionUsuarios
            // 
            this.menuGestionUsuarios.AutoSize = false;
            this.menuGestionUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuMargenesGanancias,
            this.subMenuPrecioIndividual,
            this.subMenuPrecioMasivo});
            this.menuGestionUsuarios.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            this.menuGestionUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuGestionUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuGestionUsuarios.IconSize = 35;
            this.menuGestionUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuGestionUsuarios.Name = "menuGestionUsuarios";
            this.menuGestionUsuarios.Size = new System.Drawing.Size(122, 50);
            this.menuGestionUsuarios.Text = "Precios";
            this.menuGestionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuPrecioIndividual
            // 
            this.subMenuPrecioIndividual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuPrecioIndividual.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPrecioIndividual.IconColor = System.Drawing.Color.Black;
            this.subMenuPrecioIndividual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPrecioIndividual.Name = "subMenuPrecioIndividual";
            this.subMenuPrecioIndividual.Size = new System.Drawing.Size(231, 22);
            this.subMenuPrecioIndividual.Text = "Cambiar PVP Individual";
            this.subMenuPrecioIndividual.Click += new System.EventHandler(this.subMenuPrecioIndividual_Click);
            // 
            // subMenuPrecioMasivo
            // 
            this.subMenuPrecioMasivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuPrecioMasivo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPrecioMasivo.IconColor = System.Drawing.Color.Black;
            this.subMenuPrecioMasivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPrecioMasivo.Name = "subMenuPrecioMasivo";
            this.subMenuPrecioMasivo.Size = new System.Drawing.Size(231, 22);
            this.subMenuPrecioMasivo.Text = "Cambiar PVP Masivamente";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 689);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 8;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 635);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // subMenuMargenesGanancias
            // 
            this.subMenuMargenesGanancias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuMargenesGanancias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuMargenesGanancias.IconColor = System.Drawing.Color.Black;
            this.subMenuMargenesGanancias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuMargenesGanancias.Name = "subMenuMargenesGanancias";
            this.subMenuMargenesGanancias.Size = new System.Drawing.Size(231, 22);
            this.subMenuMargenesGanancias.Text = "Margenes de Ganancias";
            this.subMenuMargenesGanancias.Click += new System.EventHandler(this.subMenuMargenesGanancias_Click);
            // 
            // frmInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.Name = "frmInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventarios_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem subMenuPrecioMasivo;
        private FontAwesome.Sharp.IconMenuItem subMenuPrecioIndividual;
        private FontAwesome.Sharp.IconMenuItem menuGestionUsuarios;
        private FontAwesome.Sharp.IconMenuItem subMenuUnidadesMedidas;
        private FontAwesome.Sharp.IconMenuItem subMenuGestionProductos;
        private FontAwesome.Sharp.IconMenuItem menuCatalogoProductos;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem subMenuCategorias;
        private FontAwesome.Sharp.IconMenuItem subMenuSubCategorias;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconMenuItem subMenuMargenesGanancias;
    }
}