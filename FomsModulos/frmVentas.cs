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
using CapaPresentación.MdVentas.Modal;


namespace CapaPresentación.FomsModulos
{
    public partial class frmVentas : Form
    {
        private Usuario usuarioActual;
        public frmVentas(Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
            this.IsMdiContainer = true;
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
            //frmPuntoVenta puntoVentaForm = new frmPuntoVenta(usuarioActual);
            //puntoVentaForm.Show();

            frmPuntoVenta puntoVentaForm = frmPuntoVenta.ventana_unica(usuarioActual);
            puntoVentaForm.MdiParent = this;
            puntoVentaForm.Show();
            puntoVentaForm.BringToFront();

            //frmPuntoVenta puntoVentaForm = frmPuntoVenta.ventana_unica(usuarioActual);

            //// Verificar si la ventana ya está abierta
            //if (!puntoVentaForm.Visible)
            //{
            //    puntoVentaForm.MdiParent = this;
            //    puntoVentaForm.Show();
            //}
            //else
            //{
            //    puntoVentaForm.BringToFront();  // Si está abierta, solo traerla al frente
            //}
        }

        private void subMenuListaVenta_Click(object sender, EventArgs e)
        {
            frmListaVenta FrmListaVenta = frmListaVenta.ventana_unica();
            FrmListaVenta.MdiParent = this;
            FrmListaVenta.Show();
            FrmListaVenta.BringToFront();
        }

        private void subAperturaCaja_Click(object sender, EventArgs e)
        {
            frmAperturaCaja FrmAperturaCaja = frmAperturaCaja.ventana_unica(usuarioActual);
            FrmAperturaCaja.MdiParent = this;
            FrmAperturaCaja.Show();
            FrmAperturaCaja.BringToFront();
        }

        private void subEstadoCaja_Click(object sender, EventArgs e)
        {
            frmEstadoCaja FrmEstadoCaja = frmEstadoCaja.ventana_unica(usuarioActual);
            FrmEstadoCaja.MdiParent = this;
            FrmEstadoCaja.Show();
            FrmEstadoCaja.BringToFront();
        }
    }
}
