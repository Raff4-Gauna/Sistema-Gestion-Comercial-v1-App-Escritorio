using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaPresentación.MdInventarios;


namespace CapaPresentación.FomsModulos
{
    public partial class frmInventarios : Form
    {
        public frmInventarios()
        {
            InitializeComponent();
        }
        private void frmInventarios_Load(object sender, EventArgs e)
        {
            ActualizarHora();

            // Usar un temporizador para actualizar la hora cada segundo (opcional)
            Timer timer = new Timer();
            timer.Interval = 1000; // Intervalo en milisegundos
            timer.Tick += (s, args) => ActualizarHora();
            timer.Start();
        }
        private void ActualizarHora()
        {
            // Actualizar el contenido del ToolStripStatusLabel con la hora actual
            tssHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }
        private void subMenuGestionProductos_Click(object sender, EventArgs e)
        {
            frmGestionProductos frmGestionProductos = new frmGestionProductos();
            frmGestionProductos.Show();
        }

        private void subMenuUnidadesMedidas_Click(object sender, EventArgs e)
        {
            frmTipoUnidades frmTipoUnidades = new frmTipoUnidades();
            frmTipoUnidades.ShowDialog();
        }

        private void subMenuCategorias_Click(object sender, EventArgs e)
        {
            frmCrudCategoria frmCrudCategoria = new frmCrudCategoria();
            frmCrudCategoria.ShowDialog();
        }

        private void subMenuSubCategorias_Click(object sender, EventArgs e)
        {
            frmCrudSubCategoria frmCrudSubCategoria = new frmCrudSubCategoria();
            frmCrudSubCategoria.ShowDialog();
        }

        private void subMenuPrecioIndividual_Click(object sender, EventArgs e)
        {
            frmActProducto frmActProducto = new frmActProducto();
            frmActProducto.ShowDialog();
        }
    }
}
