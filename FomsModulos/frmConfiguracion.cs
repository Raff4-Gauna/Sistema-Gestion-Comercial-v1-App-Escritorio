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
using CapaPresentación.MdConfiguracion;

namespace CapaPresentación.FomsModulos
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }
        private void frmConfiguracion_Load(object sender, EventArgs e)
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

        private void subMenuDatosNegocio_Click(object sender, EventArgs e)
        {
            frmNegocio frmNegocio = new frmNegocio();
            frmNegocio.Show();
        }

        private void subMenuResguardoDatos_Click(object sender, EventArgs e)
        {
            frmRespaldo frmRespaldo = new frmRespaldo();
            frmRespaldo.Show();
        }

        private void subMenuSucursales_Click(object sender, EventArgs e)
        {
            frmSucursales frmSucursales = new frmSucursales();
            frmSucursales.Show();
        }

        private void subMenuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();
        }

        private void subMenuParametrosFiscal_Click(object sender, EventArgs e)
        {
            frmParametrosFiscales frmParametrosFiscales = new frmParametrosFiscales();
            frmParametrosFiscales.Show();
        }

        private void subMenuTiposContribuyentes_Click(object sender, EventArgs e)
        {
            frmTiposContribuyentes frmTiposContribuyentes = new frmTiposContribuyentes();
            frmTiposContribuyentes.Show();
        }

        private void subMenuTasaImpuestos_Click(object sender, EventArgs e)
        {
            frmTasaImpuestos frmTasaImpuestos = new frmTasaImpuestos();
            frmTasaImpuestos.Show();
        }

        private void subMenuMetodosPagos_Click(object sender, EventArgs e)
        {
            frmMetodosPagos frmMetodosPagos = new frmMetodosPagos();
            frmMetodosPagos.Show();
        }
    }
}
