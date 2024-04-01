using CapaEntidad;
using CapaNegocio;
using CapaPresentación.Utilidades;
using CapaPresentación.MdInventarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentación.Modales
{
    public partial class frmConsultarProductos : Form
    {
        public string CodigoBarra { get; private set; }

        public Productos _Producto { get; set; }
        public frmConsultarProductos()
        {
            InitializeComponent();
        }

        private void frmConsultarProductos_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 1;

            List<Productos> lista = new CN_Productos().Listar();

            foreach (Productos item in lista)
            {
                string stockConcatenado = $"{item.StockExistente:F2} {item.oTiposUnidades.NombreTipoUnidad}";

                dgvdata.Rows.Add(new object[] {
                    item.IdProducto,
                    item.CodigoBarras,
                    item.Codigo,
                    item.DescripcionGeneral,
                    item.oTasaImpuestos.IdTasaImpuesto,
                    item.oTasaImpuestos.Porcentaje,
                    item.oProveedor.IdProveedor,
                    item.oProveedor.RazonSocial,
                    item.PrecioFinal,
                    item.PrecioCompra,
                    item.oTiposUnidades.IdTipoUnidad,
                    item.oTiposUnidades.NombreTipoUnidad,
                    stockConcatenado,
                    item.Imagen,
                    item.FechaActualizacion
                });
            }
        }

        // Variable para almacenar la fila seleccionada
        private int selectedRowIndex = -1;

        //Cuando se da click se pintara de color la celda elegida
        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Restaura el color de la fila anteriormente seleccionada, si hay alguna
                if (selectedRowIndex >= 0)
                {
                    dgvdata.Rows[selectedRowIndex].DefaultCellStyle.BackColor = dgvdata.DefaultCellStyle.BackColor;
                }

                // Almacena el índice de la fila seleccionada
                selectedRowIndex = e.RowIndex;

                // Cambia el color de la fila seleccionada
                dgvdata.Rows[selectedRowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;

                // Llena los datos en los lbl utilizando el índice de la fila seleccionada
                LlenarDatosEnLabels(selectedRowIndex);
            }
        }
        private void LlenarDatosEnLabels(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dgvdata.Rows.Count)
            {
                txtindice.Text = rowIndex.ToString();
                txtid.Text = dgvdata.Rows[rowIndex].Cells["Id"].Value.ToString();
                lblDescripcionProd.Text = dgvdata.Rows[rowIndex].Cells["DescripcionGeneral"].Value.ToString();
                lblImpuestos.Text = dgvdata.Rows[rowIndex].Cells["NumeroPorcentaje"].Value.ToString();
                lblProveedor.Text = dgvdata.Rows[rowIndex].Cells["RazonSocial"].Value.ToString();
                // Agregar el símbolo de dólar a los labels de precios
                lblUltPrecioVenta.Text = $"${dgvdata.Rows[rowIndex].Cells["PrecioFinal"].Value:N2}";
                lblUltPrecioCompra.Text = $"${dgvdata.Rows[rowIndex].Cells["PrecioCompra"].Value:N2}";

                lblStockExistente.Text = dgvdata.Rows[rowIndex].Cells["stockConcatenado"].Value.ToString();

                //Codigos
                lblCodBarra.Text = dgvdata.Rows[rowIndex].Cells["CodigoBarras"].Value.ToString();
                lblCodInterno.Text = dgvdata.Rows[rowIndex].Cells["Codigo"].Value.ToString();
                
                // Mostrar la imagen
                byte[] imagenBytes = dgvdata.Rows[rowIndex].Cells["Imagen"].Value as byte[];
                if (imagenBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        picImgProducto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Si no hay datos de imagen, puedes asignar una imagen por defecto o limpiar el PictureBox
                    picImgProducto.Image = null; // O asignar una imagen por defecto si es necesario
                }

                //Fechas de movimientos de precio final
                lblUltActPrecioVenta.Text = dgvdata.Rows[rowIndex].Cells["FechaActualizacion"].Value.ToString();
            }
        }

        //Aplica el filtro eligiendo desde el cbo
        private void FiltrarDataGridView(string columnaFiltro, string textoBusqueda)
        {
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    string valorCelda = row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper();
                    bool contieneTexto = valorCelda.Contains(textoBusqueda.Trim().ToUpper());
                    row.Visible = contieneTexto;
                }
            }
        }
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtbusqueda.Text;

            FiltrarDataGridView(columnaFiltro, textoBusqueda);
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            MostrarTodasLasFilas();
            txtbusqueda.Text = "";
        }

        //Limpiar el txt y restablece el datagrid
        private void MostrarTodasLasFilas()
        {
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnCopiCodBarra_Click(object sender, EventArgs e)
        {
            // Verificar si el label tiene texto y no contiene un punto
            if (!string.IsNullOrEmpty(lblCodBarra.Text) && !lblCodBarra.Text.Contains("."))
            {
                // Asignar el valor del código de barras a la propiedad
                CodigoBarra = lblCodBarra.Text;
                // Cerrar el formulario
                this.Close();
            }
            else
            {
                MessageBox.Show("El código de barras está vacío o contiene un punto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
