using CapaEntidad;
using CapaDatos;
using CapaNegocio;
using CapaPresentación.MdCompras.Modal;
using CapaPresentación.MdVentas.Modal;
using CapaPresentación.MdInventarios;
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


namespace CapaPresentación.MdCompras
{
    public partial class frmOrdenCompra : Form
    {
        // Mantener activa solo una ventana y evitar duplicidad
        private static frmOrdenCompra instancia = null;

        public static frmOrdenCompra ventana_unica(Usuario oUsuario = null)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmOrdenCompra(oUsuario);
            }
            return instancia;
        }
        //--------------------------------------
        private Usuario _Usuario;
        public frmOrdenCompra(Usuario oUsuario)
        {
            _Usuario = oUsuario;
            InitializeComponent();

            // Autocompletar Textbox con consulta por SQL
            CD_Productos cdProductos = new CD_Productos();
            try
            {
                cdProductos.AutoCompledDescripcion(txtDescripcionProd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmOrdenCompra_Load(object sender, EventArgs e)
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
            List<Proveedor> ListaProveedor = new CN_Proveedor().Listar();
            if (ListaProveedor.Count > 0)
            {
                var primerProveedor = ListaProveedor.First();
                txtidproveedor.Text = primerProveedor.IdProveedor.ToString();
                txtdocproveedor.Text = primerProveedor.Documento;
                txtnombreproveedor.Text = primerProveedor.RazonSocial;
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
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";
            
        }

        //Atajos de teclado
        private void frmOrdenCompra_KeyUp(object sender, KeyEventArgs e)
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
                btncrearcompra.PerformClick();
            }
            // F9 BOTON PARA ABRIR FORMS DE AGREGAR PRODUCTO
            if (e.KeyCode == Keys.F9)
            {
                btnAgreProd.PerformClick();
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, punto y coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permitir solo un punto o una coma decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.Contains(".") && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }

            // Permitir borrar el contenido
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, punto y coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permitir solo un punto o una coma decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.Contains(".") && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }

            // Permitir borrar el contenido
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new frmListarProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.Documento;
                    txtnombreproveedor.Text = modal._Proveedor.RazonSocial;
                }
                else
                {
                    txtdocproveedor.Select();
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
                    txtultprecioventa.Text = modal._Producto.PrecioFinal.ToString("N2");
                    txtultpreciocompra.Text = modal._Producto.PrecioCompra.ToString("N2");
                    txtstock.Text = Convert.ToDecimal(modal._Producto.StockExistente).ToString("");
                    txtcantidad.Select();
                }
                else
                {
                    txtcodbarraproducto.Select();
                }

            }
        }

        private void txtcodbarraproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar la entrada del carácter si no es un número
                e.Handled = true;
            }
        }

        // Buscar producto por codigo barra
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
                    txtultprecioventa.Text = oProducto.PrecioFinal.ToString("N2");
                    txtultpreciocompra.Text = oProducto.PrecioCompra.ToString("N2");
                    txtstock.Text = Convert.ToDecimal(oProducto.StockExistente).ToString();
                    txtCodproducto.Text = Convert.ToDecimal(oProducto.Codigo).ToString();
                    //  txtcantidad.Select();

                    // Agregar automáticamente al DataGridView
                    AgregarProductoAlDataGridView();
                }
                else
                {
                    txtcodbarraproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtultprecioventa.Text = "";
                    txtultpreciocompra.Text = "";
                    txtstock.Text = "";
                    txtCodproducto.Text = "";
                    txtDescripcionProd.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtCodproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar la entrada del carácter si no es un número
                e.Handled = true;
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
                    txtultprecioventa.Text = oProducto.PrecioFinal.ToString("N2");
                    txtultpreciocompra.Text = oProducto.PrecioCompra.ToString("N2");
                    txtstock.Text = Convert.ToDecimal(oProducto.StockExistente).ToString();
                    txtCodproducto.Text = Convert.ToDecimal(oProducto.Codigo).ToString();
                    // txtcantidad.Select();

                    // Agregar automáticamente al DataGridView
                    // AgregarProductoAlDataGridView();
                }
                else
                {
                    txtCodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtultprecioventa.Text = "";
                    txtultpreciocompra.Text = "";
                    txtstock.Text = "";
                    txtCodproducto.Text = "";
                    txtDescripcionProd.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Buscar producto por descripcion
        private void txtDescripcionProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Productos oProducto = new CN_Productos().Listar().FirstOrDefault(p => p.DescripcionGeneral == txtDescripcionProd.Text && p.Estado == true);

                if (oProducto != null)
                {
                    txtcodbarraproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.DescripcionGeneral;
                    txtultprecioventa.Text = oProducto.PrecioFinal.ToString("N2");
                    txtultpreciocompra.Text = oProducto.PrecioCompra.ToString("N2");
                    txtstock.Text = Convert.ToDecimal(oProducto.StockExistente).ToString();
                    txtCodproducto.Text = Convert.ToDecimal(oProducto.Codigo).ToString();

                }
                else
                {
                    txtDescripcionProd.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtultprecioventa.Text = "";
                    txtultpreciocompra.Text = "";
                    txtstock.Text = "";
                    txtCodproducto.Text = "";
                    txtDescripcionProd.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtDescripcionProd_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtDescripcionProd.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtDescripcionProd.Text = txtDescripcionProd.Text.ToUpper();

            // Restaurar la posición del cursor
            txtDescripcionProd.SelectionStart = posicionCursor;
        }

        //Agregar rapidamente al datagrid
        private void AgregarProductoAlDataGridView()
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            double cantidad = (double)txtcantidad.Value;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
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

                dgvdata.Rows.Add(new object[] {
                    txtidproducto.Text,
                    txtproducto.Text,
                    preciocompra.ToString("N2"),
                    precioventa.ToString("N2"),
                    Convert.ToDecimal(txtcantidad.Value),
                    (txtcantidad.Value * preciocompra).ToString("N2")

                });
                calcularTotal();
                limpiarProducto();
            }

        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                    }
                }
            }
            txttotalpagar.Text = total.ToString("N2");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodbarraproducto.Text = "";
            txtCodproducto.Text = "";
            txtDescripcionProd.Text = "";
            txtproducto.Text = "";
            txtultprecioventa.Text = "";
            txtultpreciocompra.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txttotalpagar.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
        }

        private void btnlimpiarcampos_Click(object sender, EventArgs e)
        {
            txtcodbarraproducto.Text = "";
            txtCodproducto.Text = "";
            txtproducto.Text = "";
            txtDescripcionProd.Text = "";
            txtultprecioventa.Text = "";
            txtultpreciocompra.Text = "";
            txtstock.Text = "";
            txttotalpagar.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            //txtcambio.Text = "";
            txtcantidad.Text = "1";

            // Limpia el DataGridView usando la misma lógica que en el evento dgvdata_CellContentClick
            for (int index = dgvdata.Rows.Count - 1; index >= 0; index--)
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
        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            AgregarProductoAlDataGridView();
            calcularTotal();

        }

        private void btnAgregarData_Click(object sender, EventArgs e)
        {
            AgregarProductoAlDataGridView();
            calcularTotal();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
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
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        
        private void btncrearcompra_Click(object sender, EventArgs e)
        {
            double cantidad = (double)txtcantidad.Value;

            {
                if (Convert.ToInt32(txtidproveedor.Text) == 0)
                {
                    MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (dgvdata.Rows.Count < 1)
                {
                    MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }



                DataTable detalle_compra = new DataTable();

                detalle_compra.Columns.Add("IdProducto", typeof(int));
                detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
                detalle_compra.Columns.Add("PrecioFinal", typeof(decimal));
                detalle_compra.Columns.Add("Cantidad", typeof(double));
                detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    detalle_compra.Rows.Add(
                        new object[] {
                       Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                       row.Cells["PrecioCompra"].Value.ToString(),
                       row.Cells["PrecioFinal"].Value.ToString(),
                       Convert.ToDouble(row.Cells["Cantidad"].Value),
                       row.Cells["SubTotal"].Value.ToString()
                        });

                }

                int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
                string numerodocumento = string.Format("{0000:00000000}", idcorrelativo);

                Compra oCompra = new Compra()
                {
                    oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                    oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                    TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                    DescripcionMetodoPago = txtmetodopago.Text,
                    NumeroDocumento = numerodocumento,
                    MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
                };

                string mensaje = string.Empty;
                bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

                if (respuesta)
                {
                    var result = MessageBox.Show("Número de venta generada:\n" + numerodocumento + "\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {

                    }

                    txtidproveedor.Text = "0";
                    //txtdocproveedor.Text = "";
                    //txtnombreproveedor.Text = "";
                    dgvdata.Rows.Clear();
                    calcularTotal();

                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnAgreProd_Click(object sender, EventArgs e)
        {
            frmCrudProducto FrmCrudProducto = new frmCrudProducto();
            FrmCrudProducto.ShowDialog();
        }

       
    }
}
