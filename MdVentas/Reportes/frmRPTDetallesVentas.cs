using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.MdVentas.Reportes
{
    public partial class frmRPTDetallesVentas : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmRPTDetallesVentas instancia = null;

        public static frmRPTDetallesVentas ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmRPTDetallesVentas();
            }
            return instancia;
        }

        public frmRPTDetallesVentas()
        {
            InitializeComponent();
        }

        private void frmRPTDetallesVentas_Load(object sender, EventArgs e)
        {
            // Intenta convertir el valor de txtIdVenta.Text a entero
            if (int.TryParse(txtIdVenta.Text, out int idVenta))
            {
                // TODO: esta línea de código carga datos en la tabla 'DS_Reportes.detalleVenta'
                // Puede moverla o quitarla según sea necesario.
                this.detalleVentaTableAdapter.Fill(this.DS_Reportes.detalleVenta, IdVenta: idVenta);

                // TODO: esta línea de código carga datos en la tabla 'DS_Reportes.datosGeneralesVenta'
                // Puede moverla o quitarla según sea necesario.
                this.datosGeneralesVentaTableAdapter.Fill(this.DS_Reportes.datosGeneralesVenta, IdVenta: idVenta);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                // Manejar el caso en el que txtIdVenta.Text no es un valor válido para convertir a entero.
                // Puedes mostrar un mensaje de error o realizar alguna otra acción.
            }
        }
    }
}
