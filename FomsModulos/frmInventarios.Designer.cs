
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarios));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuParametros = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuMargenesGanancias = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.subMenuUnidadesMedidas = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.subMenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSubCategorias1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuCatalogoProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGestionProductos = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.subMenuABMProductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuGestionUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPrecioIndividual = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.subMenuPrecioMasivo = new FontAwesome.Sharp.IconMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCotización = new FontAwesome.Sharp.IconMenuItem();
            this.iconValorDolarActual = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuParametros,
            this.menuCatalogoProductos,
            this.menuGestionUsuarios,
            this.btnCotización});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1184, 45);
            this.menu.TabIndex = 6;
            this.menu.Text = "menu";
            // 
            // menuParametros
            // 
            this.menuParametros.AutoSize = false;
            this.menuParametros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuMargenesGanancias,
            this.toolStripSeparator2,
            this.subMenuUnidadesMedidas,
            this.toolStripSeparator1,
            this.subMenuCategorias,
            this.subMenuSubCategorias1});
            this.menuParametros.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuParametros.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.menuParametros.IconColor = System.Drawing.Color.Black;
            this.menuParametros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuParametros.IconSize = 20;
            this.menuParametros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuParametros.Name = "menuParametros";
            this.menuParametros.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.menuParametros.Size = new System.Drawing.Size(100, 40);
            this.menuParametros.Text = "Parámetros";
            this.menuParametros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuMargenesGanancias
            // 
            this.subMenuMargenesGanancias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuMargenesGanancias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuMargenesGanancias.IconColor = System.Drawing.Color.Black;
            this.subMenuMargenesGanancias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuMargenesGanancias.Name = "subMenuMargenesGanancias";
            this.subMenuMargenesGanancias.Size = new System.Drawing.Size(216, 22);
            this.subMenuMargenesGanancias.Text = "Margenes de Ganancias";
            this.subMenuMargenesGanancias.Click += new System.EventHandler(this.subMenuMargenesGanancias_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // subMenuUnidadesMedidas
            // 
            this.subMenuUnidadesMedidas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuUnidadesMedidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuUnidadesMedidas.IconColor = System.Drawing.Color.Black;
            this.subMenuUnidadesMedidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuUnidadesMedidas.Name = "subMenuUnidadesMedidas";
            this.subMenuUnidadesMedidas.Size = new System.Drawing.Size(216, 22);
            this.subMenuUnidadesMedidas.Text = "Unidades de Medidas";
            this.subMenuUnidadesMedidas.Click += new System.EventHandler(this.subMenuUnidadesMedidas_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // subMenuCategorias
            // 
            this.subMenuCategorias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategorias.IconColor = System.Drawing.Color.Black;
            this.subMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategorias.Name = "subMenuCategorias";
            this.subMenuCategorias.Size = new System.Drawing.Size(216, 22);
            this.subMenuCategorias.Text = "ABM Categorías ";
            this.subMenuCategorias.Click += new System.EventHandler(this.subMenuCategorias_Click_1);
            // 
            // subMenuSubCategorias1
            // 
            this.subMenuSubCategorias1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuSubCategorias1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSubCategorias1.IconColor = System.Drawing.Color.Black;
            this.subMenuSubCategorias1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSubCategorias1.Name = "subMenuSubCategorias1";
            this.subMenuSubCategorias1.Size = new System.Drawing.Size(216, 22);
            this.subMenuSubCategorias1.Text = "ABM SubCategorías";
            this.subMenuSubCategorias1.Click += new System.EventHandler(this.subMenuSubCategorias1_Click);
            // 
            // menuCatalogoProductos
            // 
            this.menuCatalogoProductos.AutoSize = false;
            this.menuCatalogoProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuGestionProductos,
            this.toolStripSeparator3,
            this.subMenuABMProductos});
            this.menuCatalogoProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.menuCatalogoProductos.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.menuCatalogoProductos.IconColor = System.Drawing.Color.Black;
            this.menuCatalogoProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCatalogoProductos.IconSize = 20;
            this.menuCatalogoProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCatalogoProductos.Name = "menuCatalogoProductos";
            this.menuCatalogoProductos.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.menuCatalogoProductos.Size = new System.Drawing.Size(100, 40);
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
            this.subMenuGestionProductos.Size = new System.Drawing.Size(182, 22);
            this.subMenuGestionProductos.Text = "Gestión Productos";
            this.subMenuGestionProductos.Click += new System.EventHandler(this.subMenuGestionProductos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // subMenuABMProductos
            // 
            this.subMenuABMProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuABMProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuABMProductos.IconColor = System.Drawing.Color.Black;
            this.subMenuABMProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuABMProductos.Name = "subMenuABMProductos";
            this.subMenuABMProductos.Size = new System.Drawing.Size(182, 22);
            this.subMenuABMProductos.Text = "ABM Productos";
            this.subMenuABMProductos.Click += new System.EventHandler(this.subMenuABMProductos_Click);
            // 
            // menuGestionUsuarios
            // 
            this.menuGestionUsuarios.AutoSize = false;
            this.menuGestionUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuPrecioIndividual,
            this.toolStripSeparator4,
            this.subMenuPrecioMasivo});
            this.menuGestionUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.menuGestionUsuarios.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            this.menuGestionUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuGestionUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuGestionUsuarios.IconSize = 20;
            this.menuGestionUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuGestionUsuarios.Name = "menuGestionUsuarios";
            this.menuGestionUsuarios.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.menuGestionUsuarios.Size = new System.Drawing.Size(100, 40);
            this.menuGestionUsuarios.Text = "Comercio";
            this.menuGestionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuPrecioIndividual
            // 
            this.subMenuPrecioIndividual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuPrecioIndividual.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPrecioIndividual.IconColor = System.Drawing.Color.Black;
            this.subMenuPrecioIndividual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPrecioIndividual.Name = "subMenuPrecioIndividual";
            this.subMenuPrecioIndividual.Size = new System.Drawing.Size(226, 22);
            this.subMenuPrecioIndividual.Text = "Act  Stock / PVP Individual";
            this.subMenuPrecioIndividual.Click += new System.EventHandler(this.subMenuPrecioIndividual_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(223, 6);
            // 
            // subMenuPrecioMasivo
            // 
            this.subMenuPrecioMasivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuPrecioMasivo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPrecioMasivo.IconColor = System.Drawing.Color.Black;
            this.subMenuPrecioMasivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPrecioMasivo.Name = "subMenuPrecioMasivo";
            this.subMenuPrecioMasivo.Size = new System.Drawing.Size(226, 22);
            this.subMenuPrecioMasivo.Text = "Act PVP Masivamente";
            this.subMenuPrecioMasivo.Click += new System.EventHandler(this.subMenuPrecioMasivo_Click);
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
            // btnCotización
            // 
            this.btnCotización.AutoSize = false;
            this.btnCotización.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconValorDolarActual,
            this.toolStripSeparator5});
            this.btnCotización.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCotización.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnCotización.IconColor = System.Drawing.Color.Black;
            this.btnCotización.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCotización.IconSize = 20;
            this.btnCotización.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCotización.Name = "btnCotización";
            this.btnCotización.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnCotización.Size = new System.Drawing.Size(100, 40);
            this.btnCotización.Text = "Cotización";
            this.btnCotización.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconValorDolarActual
            // 
            this.iconValorDolarActual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconValorDolarActual.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconValorDolarActual.IconColor = System.Drawing.Color.Black;
            this.iconValorDolarActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconValorDolarActual.Name = "iconValorDolarActual";
            this.iconValorDolarActual.Size = new System.Drawing.Size(180, 22);
            this.iconValorDolarActual.Text = "Valor Dolar Actual";
            this.iconValorDolarActual.Click += new System.EventHandler(this.iconValorDolarActual_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // frmInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
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
        private FontAwesome.Sharp.IconMenuItem subMenuGestionProductos;
        private FontAwesome.Sharp.IconMenuItem menuCatalogoProductos;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private FontAwesome.Sharp.IconMenuItem menuParametros;
        private FontAwesome.Sharp.IconMenuItem subMenuMargenesGanancias;
        private FontAwesome.Sharp.IconMenuItem subMenuUnidadesMedidas;
        private FontAwesome.Sharp.IconMenuItem subMenuCategorias;
        private FontAwesome.Sharp.IconMenuItem subMenuSubCategorias1;
        private FontAwesome.Sharp.IconMenuItem subMenuABMProductos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private FontAwesome.Sharp.IconMenuItem btnCotización;
        private FontAwesome.Sharp.IconMenuItem iconValorDolarActual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}