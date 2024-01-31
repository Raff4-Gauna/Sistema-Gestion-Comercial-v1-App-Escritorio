using CapaEntidad;
using CapaNegocio;
using CapaPresentación.Utilidades;
using CapaPresentación.MdVentas.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.MdVentas
{
    public partial class frmPuntoVenta : Form
    {
        private Usuario _Usuario;
        public frmPuntoVenta(Usuario oUsuario)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            // cargar nombre de usuario en el formulario
            if (_Usuario != null)
            {
                lblusuario.Text = "" + _Usuario.NombreCompleto;
            }
            else
            {
                // Manejar el caso en que el usuario sea nulo, si es necesario
                lblusuario.Text = "Usuario: Desconocido";
            }

            // Autoseleccionar el primer cliente
            List<Clientes> ListaClientes = new CN_Clientes().Listar();
            if (ListaClientes.Count > 0)
            {
                var primerCliente = ListaClientes.First();
                txtdocumentocliente.Text = primerCliente.Documento;
                txtnombrecliente.Text = primerCliente.NombreCompleto;
            }

            // Autoseleccionar el primer método de pago
            List<MetodosPagos> ListaMetodosPagos = new CN_Metodos_Pagos().Listar();
            if (ListaMetodosPagos.Count > 0)
            {
                var primerMetodoPago = ListaMetodosPagos.First();
                txtmetodopago.Text = primerMetodoPago.NombreMetodo;
            }

            // Cargar los tipos de documentos
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Remito X", Texto = "Remito X" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura A", Texto = "Factura A" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura B", Texto = "Factura B" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura C", Texto = "Factura C" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Nota de Crédito", Texto = "Nota de Crédito" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";
            txtCodproducto.Select();
            txtpagocon.Text = "";
            txtcambio.Text = "";
            txttotalpagar.Text = "0";

        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            using (var modal = new frmListarClientes())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtdocumentocliente.Text = modal._Cliente.Documento;
                    txtnombrecliente.Text = modal._Cliente.NombreCompleto;
                    txtcodbarraproducto.Select();
                }
                else
                {
                    txtdocumentocliente.Select();
                }

            }
        }

        private void btnbuscarmetodospagos_Click(object sender, EventArgs e)
        {
            using (var modal = new frmListarMetodosPagos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtmetodopago.Text = modal._MetodosPagos.NombreMetodo;
                    txtcodbarraproducto.Select();
                }
                else
                {
                    txtmetodopago.Select();
                }

            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new frmListarProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodbarraproducto.Text = modal._Producto.CodigoBarras;
                    txtproducto.Text = modal._Producto.DescripcionGeneral;
                    txtprecio.Text = modal._Producto.PrecioFinal.ToString("0.00");
                    txtstock.Text = Convert.ToDecimal(modal._Producto.StockExistente).ToString("0.00");
                    txtcantidad.Select();
                }
                else
                {
                    txtcodbarraproducto.Select();
                }

            }
        }
        //Buscar producto por codigo de barras
        private void txtcodbarraproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Productos oProducto = new CN_Productos().Listar().Where(p => p.CodigoBarras == txtcodbarraproducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodbarraproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.DescripcionGeneral;
                    txtprecio.Text = oProducto.PrecioFinal.ToString("0.00");
                    txtstock.Text = Convert.ToDecimal(oProducto.StockExistente).ToString();
                    txtCodproducto.Text = Convert.ToDecimal(oProducto.Codigo).ToString();
                    txtcantidad.Select();

                    // Agregar automáticamente al DataGridView
                    AgregarProductoAlDataGridView();
                }
                else
                {
                    txtcodbarraproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtCodproducto.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        // Buscar producto por codigo interno
        private void txtCodproducto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                Productos oProducto = new CN_Productos().Listar().FirstOrDefault(p => p.Codigo == txtCodproducto.Text && p.Estado == true);

                if (oProducto != null)
                {
                    txtcodbarraproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.DescripcionGeneral;
                    txtprecio.Text = oProducto.PrecioFinal.ToString("0.00");
                    txtstock.Text = Convert.ToDecimal(oProducto.StockExistente).ToString();
                    txtCodproducto.Text = Convert.ToDecimal(oProducto.Codigo).ToString();
                    txtcantidad.Select();

                    // Agregar automáticamente al DataGridView
                    AgregarProductoAlDataGridView();
                }
                else
                {
                    txtCodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtCodproducto.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //Agregar rapidamente al datagrid
        private void AgregarProductoAlDataGridView()
        {
            decimal precio = 0;
            decimal cantidad = txtcantidad.Value;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            if (cantidad > Convert.ToDecimal(txtstock.Text))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                bool respuesta = new CN_Venta().RestarStock(
                                Convert.ToInt32(txtidproducto.Text),
                                cantidad);

                if (respuesta)
                {
                    dgvdata.Rows.Add(new object[] {
                txtidproducto.Text,
                txtproducto.Text,
                precio.ToString("N2"),
                cantidad,
                (cantidad * precio).ToString("N2")
            });

                    calcularTotal();
                    limpiarProducto();
                    txtCodproducto.Select();
                }
            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            decimal cantidad = txtcantidad.Value;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            if (cantidad > Convert.ToDecimal(txtstock.Text))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {

                bool respuesta = new CN_Venta().RestarStock(
                                Convert.ToInt32(txtidproducto.Text),
                                cantidad);

                if (respuesta)
                {
                    dgvdata.Rows.Add(new object[] {
                        txtidproducto.Text,
                        txtproducto.Text,
                        precio.ToString("N2"),
                        cantidad,
                        (cantidad * precio).ToString("N2")
                    });

                    calcularTotal();
                    limpiarProducto();
                    txtCodproducto.Select();
                }
            }
        }

        //agregar item por medio de una tecla
        private void frmPuntoVenta_KeyUp(object sender, KeyEventArgs e)
        {
            // F1 BOTON PARA AGREGAR PROD AL DATAGRID
            if (e.KeyCode == Keys.F1)
            {
                btnagregarproducto.PerformClick();
            }
            // F2 BOTON PARA LIMPIAR CAMPOS DE TEXTOS
            if (e.KeyCode == Keys.F2)
            {
                btnlimpiarcampos.PerformClick();
            }
            // F10 BOTON PARA ABRIR EL FORMS DE LISTA DE PRODUCTOS
            if (e.KeyCode == Keys.F10)
            {
                btnbuscarproducto.PerformClick();
            }
            // F5 BOTON PARA GRABAR VENTA
            if (e.KeyCode == Keys.F5)
            {
                btncrearventa.PerformClick();
            }
            // F9 BOTON PARA ABRIR FORMS DE VERIFICAR DE PRECIO PROD
            if (e.KeyCode == Keys.F9)
            {
                btnverificarprecio.PerformClick();
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("N2");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodbarraproducto.Text = "";
            txtCodproducto.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.remove20.Width;
                var h = Properties.Resources.remove20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.remove20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Convert.ToDecimal(dgvdata.Rows[index].Cells["Cantidad"].Value));

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(index);
                        calcularTotal();
                    }
                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void calcularcambio()
        {

            if (txttotalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = "0";
            }

            if (decimal.TryParse(txtpagocon.Text.Trim(), out pagacon))
            {

                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void btncrearventa_Click(object sender, EventArgs e)
        {

            if (txtdocumentocliente.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txtnombrecliente.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(decimal));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    Convert.ToDouble(row.Cells["Cantidad"].Value),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0000:00000000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txtdocumentocliente.Text,
                DescripcionMetodoPago = txtmetodopago.Text,
                NombreCliente = txtnombrecliente.Text,
                MontoPago = Convert.ToDecimal(txtpagocon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                dgvdata.Rows.Clear();
                calcularTotal();
                txtpagocon.Text = "";
                txtcambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnlimpiarcampos_Click(object sender, EventArgs e)
        {
            txtcodbarraproducto.Text = "";
            txtCodproducto.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txttotalpagar.Text = "";
            txtpagocon.Text = "";
            txtcambio.Text = "";
        }

        //Abrir verificador de precios productos
        private void btnverificarprecio_Click(object sender, EventArgs e)
        {
            frmVerificadorPrecio frmVerificadorPrecio = new frmVerificadorPrecio();
            frmVerificadorPrecio.Show();
        }

    }
}
