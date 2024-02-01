using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaPresentación.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

                item.CodigoBarras,
                item.Codigo,
                item.DescripcionGeneral,
                item.PrecioCompra,
                item.oMargenes_Ganancias.IdMargenGanancia,
                item.oMargenes_Ganancias.NombreMargen,
                item.PrecioFinal,
                item.UbicacionProducto,
                item.StockExistente,
                item.StockMinimo,
                item.FechaVencimiento,
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
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }

            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
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

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvdata.Rows[e.RowIndex];

                // Obtener datos de la fila seleccionada del datagrid dgvdata
                string id = selectedRow.Cells["Id"].Value.ToString();

                // Mostrar el formulario detalle con el ID del producto
                frmDetalleProducto frmDetalleProducto = new frmDetalleProducto(id);

                // Mostrar el formulario detalle
                frmDetalleProducto.ShowDialog();
            }
        }
    }
}
