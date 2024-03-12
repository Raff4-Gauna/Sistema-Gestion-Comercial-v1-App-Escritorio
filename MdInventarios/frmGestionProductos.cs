using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaPresentación.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CapaPresentación.MdInventarios
{
    public partial class frmGestionProductos : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmGestionProductos instancia = null;

        public static frmGestionProductos ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmGestionProductos();
            }
            return instancia;
        }

        private ContextMenuStrip menuNegocio;
        private TreeNode nodoNegocio;
        public frmGestionProductos()
        {
            InitializeComponent();
            CrearMenuContextual();
        }

        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            ConfigurarTreeView();
            ActualizarTreeView();
            ConfigurarComboBoxBusqueda();
            MostrarListaProductos();
            SumarProductos();
            SumarProductosNoActivas();
        }

        // para mostrar opciones al dar doble click
        private void CrearMenuContextual()
        {
            // Crea un nuevo menú contextual
            menuNegocio = new ContextMenuStrip();

            // Agrega la opción "Crear Categoría"
            ToolStripMenuItem crearCategoria = new ToolStripMenuItem("Crear Categoría");
            crearCategoria.Click += CrearCategoria_Click;
            menuNegocio.Items.Add(crearCategoria);

            // Agrega la opción "Crear SubCategoría"
            ToolStripMenuItem crearSubCategoria = new ToolStripMenuItem("Crear SubCategoría");
            crearSubCategoria.Click += CrearSubCategoria_Click;
            menuNegocio.Items.Add(crearSubCategoria);

            // Agrega la opción "Crear Producto" para subcategorías al abrir el menú contextual
            menuNegocio.Opening += (sender, e) =>
            {
                if (treeViewDatos.SelectedNode != null && treeViewDatos.SelectedNode.ImageKey == "subCat.png")
                {
                    // Si el nodo seleccionado es una subcategoría, habilita la opción "Crear Producto"
                    menuNegocio.Items["Crear Producto"].Visible = true;
                }
                else
                {
                    // Si no es una subcategoría, oculta la opción "Crear Producto"
                    menuNegocio.Items["Crear Producto"].Visible = false;
                }
            };

            // Agrega la opción "Crear Producto" para subcategorías
            ToolStripMenuItem crearProducto = new ToolStripMenuItem("Crear Producto");
            crearProducto.Name = "Crear Producto"; // Asigna un nombre para referenciarlo en el evento Opening
            crearProducto.Click += CrearProducto_Click;
            menuNegocio.Items.Add(crearProducto);
        }


        // abrir formulario de crear categoria
        private void CrearCategoria_Click(object sender, EventArgs e)
        {
            frmCrudCategoria frmCrudCategoria = new frmCrudCategoria();
            frmCrudCategoria.ShowDialog();
            ActualizarTreeView();
        }
        // abrir formulario de crear subcategoria
        private void CrearSubCategoria_Click(object sender, EventArgs e)
        {
            frmCrudSubCategoria frmCrudSubCategoria = new frmCrudSubCategoria();
            frmCrudSubCategoria.ShowDialog();
            ActualizarTreeView();
        }
        
        // abrir formulario de crear crear producto
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmCrudProducto frmCrudProducto = new frmCrudProducto();
            frmCrudProducto.ShowDialog();
            ActualizarDataGridView(); 
        }

        // Método para abrir formulario de crear producto
        private void CrearProducto_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado un nodo en el TreeView
            if (treeViewDatos.SelectedNode != null)
            {
                // Verifica si el nodo seleccionado es una subcategoría
                if (treeViewDatos.SelectedNode.ImageKey == "subCat.png")
                {
                    // Abre el formulario de crear producto
                    frmCrudProducto frmCrudProducto = new frmCrudProducto();
                    frmCrudProducto.ShowDialog();
                    ActualizarDataGridView(); // Asegúrate de tener este método o ajustarlo según tus necesidades
                }
            }
        }

        //actualiza mi treeview despues de creer una categoria
        private void ActualizarTreeView()
        {
            try
            {
                // Limpiar y configurar el TreeView
                treeViewDatos.Nodes.Clear();
                ConfigurarTreeView();

                // Obtener datos del negocio
                Negocio datos = new CN_Negocio().ObtenerDatos();
                nodoNegocio = treeViewDatos.Nodes.Add(datos.Nombre);

                // Obtener lista de categorías y subcategorías
                List<Categorias> listaCategorias = new CN_Categorias().Listar();
                List<SubCategorias> listaSubCategorias = new CN_SubCategoria().Listar();

                // Agregar nodos al TreeView
                foreach (Categorias categoria in listaCategorias)
                {
                    TreeNode nodoCategoria = nodoNegocio.Nodes.Add(categoria.NombreCategoria);
                    nodoCategoria.ImageKey = "cat.png";
                    nodoCategoria.SelectedImageKey = "cat.png";

                    // Agregar subcategorías
                    foreach (SubCategorias subCategoria in listaSubCategorias)
                    {
                        if (subCategoria.oCategorias.IdCategoria == categoria.IdCategoria)
                        {
                            TreeNode nodoSubCategoria = nodoCategoria.Nodes.Add(subCategoria.NombreSubcategoria);
                            nodoSubCategoria.ImageKey = "subCat.png";
                            nodoSubCategoria.SelectedImageKey = "subCat.png";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine("Error al actualizar el TreeView: " + ex.Message);
            }
        }
        
        //actualiza mi treeview despues de creer una categoria
        private void ConfigurarTreeView()
        {
            // Configuración común del TreeView
            treeViewDatos.ImageList = new ImageList();
            treeViewDatos.ImageList.Images.Add("cat.png", Properties.Resources.cat);
            treeViewDatos.ImageList.Images.Add("subCat.png", Properties.Resources.subCat);
            treeViewDatos.ImageKey = "cat.png";
            treeViewDatos.SelectedImageKey = "cat.png";
            treeViewDatos.ExpandAll();
            treeViewDatos.ContextMenuStrip = menuNegocio;
        }

        private void ConfigurarComboBoxBusqueda()
        {
            // Configuración del ComboBox de búsqueda
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
        }

        private void MostrarListaProductos()
        {
            // Mostrar lista de productos en el DataGridView
            List<Productos> Lista = new CN_Productos().Listar();

            foreach (Productos item in Lista)
            {
                string stockConcatenado = $"{item.StockExistente:F2} {item.oTiposUnidades.NombreTipoUnidad}";

                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.oCategorias.IdCategoria,
                    item.oCategorias.NombreCategoria,
                    item.oSubCategorias.IdSubcategoria,
                    item.oSubCategorias.NombreSubcategoria,
                    item.oTasaImpuestos.IdTasaImpuesto,
                    item.oTasaImpuestos.Porcentaje,
                    item.oTiposUnidades.IdTipoUnidad,
                    item.oTiposUnidades.NombreTipoUnidad,
                    item.oProveedor.IdProveedor,
                    item.oProveedor.RazonSocial,
                    item.Imagen,
                    item.CodigoBarras,
                    item.Codigo,
                    item.DescripcionGeneral,
                    item.PrecioCompra,
                    item.oMargenes_Ganancias.IdMargenGanancia,
                    item.oMargenes_Ganancias.Porcentaje,
                    item.PrecioFinal,
                    item.UbicacionProducto,
                    stockConcatenado,
                    item.StockMinimo,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                });
            }
        }


        private void ActualizarDataGridView()
        {
            // Limpiar el DataGridView antes de actualizar
            dgvdata.Rows.Clear();

            // Volver a cargar los datos en el DataGridView
            MostrarListaProductos();
        }
        
        //Ingresar texto y buscar
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtbusqueda.Text;

            FiltrarDataGridView(columnaFiltro, textoBusqueda);
        }

        //Aplica el filtro eligiendo desde el cbo
        private void FiltrarDataGridView(string columnaFiltro, string textoBusqueda)
        {
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    string valorCelda = row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper();
                    bool contieneTexto = valorCelda.Contains(textoBusqueda.Trim().ToUpper());
                    row.Visible = contieneTexto;
                }
            }
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { }
        }

        //Limpiar el txt y restablece el datagrid
        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            lblDescripcionProd.Text = "";
            lblUltPrecioCompra.Text = "";
            lblUltPrecioVenta.Text = "";
            lblStockExistente.Text = "";
            MostrarTodasLasFilas();
        }

        //Limpiar el txt y restablece el datagrid
        private void MostrarTodasLasFilas()
        {
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        // Variable para almacenar la fila seleccionada
        private int selectedRowIndex = -1;

        //Cuando se da click se pintara de color la celda elegida
        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Restaura el color de la fila anteriormente seleccionada, si hay alguna
                if (selectedRowIndex >= 0)
                {
                    dgvdata.Rows[selectedRowIndex].DefaultCellStyle.BackColor = dgvdata.DefaultCellStyle.BackColor;
                }

                // Almacena el índice de la fila seleccionada
                selectedRowIndex = e.RowIndex;

                // Cambia el color de la fila seleccionada
                dgvdata.Rows[selectedRowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;

                // Llena los datos en los lbl utilizando el índice de la fila seleccionada
                LlenarDatosEnLabels(selectedRowIndex);
            }
        }
        private void LlenarDatosEnLabels(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dgvdata.Rows.Count)
            {
                txtindice.Text = rowIndex.ToString();
                txtid.Text = dgvdata.Rows[rowIndex].Cells["Id"].Value.ToString();
                lblDescripcionProd.Text = dgvdata.Rows[rowIndex].Cells["DescripcionGeneral"].Value.ToString();
                // Agregar el símbolo de dólar a los labels de precios
                lblUltPrecioCompra.Text = $"${dgvdata.Rows[rowIndex].Cells["PrecioCompra"].Value:0,0.00}";
                lblUltPrecioVenta.Text = $"${dgvdata.Rows[rowIndex].Cells["PrecioFinal"].Value:0,0.00}";

                lblStockExistente.Text = dgvdata.Rows[rowIndex].Cells["stockConcatenado"].Value.ToString();

                // Mostrar la imagen
                byte[] imagenBytes = dgvdata.Rows[rowIndex].Cells["Imagen"].Value as byte[];
                if (imagenBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        picImgProducto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Si no hay datos de imagen, puedes asignar una imagen por defecto o limpiar el PictureBox
                    picImgProducto.Image = null; // O asignar una imagen por defecto si es necesario
                }
            }
        }

        public void SumarProductos()
        {
            int Total = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                Total++;
            }

            lblTotalProductos.Text = Total.ToString();
        }

        public void SumarProductosNoActivas()
        {
            int TotalNoActivas = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                // Obtén el valor de la columna EstadoValor (ajústalo según el nombre real de la columna)
                int estado = Convert.ToInt32(row.Cells["EstadoValor"].Value);

                // Verifica si el estado es "No Activo"
                if (estado == 0)
                {
                    TotalNoActivas++;
                }
            }

            lblTotalProductosNoActivas.Text = TotalNoActivas.ToString();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        //Exportar Lista de Articulos a EXEL 
        private void btnExportaExel_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos por exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                // Agregar las columnas visibles al DataTable
                foreach (DataGridViewColumn columna in dgvdata.Columns)
                {
                    if (columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                // Agregar las filas al DataTable
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                    {
                        // Crear una lista dinámica para almacenar los valores de cada fila
                        List<object> rowData = new List<object>();

                        // Agregar valores solo para las columnas visibles
                        foreach (DataGridViewColumn columna in dgvdata.Columns)
                        {
                            if (columna.Visible)
                                rowData.Add(row.Cells[columna.Index].Value?.ToString() ?? "");
                        }

                        // Agregar la fila al DataTable
                        dt.Rows.Add(rowData.ToArray());
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Lista_Productos_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al Generar el Reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

    }
}
