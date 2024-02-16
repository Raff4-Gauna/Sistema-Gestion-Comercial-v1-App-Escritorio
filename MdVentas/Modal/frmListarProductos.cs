using CapaEntidad;
using CapaNegocio;
using CapaPresentación.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentación.MdVentas.Modal
{
    public partial class frmListarProductos : Form
    {
        public Productos _Producto { get; set; }
        public frmListarProductos()
        {
            InitializeComponent();
        }

        private void frmListarProductos_Load(object sender, EventArgs e)
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
                dgvdata.Rows.Add(new object[] {
                    item.IdProducto,
                    item.CodigoBarras,
                    item.DescripcionGeneral,
                    item.oCategorias.NombreCategoria,
                    item.StockExistente,
                    item.PrecioCompra,
                    item.oTasaImpuestos.Porcentaje,
                    item.PrecioFinal
                });
            }
        }

        private void SeleccionarFilaDataGrid(int rowIndex)
        {
            // Tu lógica para seleccionar la fila según el índice de fila proporcionado
            _Producto = new Productos()
            {
                IdProducto = Convert.ToInt32(dgvdata.Rows[rowIndex].Cells["Id"].Value.ToString()),
                CodigoBarras = dgvdata.Rows[rowIndex].Cells["CodigoBarras"].Value.ToString(),
                DescripcionGeneral = dgvdata.Rows[rowIndex].Cells["DescripcionGeneral"].Value.ToString(),
                StockExistente = Convert.ToDecimal(dgvdata.Rows[rowIndex].Cells["StockExistente"].Value.ToString()),
                PrecioCompra = Convert.ToDecimal(dgvdata.Rows[rowIndex].Cells["PrecioCompra"].Value.ToString()),
                PrecioFinal = Convert.ToDecimal(dgvdata.Rows[rowIndex].Cells["PrecioFinal"].Value.ToString()),
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                SeleccionarFilaDataGrid(e.RowIndex);
            }
        }
        private void dgvdata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Asumiendo que CurrentCell.RowIndex te da el índice de la fila actual
                int rowIndex = dgvdata.CurrentCell?.RowIndex ?? -1;

                if (rowIndex >= 0)
                {
                    SeleccionarFilaDataGrid(rowIndex);
                    e.SuppressKeyPress = true; // Evitar procesar el Enter por defecto
                }
            }
        }
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtbusqueda.Text;

            FiltrarDataGridView(columnaFiltro, textoBusqueda);
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

        //Limpiar el txt y restablece el datagrid
        private void MostrarTodasLasFilas()
        {
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            MostrarTodasLasFilas();
        }
    }
}
