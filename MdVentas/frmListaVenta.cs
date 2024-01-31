//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentación.Usos;


namespace CapaPresentación.MdVentas
{
    public partial class frmListaVenta : Form
    {
        public frmListaVenta()
        {
            InitializeComponent();
        }

        private void frmListaVenta_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {

                }
            }

            // Manejar el evento CheckedChanged del CheckBox
            CargarVentas();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            // Limpia las filas existentes en el DataGridView
            dgvdata.Rows.Clear();
            dgvdatadetalleventa.Rows.Clear();
        }

        private void chekboxMostarTodoDatagrid_CheckedChanged(object sender, EventArgs e)
        {
            // Manejar el evento CheckedChanged del CheckBox
            CargarVentas();
        }

        private void CargarVentas()
        {
            // Limpiar las filas existentes en el DataGridView
            dgvdata.Rows.Clear();
            dgvdatadetalleventa.Rows.Clear();
            // Verificar si el CheckBox está marcado
            if (chekboxMostarTodoDatagrid.Checked)
            {
                // Mostrar todas las ventas
                List<Venta> ventas = new CN_Venta().ListarVentasReducidas();

                foreach (Venta item in ventas)
                {
                    dgvdata.Rows.Add(new object[] {
                        "", item.IdVenta, item.oUsuario.NombreCompleto, item.TipoDocumento, item.NumeroDocumento, item.NombreCliente, item.MontoTotal,
                        (!string.IsNullOrEmpty(item.FechaRegistro) ? DateTime.Parse(item.FechaRegistro).ToString("yyyy-MM-dd") : ""),
                        item.oUsuario.IdUsuario, item.oUsuario.NombreCompleto
                    });
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Obtén las fechas de los DateTimePicker
            DateTime fechaInicio = txtfechainicio.Value;
            DateTime fechaFin = txtfechafin.Value;

            // Llama al método VentaPorRangoFecha de la clase CN_Venta
            List<Venta> lista = new CN_Venta().VentaPorRangoFecha(fechaInicio, fechaFin);

            // Limpia las filas existentes en el DataGridView
            dgvdata.Rows.Clear();
            dgvdatadetalleventa.Rows.Clear();

            // Agrega las ventas filtradas al DataGridView
            foreach (Venta item in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    "", item.IdVenta, item.oUsuario.NombreCompleto, item.TipoDocumento, item.NumeroDocumento, item.NombreCliente, item.MontoTotal,
                    (!string.IsNullOrEmpty(item.FechaRegistro) ? DateTime.Parse(item.FechaRegistro).ToString("yyyy-MM-dd") : ""),
                    item.oUsuario.IdUsuario, item.oUsuario.NombreCompleto
                });
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvdata.Columns["btnseleccionar"].Index)
            {
                int idVenta = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["IdVenta"].Value);
                Venta ventaConDetalles = new CN_Venta().ObtenerDetalleVenta(idVenta);

                dgvdatadetalleventa.Rows.Clear();

                foreach (Detalle_Venta detalle in ventaConDetalles.oDetalle_Venta)
                {
                    dgvdatadetalleventa.Rows.Add(new object[] {
                        detalle.IdDetalleVenta,
                        ventaConDetalles.DescripcionMetodoPago,
                        detalle.oProducto.DescripcionGeneral,
                        detalle.Cantidad,
                        detalle.Total,
                        ventaConDetalles.MontoPago,
                        ventaConDetalles.MontoCambio,
                        detalle.PrecioVenta
                    });
                }
            }
        }

       
    } 
}

