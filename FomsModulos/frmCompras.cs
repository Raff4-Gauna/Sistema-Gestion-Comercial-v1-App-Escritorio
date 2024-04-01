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
using CapaPresentación.MdCompras;
using CapaPresentación.MdVentas.Modal;

namespace CapaPresentación.FomsModulos
{
    public partial class frmCompras : Form
    {
        private Usuario usuarioActual;
        public frmCompras(Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void subMenuOrdenCompra_Click(object sender, EventArgs e)
        {

            frmOrdenCompra ordenCompraForm = frmOrdenCompra.ventana_unica(usuarioActual);
            ordenCompraForm.MdiParent = this;
            ordenCompraForm.Show();
            ordenCompraForm.BringToFront();
        }
    }
}
