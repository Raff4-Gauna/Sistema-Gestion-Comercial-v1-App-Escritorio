using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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
using Rectangle = System.Drawing.Rectangle;

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

        // generar pdf obteniendo los datos de "dgvdata ventas" y "dgvdatadetalleventa detalle de venta"
        private void btngenerarpdf_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            if (dgvdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna venta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Negocio odatos = new CN_Negocio().ObtenerDatos();

            // Obtén la fila seleccionada
            DataGridViewRow selectedRow = dgvdata.SelectedRows[0];

            // Obtén el ID de la venta desde la fila seleccionada
            int idVenta = Convert.ToInt32(selectedRow.Cells["IdVenta"].Value);

            // Obtén los datos de la venta con el ID obtenido
            Venta ventaConDetalles = new CN_Venta().ObtenerDetalleVenta(idVenta);


            // Crear el contenido HTML basado en la plantilla
            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();

            // Reemplazar variables en el HTML con los datos de la venta y detalles
            //datos del negocio/empresa
            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@telnegocio", odatos.Telefono);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);
            //datos de emision de venta
            Texto_Html = Texto_Html.Replace("@tipodocumento", selectedRow.Cells["TipoDocumento"].Value.ToString());
            Texto_Html = Texto_Html.Replace("@numerodocumento", selectedRow.Cells["NumeroDocumento"].Value.ToString());
            Texto_Html = Texto_Html.Replace("@doccliente", ventaConDetalles.DocumentoCliente);
            Texto_Html = Texto_Html.Replace("@nombrecliente", ventaConDetalles.NombreCliente);
            Texto_Html = Texto_Html.Replace("@fecharegistro", selectedRow.Cells["FechaRegistro"].Value.ToString());
            Texto_Html = Texto_Html.Replace("@usuarioregistro", selectedRow.Cells["NombreCompleto"].Value.ToString());
            Texto_Html = Texto_Html.Replace("@montototal", selectedRow.Cells["MontoTotal"].Value.ToString());
            Texto_Html = Texto_Html.Replace("@pagocon", ventaConDetalles.MontoPago.ToString());
            Texto_Html = Texto_Html.Replace("@cambio", ventaConDetalles.MontoCambio.ToString());

            //datos detalle de la venta emitida
            StringBuilder detallesHTML = new StringBuilder();

            foreach (var detalleVenta in ventaConDetalles.oDetalle_Venta)
            {
                detallesHTML.Append($"<tr><td>{detalleVenta.oProducto.DescripcionGeneral}</td><td>{detalleVenta.Cantidad}</td><td>{detalleVenta.Total}</td></tr>");
            }

            // Reemplazar en el HTML con los detalles específicos
            Texto_Html = Texto_Html.Replace("@filasDetalles", detallesHTML.ToString());

            // Obtén las filas para la tabla de ventas
            string filasVentas = ObtenerFilasHTML(dgvdata);

            // Obtén las filas para la tabla de detalles de venta desde dgvdatadetalleventa
            string filasDetalles = ObtenerFilasHTML(dgvdatadetalleventa);

            // Reemplazar las marcas de posición en el HTML con las filas de datos
            Texto_Html = Texto_Html.Replace("@filasVentas", filasVentas);

            // Reemplazar las marcas de posición en el HTML con las filas de datos
            Texto_Html = Texto_Html.Replace("@filasDetalles", filasDetalles);

            // Guarda el archivo PDF
            GuardarPDF(Texto_Html);

            // Guarda el archivo PDF
            GuardarPDF(Texto_Html);
        }

        private string ObtenerFilasHTML(DataGridView dataGridView)
        {
            StringBuilder filas = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                filas.Append("<tr>");

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Verifica si la celda no es nula antes de intentar acceder a su valor
                    string cellValue = (cell.Value != null) ? cell.Value.ToString() : string.Empty;
                    filas.Append($"<td>{cellValue}</td>");
                }

                filas.Append("</tr>");
            }

            return filas.ToString();
        }

        // Función para guardar el archivo PDF
        private void GuardarPDF(string contenidoHTML)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Resto del código para agregar contenido al PDF...

                    using (StringReader sr = new StringReader(contenidoHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    } 
}

