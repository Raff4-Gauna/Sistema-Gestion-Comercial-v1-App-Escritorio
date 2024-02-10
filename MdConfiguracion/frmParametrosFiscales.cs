using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.MdConfiguracion
{
    public partial class frmParametrosFiscales : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmParametrosFiscales instancia = null;

        public static frmParametrosFiscales ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmParametrosFiscales();
            }
            return instancia;
        }
        public frmParametrosFiscales()
        {
            InitializeComponent();
        }
    }
}
