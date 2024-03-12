using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.MdVentas.Comprobantes.VerDetalleVenta
{
    public partial class frmReporteDetalleVenta : Form
    {
        public frmReporteDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmReporteDetalleVenta_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
