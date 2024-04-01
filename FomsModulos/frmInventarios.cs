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
        //mantener activa solo una ventana y evitar duplicidad
        private static frmInventarios instancia = null;

        public static frmInventarios ventana_unica_p_modulo()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmInventarios();
                return instancia;
            }
            return instancia;
        }
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
            frmGestionProductos frmGestionProductos =  frmGestionProductos.ventana_unica();
            frmGestionProductos.MdiParent = this;
            frmGestionProductos.Show();
            frmGestionProductos.BringToFront();
        }

        private void subMenuUnidadesMedidas_Click_1(object sender, EventArgs e)
        {
            frmTipoUnidades frmTipoUnidades = frmTipoUnidades.ventana_unica();
            frmTipoUnidades.MdiParent = this;
            frmTipoUnidades.Show();
            frmTipoUnidades.BringToFront();
        }
        private void subMenuCategorias_Click_1(object sender, EventArgs e)
        {
            frmCrudCategoria frmCrudCategoria = frmCrudCategoria.ventana_unica();
            frmCrudCategoria.MdiParent = this;
            frmCrudCategoria.Show();
            frmCrudCategoria.BringToFront();
        }

        private void subMenuSubCategorias1_Click(object sender, EventArgs e)
        {
            frmCrudSubCategoria frmCrudSubCategoria = frmCrudSubCategoria.ventana_unica();
            frmCrudSubCategoria.MdiParent = this;
            frmCrudSubCategoria.Show();
            frmCrudSubCategoria.BringToFront();
        }

        private void subMenuPrecioIndividual_Click(object sender, EventArgs e)
        {
            frmActProducto frmActProducto = frmActProducto.ventana_unica();
            frmActProducto.MdiParent = this;
            frmActProducto.Show();
            frmActProducto.BringToFront();
        }

        private void subMenuMargenesGanancias_Click_1(object sender, EventArgs e)
        {
            frmMargenGanancias frmMargenGanancias = frmMargenGanancias.ventana_unica();
            frmMargenGanancias.MdiParent = this;
            frmMargenGanancias.Show();
            frmMargenGanancias.BringToFront();
        }

        private void subMenuPrecioMasivo_Click(object sender, EventArgs e)
        {
            frmActMasivaProducto frmActMasivaProducto = frmActMasivaProducto.ventana_unica();
            frmActMasivaProducto.MdiParent = this;
            frmActMasivaProducto.Show();
            frmActMasivaProducto.BringToFront();
        }

        private void subMenuABMProductos_Click(object sender, EventArgs e)
        {
            frmCrudProducto frmCrudProducto = frmCrudProducto.ventana_unica();
            frmCrudProducto.MdiParent = this;
            frmCrudProducto.Show();
            frmCrudProducto.BringToFront();
        }

        private void iconValorDolarActual_Click(object sender, EventArgs e)
        {
            frmValorDolar frmValorDolar = frmValorDolar.ventana_unica();
            frmValorDolar.MdiParent = this;
            frmValorDolar.Show();
            frmValorDolar.BringToFront();
        }
    }
}
