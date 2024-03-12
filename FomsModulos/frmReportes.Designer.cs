
namespace CapaPresentación.FomsModulos
{
    partial class frmReportes
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
            this.subMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVentasRealizada = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuComprasProd = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuComprasProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVentasClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuSocios = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuStock = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuMovimientoStock = new FontAwesome.Sharp.IconMenuItem();
            this.menuInventario = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuListaProductos = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProductoMasVend = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuPrecios = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCompUtlPrecios = new FontAwesome.Sharp.IconMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.subMenuNivelStockCritico = new FontAwesome.Sharp.IconMenuItem();
            this.menuInformes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuInformes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGanancias = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuGananciasPorVentas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVentasPorUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCaja = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuAperCaja = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCierreCaja = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuComprasRealizadas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuListaClientes = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuListaProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuEstadoCajaVendedor = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuVentasPorProd = new FontAwesome.Sharp.IconMenuItem();
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
            // subMenuVentas
            // 
            this.subMenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuVentasRealizada,
            this.subMenuVentasPorUsuario,
            this.subMenuVentasPorProd});
            this.subMenuVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subMenuVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVentas.IconColor = System.Drawing.Color.Black;
            this.subMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVentas.Name = "subMenuVentas";
            this.subMenuVentas.Size = new System.Drawing.Size(180, 22);
            this.subMenuVentas.Text = "Ventas";
            // 
            // subMenuVentasRealizada
            // 
            this.subMenuVentasRealizada.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVentasRealizada.IconColor = System.Drawing.Color.Black;
            this.subMenuVentasRealizada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVentasRealizada.Name = "subMenuVentasRealizada";
            this.subMenuVentasRealizada.Size = new System.Drawing.Size(202, 22);
            this.subMenuVentasRealizada.Text = "Ventas Realizadas";
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuVentas,
            this.subMenuCaja});
            this.menuVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 20;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(100, 40);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCompras
            // 
            this.subMenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuComprasRealizadas,
            this.subMenuComprasProd});
            this.subMenuCompras.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subMenuCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCompras.IconColor = System.Drawing.Color.Black;
            this.subMenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCompras.Name = "subMenuCompras";
            this.subMenuCompras.Size = new System.Drawing.Size(180, 22);
            this.subMenuCompras.Text = "Compras";
            // 
            // subMenuComprasProd
            // 
            this.subMenuComprasProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuComprasProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuComprasProd.IconColor = System.Drawing.Color.Black;
            this.subMenuComprasProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuComprasProd.Name = "subMenuComprasProd";
            this.subMenuComprasProd.Size = new System.Drawing.Size(201, 22);
            this.subMenuComprasProd.Text = "Compras por Productos";
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCompras});
            this.menuCompras.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 20;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(122, 40);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuProveedores
            // 
            this.subMenuProveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuListaProveedores,
            this.subMenuComprasProveedores});
            this.subMenuProveedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProveedores.IconColor = System.Drawing.Color.Black;
            this.subMenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProveedores.Name = "subMenuProveedores";
            this.subMenuProveedores.Size = new System.Drawing.Size(180, 22);
            this.subMenuProveedores.Text = "Proveedores";
            // 
            // subMenuComprasProveedores
            // 
            this.subMenuComprasProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuComprasProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuComprasProveedores.IconColor = System.Drawing.Color.Black;
            this.subMenuComprasProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuComprasProveedores.Name = "subMenuComprasProveedores";
            this.subMenuComprasProveedores.Size = new System.Drawing.Size(203, 22);
            this.subMenuComprasProveedores.Text = " Compras a Proveedores";
            // 
            // subMenuClientes
            // 
            this.subMenuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuListaClientes,
            this.subMenuVentasClientes});
            this.subMenuClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuClientes.IconColor = System.Drawing.Color.Black;
            this.subMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuClientes.Name = "subMenuClientes";
            this.subMenuClientes.Size = new System.Drawing.Size(180, 22);
            this.subMenuClientes.Text = "Clientes";
            // 
            // subMenuVentasClientes
            // 
            this.subMenuVentasClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuVentasClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVentasClientes.IconColor = System.Drawing.Color.Black;
            this.subMenuVentasClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVentasClientes.Name = "subMenuVentasClientes";
            this.subMenuVentasClientes.Size = new System.Drawing.Size(180, 22);
            this.subMenuVentasClientes.Text = "Ventas a Clientes";
            // 
            // menuSocios
            // 
            this.menuSocios.AutoSize = false;
            this.menuSocios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuClientes,
            this.subMenuProveedores});
            this.menuSocios.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSocios.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.menuSocios.IconColor = System.Drawing.Color.Black;
            this.menuSocios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuSocios.IconSize = 20;
            this.menuSocios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSocios.Name = "menuSocios";
            this.menuSocios.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.menuSocios.Size = new System.Drawing.Size(100, 40);
            this.menuSocios.Text = "Socios";
            this.menuSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuStock
            // 
            this.subMenuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuMovimientoStock,
            this.subMenuNivelStockCritico});
            this.subMenuStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuStock.IconColor = System.Drawing.Color.Black;
            this.subMenuStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuStock.Name = "subMenuStock";
            this.subMenuStock.Size = new System.Drawing.Size(180, 22);
            this.subMenuStock.Text = "Stock";
            // 
            // subMenuMovimientoStock
            // 
            this.subMenuMovimientoStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuMovimientoStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuMovimientoStock.IconColor = System.Drawing.Color.Black;
            this.subMenuMovimientoStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuMovimientoStock.Name = "subMenuMovimientoStock";
            this.subMenuMovimientoStock.Size = new System.Drawing.Size(204, 22);
            this.subMenuMovimientoStock.Text = "Movimiento de Stock";
            // 
            // menuInventario
            // 
            this.menuInventario.AutoSize = false;
            this.menuInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuProductos,
            this.subMenuStock,
            this.subMenuPrecios});
            this.menuInventario.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInventario.IconChar = FontAwesome.Sharp.IconChar.ShopLock;
            this.menuInventario.IconColor = System.Drawing.Color.Black;
            this.menuInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInventario.IconSize = 20;
            this.menuInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.menuInventario.Size = new System.Drawing.Size(100, 40);
            this.menuInventario.Text = "Inventario";
            this.menuInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuProductos
            // 
            this.subMenuProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuListaProductos,
            this.subMenuProductoMasVend});
            this.subMenuProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProductos.IconColor = System.Drawing.Color.Black;
            this.subMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProductos.Name = "subMenuProductos";
            this.subMenuProductos.Size = new System.Drawing.Size(180, 22);
            this.subMenuProductos.Text = "Productos";
            // 
            // subMenuListaProductos
            // 
            this.subMenuListaProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuListaProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuListaProductos.IconColor = System.Drawing.Color.Black;
            this.subMenuListaProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuListaProductos.Name = "subMenuListaProductos";
            this.subMenuListaProductos.Size = new System.Drawing.Size(205, 22);
            this.subMenuListaProductos.Text = "Lista de Productos";
            // 
            // subMenuProductoMasVend
            // 
            this.subMenuProductoMasVend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuProductoMasVend.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProductoMasVend.IconColor = System.Drawing.Color.Black;
            this.subMenuProductoMasVend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProductoMasVend.Name = "subMenuProductoMasVend";
            this.subMenuProductoMasVend.Size = new System.Drawing.Size(205, 22);
            this.subMenuProductoMasVend.Text = "Productos Más Vendidos";
            // 
            // subMenuPrecios
            // 
            this.subMenuPrecios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCompUtlPrecios});
            this.subMenuPrecios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuPrecios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuPrecios.IconColor = System.Drawing.Color.Black;
            this.subMenuPrecios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuPrecios.Name = "subMenuPrecios";
            this.subMenuPrecios.Size = new System.Drawing.Size(180, 22);
            this.subMenuPrecios.Text = "Precios";
            // 
            // subMenuCompUtlPrecios
            // 
            this.subMenuCompUtlPrecios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuCompUtlPrecios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCompUtlPrecios.IconColor = System.Drawing.Color.Black;
            this.subMenuCompUtlPrecios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCompUtlPrecios.Name = "subMenuCompUtlPrecios";
            this.subMenuCompUtlPrecios.Size = new System.Drawing.Size(187, 22);
            this.subMenuCompUtlPrecios.Text = "Comparar Ult Precios";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 683);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(1115, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.DarkSalmon;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInventario,
            this.menuSocios,
            this.menuCompras,
            this.menuVentas,
            this.menuInformes});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1115, 45);
            this.menu.TabIndex = 7;
            this.menu.Text = "menu";
            // 
            // subMenuNivelStockCritico
            // 
            this.subMenuNivelStockCritico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuNivelStockCritico.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuNivelStockCritico.IconColor = System.Drawing.Color.Black;
            this.subMenuNivelStockCritico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuNivelStockCritico.Name = "subMenuNivelStockCritico";
            this.subMenuNivelStockCritico.Size = new System.Drawing.Size(204, 22);
            this.subMenuNivelStockCritico.Text = "Niveles de Stock Críticos";
            // 
            // menuInformes
            // 
            this.menuInformes.AutoSize = false;
            this.menuInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuInformes});
            this.menuInformes.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInformes.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.menuInformes.IconColor = System.Drawing.Color.Black;
            this.menuInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInformes.IconSize = 20;
            this.menuInformes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInformes.Name = "menuInformes";
            this.menuInformes.Size = new System.Drawing.Size(100, 40);
            this.menuInformes.Text = "Informes";
            this.menuInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuInformes
            // 
            this.subMenuInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuGanancias,
            this.subMenuGananciasPorVentas});
            this.subMenuInformes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subMenuInformes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuInformes.IconColor = System.Drawing.Color.Black;
            this.subMenuInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuInformes.Name = "subMenuInformes";
            this.subMenuInformes.Size = new System.Drawing.Size(180, 22);
            this.subMenuInformes.Text = "Resultados";
            // 
            // subMenuGanancias
            // 
            this.subMenuGanancias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuGanancias.IconColor = System.Drawing.Color.Black;
            this.subMenuGanancias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuGanancias.Name = "subMenuGanancias";
            this.subMenuGanancias.Size = new System.Drawing.Size(201, 22);
            this.subMenuGanancias.Text = "Ganancias";
            // 
            // subMenuGananciasPorVentas
            // 
            this.subMenuGananciasPorVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuGananciasPorVentas.IconColor = System.Drawing.Color.Black;
            this.subMenuGananciasPorVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuGananciasPorVentas.Name = "subMenuGananciasPorVentas";
            this.subMenuGananciasPorVentas.Size = new System.Drawing.Size(201, 22);
            this.subMenuGananciasPorVentas.Text = "Ganancias Por Ventas";
            // 
            // subMenuVentasPorUsuario
            // 
            this.subMenuVentasPorUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVentasPorUsuario.IconColor = System.Drawing.Color.Black;
            this.subMenuVentasPorUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVentasPorUsuario.Name = "subMenuVentasPorUsuario";
            this.subMenuVentasPorUsuario.Size = new System.Drawing.Size(202, 22);
            this.subMenuVentasPorUsuario.Text = "Ventas por Usuarios";
            // 
            // subMenuCaja
            // 
            this.subMenuCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAperCaja,
            this.subMenuCierreCaja,
            this.subMenuEstadoCajaVendedor});
            this.subMenuCaja.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subMenuCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCaja.IconColor = System.Drawing.Color.Black;
            this.subMenuCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCaja.Name = "subMenuCaja";
            this.subMenuCaja.Size = new System.Drawing.Size(180, 22);
            this.subMenuCaja.Text = "Caja";
            // 
            // subMenuAperCaja
            // 
            this.subMenuAperCaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuAperCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuAperCaja.IconColor = System.Drawing.Color.Black;
            this.subMenuAperCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuAperCaja.Name = "subMenuAperCaja";
            this.subMenuAperCaja.Size = new System.Drawing.Size(221, 22);
            this.subMenuAperCaja.Text = "Apertura de Caja";
            // 
            // subMenuCierreCaja
            // 
            this.subMenuCierreCaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuCierreCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCierreCaja.IconColor = System.Drawing.Color.Black;
            this.subMenuCierreCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCierreCaja.Name = "subMenuCierreCaja";
            this.subMenuCierreCaja.Size = new System.Drawing.Size(221, 22);
            this.subMenuCierreCaja.Text = "Cierre de Caja";
            // 
            // subMenuComprasRealizadas
            // 
            this.subMenuComprasRealizadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuComprasRealizadas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuComprasRealizadas.IconColor = System.Drawing.Color.Black;
            this.subMenuComprasRealizadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuComprasRealizadas.Name = "subMenuComprasRealizadas";
            this.subMenuComprasRealizadas.Size = new System.Drawing.Size(201, 22);
            this.subMenuComprasRealizadas.Text = "Compras Realizadas";
            // 
            // subMenuListaClientes
            // 
            this.subMenuListaClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuListaClientes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuListaClientes.IconColor = System.Drawing.Color.Black;
            this.subMenuListaClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuListaClientes.Name = "subMenuListaClientes";
            this.subMenuListaClientes.Size = new System.Drawing.Size(180, 22);
            this.subMenuListaClientes.Text = "Lista de Clientes";
            // 
            // subMenuListaProveedores
            // 
            this.subMenuListaProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuListaProveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuListaProveedores.IconColor = System.Drawing.Color.Black;
            this.subMenuListaProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuListaProveedores.Name = "subMenuListaProveedores";
            this.subMenuListaProveedores.Size = new System.Drawing.Size(203, 22);
            this.subMenuListaProveedores.Text = "Lista de Proveedores";
            // 
            // subMenuEstadoCajaVendedor
            // 
            this.subMenuEstadoCajaVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuEstadoCajaVendedor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuEstadoCajaVendedor.IconColor = System.Drawing.Color.Black;
            this.subMenuEstadoCajaVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuEstadoCajaVendedor.Name = "subMenuEstadoCajaVendedor";
            this.subMenuEstadoCajaVendedor.Size = new System.Drawing.Size(221, 22);
            this.subMenuEstadoCajaVendedor.Text = "Estado Caja por Vendedores";
            // 
            // subMenuVentasPorProd
            // 
            this.subMenuVentasPorProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuVentasPorProd.IconColor = System.Drawing.Color.Black;
            this.subMenuVentasPorProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuVentasPorProd.Name = "subMenuVentasPorProd";
            this.subMenuVentasPorProd.Size = new System.Drawing.Size(202, 22);
            this.subMenuVentasPorProd.Text = "Ventas por Productos";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 705);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private FontAwesome.Sharp.IconMenuItem subMenuVentas;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem subMenuCompras;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem subMenuProveedores;
        private FontAwesome.Sharp.IconMenuItem subMenuClientes;
        private FontAwesome.Sharp.IconMenuItem menuSocios;
        private FontAwesome.Sharp.IconMenuItem subMenuStock;
        private FontAwesome.Sharp.IconMenuItem menuInventario;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem subMenuMovimientoStock;
        private FontAwesome.Sharp.IconMenuItem subMenuComprasProveedores;
        private FontAwesome.Sharp.IconMenuItem subMenuVentasClientes;
        private FontAwesome.Sharp.IconMenuItem subMenuComprasProd;
        private FontAwesome.Sharp.IconMenuItem subMenuVentasRealizada;
        private FontAwesome.Sharp.IconMenuItem subMenuProductos;
        private FontAwesome.Sharp.IconMenuItem subMenuListaProductos;
        private FontAwesome.Sharp.IconMenuItem subMenuProductoMasVend;
        private FontAwesome.Sharp.IconMenuItem subMenuPrecios;
        private FontAwesome.Sharp.IconMenuItem subMenuCompUtlPrecios;
        private FontAwesome.Sharp.IconMenuItem subMenuNivelStockCritico;
        private FontAwesome.Sharp.IconMenuItem subMenuVentasPorUsuario;
        private FontAwesome.Sharp.IconMenuItem subMenuCaja;
        private FontAwesome.Sharp.IconMenuItem subMenuAperCaja;
        private FontAwesome.Sharp.IconMenuItem subMenuCierreCaja;
        private FontAwesome.Sharp.IconMenuItem subMenuComprasRealizadas;
        private FontAwesome.Sharp.IconMenuItem menuInformes;
        private FontAwesome.Sharp.IconMenuItem subMenuInformes;
        private FontAwesome.Sharp.IconMenuItem subMenuGanancias;
        private FontAwesome.Sharp.IconMenuItem subMenuGananciasPorVentas;
        private FontAwesome.Sharp.IconMenuItem subMenuVentasPorProd;
        private FontAwesome.Sharp.IconMenuItem subMenuEstadoCajaVendedor;
        private FontAwesome.Sharp.IconMenuItem subMenuListaProveedores;
        private FontAwesome.Sharp.IconMenuItem subMenuListaClientes;
    }
}