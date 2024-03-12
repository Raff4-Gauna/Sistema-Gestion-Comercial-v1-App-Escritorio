using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.FomsModulos
{
    public partial class frmReportes : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmReportes instancia = null;

        public static frmReportes ventana_unica_p_modulo()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmReportes();
                return instancia;
            }
            return instancia;
        }

        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
