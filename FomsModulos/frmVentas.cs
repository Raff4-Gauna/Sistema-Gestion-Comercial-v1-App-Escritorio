using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Windows.Forms;
using CapaPresentación.MdVentas;


namespace CapaPresentación.FomsModulos
{
    public partial class frmVentas : Form
    {
        private Usuario usuarioActual;
        public frmVentas(Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
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
        private void subMenuPuntoVenta_Click(object sender, EventArgs e)
        {
            frmPuntoVenta puntoVentaForm = new frmPuntoVenta(usuarioActual);
            puntoVentaForm.Show();
        }

        private void subMenuListaVenta_Click(object sender, EventArgs e)
        {
            frmListaVenta frmListaVenta = frmListaVenta.ventana_unica();
            frmListaVenta.MdiParent = this;
            frmListaVenta.Show();
            frmListaVenta.BringToFront();
        }
    }
}
