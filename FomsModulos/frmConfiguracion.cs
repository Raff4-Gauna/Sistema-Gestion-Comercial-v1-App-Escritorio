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
        //mantener activa solo una ventana y evitar duplicidad
        private static frmConfiguracion instancia = null;

        public static frmConfiguracion ventana_unica_p_modulo()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmConfiguracion();
                return instancia;
            }
            return instancia;
        }
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
            tssHora.Text = " " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void subMenuDatosNegocio_Click(object sender, EventArgs e)
        {
            frmNegocio frmNegocio = frmNegocio.ventana_unica();
            frmNegocio.MdiParent = this;
            frmNegocio.Show();
            frmNegocio.BringToFront();
        }

        private void subMenuSucursales_Click(object sender, EventArgs e)
        {
            frmSucursales frmSucursales = frmSucursales.ventana_unica();
            frmSucursales.MdiParent = this;
            frmSucursales.Show();
            frmSucursales.BringToFront();
        }

        private void subMenuResguardoDatos_Click(object sender, EventArgs e)
        {
            frmRespaldo frmRespaldo = frmRespaldo.ventana_unica();
            frmRespaldo.MdiParent = this;
            frmRespaldo.Show();
            frmRespaldo.BringToFront();
        }

        private void subMenuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = frmUsuarios.ventana_unica();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
            frmUsuarios.BringToFront();
        }

        private void subMenuParametrosFiscal_Click(object sender, EventArgs e)
        {
            frmParametrosFiscales frmParametrosFiscales = frmParametrosFiscales.ventana_unica();
            frmParametrosFiscales.MdiParent = this;
            frmParametrosFiscales.Show();
            frmParametrosFiscales.BringToFront();
        }

        private void subMenuTiposContribuyentes_Click(object sender, EventArgs e)
        {
            frmTiposContribuyentes frmTiposContribuyentes = frmTiposContribuyentes.ventana_unica();
            frmTiposContribuyentes.MdiParent = this;
            frmTiposContribuyentes.Show();
            frmTiposContribuyentes.BringToFront();
        }

        private void subMenuTasaImpuestos_Click(object sender, EventArgs e)
        {
            frmTasaImpuestos frmTasaImpuestos = frmTasaImpuestos.ventana_unica();
            frmTasaImpuestos.MdiParent = this;
            frmTasaImpuestos.Show();
            frmTasaImpuestos.BringToFront();
        }

        private void subMenuMetodosPagos_Click(object sender, EventArgs e)
        {
            frmMetodosPagos frmMetodosPagos = frmMetodosPagos.ventana_unica();
            frmMetodosPagos.MdiParent = this;
            frmMetodosPagos.Show();
            frmMetodosPagos.BringToFront();
        }
    }
}
