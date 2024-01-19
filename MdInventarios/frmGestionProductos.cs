using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentación.MdInventarios
{
    public partial class frmGestionProductos : Form
    {
        private ContextMenuStrip menuNegocio;
        public frmGestionProductos()
        {
            InitializeComponent();
            CrearMenuContextual();
        }

        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            Negocio datos = new CN_Negocio().ObtenerDatos();

            // Limpia cualquier nodo existente en el TreeView
            treeViewDatos.Nodes.Clear();

            // Agrega un nuevo nodo con el nombre del negocio
            treeViewDatos.Nodes.Add(datos.Nombre);

            // Expande todos los nodos para mostrar el nombre del negocio
            treeViewDatos.ExpandAll();

            // Asocia el menú contextual al TreeView
            treeViewDatos.ContextMenuStrip = menuNegocio;

        }

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
        }
        private void CrearCategoria_Click(object sender, EventArgs e)
        {
            frmCrudCategoria frmCrudCategoria = new frmCrudCategoria();
            frmCrudCategoria.Show();
        }

        private void CrearSubCategoria_Click(object sender, EventArgs e)
        {
            frmCrudSubCategoria frmCrudSubCategoria = new frmCrudSubCategoria();
            frmCrudSubCategoria.Show();
        }
    }
}
