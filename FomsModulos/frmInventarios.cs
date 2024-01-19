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
        
    }
}
