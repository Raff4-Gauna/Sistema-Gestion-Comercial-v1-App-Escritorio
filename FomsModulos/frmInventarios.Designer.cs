
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
            this.menuParametros = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuMargenesGanancias = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuUnidadesMedidas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSubCategorias1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuCatalogoProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGestionProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuABMProductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuGestionUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPrecioIndividual = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPrecioMasivo = new FontAwesome.Sharp.IconMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.menuGestionUsuarios});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1184, 54);
            this.menu.TabIndex = 6;
            this.menu.Text = "menu";
            // 
            // menuParametros
            // 
            this.menuParametros.AutoSize = false;
            this.menuParametros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuMargenesGanancias,
            this.subMenuUnidadesMedidas,
            this.subMenuCategorias,
            this.subMenuSubCategorias1});
            this.menuParametros.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.menuParametros.IconColor = System.Drawing.Color.Black;
            this.menuParametros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuParametros.IconSize = 35;
            this.menuParametros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuParametros.Name = "menuParametros";
            this.menuParametros.Size = new System.Drawing.Size(122, 50);
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
            this.subMenuABMProductos});
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
            this.subMenuGestionProductos.Size = new System.Drawing.Size(180, 22);
            this.subMenuGestionProductos.Text = "Gestionar General";
            this.subMenuGestionProductos.Click += new System.EventHandler(this.subMenuGestionProductos_Click);
            // 
            // subMenuABMProductos
            // 
            this.subMenuABMProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuABMProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuABMProductos.IconColor = System.Drawing.Color.Black;
            this.subMenuABMProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuABMProductos.Name = "subMenuABMProductos";
            this.subMenuABMProductos.Size = new System.Drawing.Size(180, 22);
            this.subMenuABMProductos.Text = "ABM Productos";
            this.subMenuABMProductos.Click += new System.EventHandler(this.subMenuABMProductos_Click);
            // 
            // menuGestionUsuarios
            // 
            this.menuGestionUsuarios.AutoSize = false;
            this.menuGestionUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            // frmInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
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
    }
}