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

        private void frmCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
