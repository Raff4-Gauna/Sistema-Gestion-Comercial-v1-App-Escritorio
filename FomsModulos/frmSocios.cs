using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentación.MdSocios;

namespace CapaPresentación.FomsModulos
{
    public partial class frmSocios : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmSocios instancia = null;

        public static frmSocios ventana_unica_p_modulo()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmSocios();
                return instancia;
            }
            return instancia;
        }

        public frmSocios()
        {
            InitializeComponent();
        }
        private void frmSocios_Load(object sender, EventArgs e)
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

        private void subMenuGestionClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = frmClientes.ventana_unica();
            frmClientes.MdiParent = this;
            frmClientes.Show();
            frmClientes.BringToFront();
        }

        private void subMenuGestionProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = frmProveedores.ventana_unica();
            frmProveedores.MdiParent = this;
            frmProveedores.Show();
            frmProveedores.BringToFront();
        }
    }
}
