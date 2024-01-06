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
    public partial class frmReporteListaUsuarios : Form
    {
        public frmReporteListaUsuarios()
        {
            InitializeComponent();
        }

        private void frmReporteListaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBVENTASGESTIONDataSet.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.dBVENTASGESTIONDataSet.USUARIO);

            this.reportViewer1.RefreshReport();
        }
    }
}
