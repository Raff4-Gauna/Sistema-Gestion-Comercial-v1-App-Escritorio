using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaPresentación.Utilidades;
//using ClosedXML.Excel;
//using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace CapaPresentación.MdInventarios
{
    public partial class frmCrudProducto : Form
    {
        public frmCrudProducto()
        {
            InitializeComponent();
        }
        
        private void frmCrudProducto_Load(object sender, EventArgs e)
        {
            //-------------------------------------- PARA LOS ESTADOS -------------------------
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            //-------------------------------------- PARA Listar categorias -------------------------
            List<Categorias> Listacategoria = new CN_Categorias().Listar();

            // Ordena la lista alfabéticamente por NombreCategoria
            Listacategoria = Listacategoria.OrderBy(c => c.NombreCategoria).ToList();

            foreach (Categorias item in Listacategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.NombreCategoria });
            }
            cbocategoria.DisplayMember = "Texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 0;

            //-------------------------------------- PARA ListaSubCategorias -------------------------
            List<SubCategorias> ListaSubCategorias = new CN_SubCategoria().Listar();

            // Ordena la lista alfabéticamente por NombreSubcategoria
            ListaSubCategorias = ListaSubCategorias.OrderBy(sc => sc.NombreSubcategoria).ToList();

            foreach (SubCategorias item in ListaSubCategorias)
            {
                cbosubcategoria.Items.Add(new OpcionCombo() { Valor = item.IdSubcategoria, Texto = item.NombreSubcategoria });
            }
            cbosubcategoria.DisplayMember = "Texto";
            cbosubcategoria.ValueMember = "Valor";
            cbosubcategoria.SelectedIndex = 0;

            //-------------------------------------- PARA  TasaImpuestos-------------------------
            List<TasaImpuestos> ListaTasaImpuestos = new CN_Tasa_Impuesto().Listar();

            foreach (TasaImpuestos item in ListaTasaImpuestos)
            {
                cboimpuestos.Items.Add(new OpcionCombo() { Valor = item.IdTasaImpuesto, Texto = item.Porcentaje.ToString() });
            }

            cboimpuestos.DisplayMember = "Texto";
            cboimpuestos.ValueMember = "Valor";
            cboimpuestos.SelectedIndex = 0;


            //-------------------------------------- PARA  TiposUnidades-------------------------
            List<TiposUnidades> ListaTiposUnidades = new CN_Tipos_Unidades().Listar();

            foreach (TiposUnidades item in ListaTiposUnidades)
            {
                cbotipounidad.Items.Add(new OpcionCombo() { Valor = item.IdTipoUnidad, Texto = item.NombreTipoUnidad });
            }
            cbotipounidad.DisplayMember = "Texto";
            cbotipounidad.ValueMember = "Valor";
            cbotipounidad.SelectedIndex = 0;

            //-------------------------------------- PARA  TiposUnidades-------------------------
            List<Proveedor> ListaProveedor = new CN_Proveedor().Listar();

            foreach (Proveedor item in ListaProveedor)
            {
                cboproveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });
            }
            cboproveedor.DisplayMember = "Texto";
            cboproveedor.ValueMember = "Valor";
            cboproveedor.SelectedIndex = 0;
            //----------------------------------------- boton de selectionar -------------------
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            //-------------------------- mostar Lista del productos al iniciar el formulario-------------------------------------

            List<Productos> Lista = new CN_Productos().Listar();

            // Ordena la lista por la fecha de registro en orden descendente
            Lista = Lista.OrderByDescending(p => p.FechaRegistro).ToList();

            foreach (Productos item in Lista)
            {
                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.oCategorias.IdCategoria,
                    item.oCategorias.NombreCategoria,
                    item.oSubCategorias.IdSubcategoria,
                    item.oSubCategorias.NombreSubcategoria,
                    item.oTasaImpuestos.IdTasaImpuesto,
                    item.oTasaImpuestos.Porcentaje,
                    item.oTiposUnidades.IdTipoUnidad,
                    item.oTiposUnidades.NombreTipoUnidad,
                    item.oProveedor.IdProveedor,
                    item.oProveedor.RazonSocial,
                    item.CodigoBarras,
                    item.Codigo,
                    item.DescripcionGeneral,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.PrecioFinal,
                    item.UbicacionProducto,
                    item.StockExistente,
                    item.StockMinimo,
                    item.FechaVencimiento,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                });
            }
            //--------------------- cantidad de productos ----------------------------
            SumarProductos();
            SumarProductosNoActivas();
        }

        private void txtdescripciongeneral_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtdescripciongeneral.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtdescripciongeneral.Text = txtdescripciongeneral.Text.ToUpper();

            // Restaurar la posición del cursor
            txtdescripciongeneral.SelectionStart = posicionCursor;
        }

        
        //precio compra
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
        }

        // impuestos
        private void cboimpuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }
        private void txtporcentajeganacia_TextChanged(object sender, EventArgs e)
        {
            // Llamar al método que realiza el cálculo del precio final
            CalcularPrecioFinal();
        }
        
        // Método para calcular el precio final
        private void CalcularPrecioFinal()
        { 
            // Verificar si los textos son números válidos
            if (decimal.TryParse(txtpreciocompra.Text, out decimal precioVenta))
            {
                // Obtener el porcentaje de impuestos seleccionado en cboimpuestos
                if (cboimpuestos.SelectedItem is OpcionCombo opcion)
                {
                    decimal porcentajeImpuestos = decimal.Parse(opcion.Texto);

                    // Calcular el precio final sumando el porcentaje de impuestos
                    decimal precioFinal = precioVenta * (1 + porcentajeImpuestos / 100);

                    // Si txtporcentajeganancia tiene un valor válido, calcular el precio final con ganancia
                    if (!string.IsNullOrWhiteSpace(txtporcentajeganacia.Text) && decimal.TryParse(txtporcentajeganacia.Text, out decimal porcentajeGanancia))
                    {
                        precioFinal *= (1 + porcentajeGanancia / 100);
                    }

                    // Formatear el número como string con comas y puntos
                    string precioFinalFormateado = string.Format("{0:#,##0.00}", precioFinal);

                    // Asignar el resultado al control TextBox txtpreciofinal
                    txtpreciofinal.Text = precioFinalFormateado;
                }
            }
        }

        //precio venta
        private void txtprecioventa_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto es un número válido
            if (decimal.TryParse(txtprecioventa.Text, out decimal precio))
            {
                // Formatear el número como string con comas y puntos
                string precioFormateado = string.Format("{0:#,##0.00}", precio);

                // Asignar el resultado al control TextBox txtpreciofinal
                txtpreciofinal.Text = precioFormateado;

                // Llamar al método que realiza el cálculo del precio final
                CalcularPrecioFinal();
            }
        }

        //precio venta
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
        }


        //precio final
        private void txtpreciofinal_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto es un número válido
            if (decimal.TryParse(txtpreciofinal.Text, out decimal precio))
            {
                string formato;

                // Determinar el formato basado en la cantidad de cifras
                if (precio < 1000)
                {
                    formato = "0.00";
                }
                else
                {
                    formato = "#,##0.00";
                }

                // Formatear el número como string con el formato determinado
                string precioFormateado = precio.ToString(formato);

                // Mostrar el resultado en el control TextBox
                txtpreciofinal.Text = precioFormateado;

                // Asignar el resultado al control TextBox txtprecioventa
                txtprecioventa.Text = precioFormateado;

                // Llamar al método que realiza el cálculo del precio final
                CalcularPrecioFinal();
            }
        }

        //precio final
        private void txtpreciofinal_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        //Fecha de vencimiento
        private void txtfechavencimiento_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox
            string textoIngresado = txtfechavencimiento.Text;

            // Verificar la longitud del texto
            if (textoIngresado.Length == 2 || textoIngresado.Length == 5)
            {
                // Si se han ingresado dos o cinco caracteres, agregar automáticamente el separador
                txtfechavencimiento.Text += "-";

                // Posicionar el cursor al final del texto para facilitar la edición
                txtfechavencimiento.SelectionStart = txtfechavencimiento.Text.Length;
            }
            else if (textoIngresado.Length == 10)
            {
                // Si se han ingresado diez caracteres, es posible formatear la fecha completa
                // Puedes agregar validaciones adicionales si es necesario
                string fechaFormateada = FormatearFecha(textoIngresado);

                // Mostrar la fecha formateada en el TextBox
                txtfechavencimiento.Text = fechaFormateada;

                // Posicionar el cursor al final del texto para facilitar la edición
                txtfechavencimiento.SelectionStart = txtfechavencimiento.Text.Length;
            }
        }
        // Método para formatear la fecha (puedes ajustarlo según tus necesidades)
        private string FormatearFecha(string fecha)
        {
            // Obtener día, mes y año a partir del texto ingresado
            string dia = fecha.Substring(0, 2);
            string mes = fecha.Substring(3, 2);
            string año = fecha.Substring(6, 4);

            // Formatear la fecha como "Dia-mes-año"
            return $"{dia}-{mes}-{año}";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Productos obj = new Productos()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                oCategorias = new Categorias() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
                oSubCategorias = new SubCategorias() { IdSubcategoria = Convert.ToInt32(((OpcionCombo)cbosubcategoria.SelectedItem).Valor) },
                oTasaImpuestos = new TasaImpuestos() { IdTasaImpuesto = Convert.ToInt32(((OpcionCombo)cboimpuestos.SelectedItem).Valor) },
                oTiposUnidades = new TiposUnidades() { IdTipoUnidad = Convert.ToInt32(((OpcionCombo)cbotipounidad.SelectedItem).Valor) },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(((OpcionCombo)cboproveedor.SelectedItem).Valor) },
                CodigoBarras = txtcodigobarra.Text,
                Codigo = txtcodigo.Text,
                DescripcionGeneral = txtdescripciongeneral.Text,
                PrecioCompra = Convert.ToDecimal(txtpreciocompra.Text),
                PrecioVenta = Convert.ToDecimal(txtprecioventa.Text),
                PrecioFinal = Convert.ToDecimal(txtpreciofinal.Text),
                UbicacionProducto = txtubicacion.Text,
                StockExistente = Convert.ToDecimal(txtstockexistente.Text),
                StockMinimo = Convert.ToDecimal(txtstockminimo.Text),
                FechaVencimiento = txtfechavencimiento.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            
            if (obj.IdProducto == 0)
            {

                int idgenerado = new CN_Productos().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {
                    "",
                    idgenerado,
                    ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)cbosubcategoria.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbosubcategoria.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)cboimpuestos.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cboimpuestos.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)cbotipounidad.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbotipounidad.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)cboproveedor.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cboproveedor.SelectedItem).Texto.ToString(),

                    txtcodigobarra.Text,
                    txtcodigo.Text,
                    txtdescripciongeneral.Text,
                    txtpreciocompra.Text,
                    txtprecioventa.Text,
                    txtpreciofinal.Text,
                    txtubicacion.Text,
                    txtstockexistente.Text,
                    txtstockminimo.Text,
                    txtfechavencimiento.Text,

                    ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Productos().Editar(obj, out mensaje);

                if (resultado)
                {
                        DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["Id"].Value = txtid.Text;
                        row.Cells["IdCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString();
                        row.Cells["DescripcionCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString();
                        row.Cells["IdSubcategoria"].Value = ((OpcionCombo)cbosubcategoria.SelectedItem).Valor.ToString();
                        row.Cells["DescripcionSubcategoria"].Value = ((OpcionCombo)cbosubcategoria.SelectedItem).Texto.ToString();
                        row.Cells["IdTasaImpuesto"].Value = ((OpcionCombo)cboimpuestos.SelectedItem).Valor.ToString();
                        row.Cells["NumeroPorcentaje"].Value = ((OpcionCombo)cboimpuestos.SelectedItem).Texto.ToString();
                        row.Cells["IdTipoUnidad"].Value = ((OpcionCombo)cbotipounidad.SelectedItem).Valor.ToString();
                        row.Cells["TipoUnidad"].Value = ((OpcionCombo)cbotipounidad.SelectedItem).Texto.ToString();
                        row.Cells["IdProveedor"].Value = ((OpcionCombo)cboproveedor.SelectedItem).Valor.ToString();
                        row.Cells["NombreProveedor"].Value = ((OpcionCombo)cboproveedor.SelectedItem).Texto.ToString();
                        row.Cells["CodigoBarras"].Value = txtcodigobarra.Text;
                        row.Cells["Codigo"].Value = txtcodigo.Text;
                        row.Cells["DescripcionGeneral"].Value = txtdescripciongeneral.Text;
                        row.Cells["PrecioCompra"].Value = Convert.ToDecimal(txtpreciocompra.Text);
                        row.Cells["PrecioVenta"].Value = Convert.ToDecimal(txtprecioventa.Text);
                        row.Cells["PrecioFinal"].Value = Convert.ToDecimal(txtpreciofinal.Text);
                        row.Cells["UbicacionProducto"].Value = txtubicacion.Text;
                        row.Cells["StockExistente"].Value = Convert.ToDecimal(txtstockexistente.Text);
                        row.Cells["StockMinimo"].Value = Convert.ToDecimal(txtstockminimo.Text);
                        row.Cells["FechaVencimiento"].Value = txtfechavencimiento.Text;
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    Limpiar();

                    SumarProductos();
                    SumarProductosNoActivas();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

            // Actualizar la interfaz de usuario
            this.Refresh();
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Text = "";
            txtcodigobarra.Text = "";
            txtdescripciongeneral.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtpreciofinal.Text = "";
            txtubicacion.Text = "";
            txtstockexistente.Text = "";
            txtporcentajeganacia.Text = "";
            txtstockminimo.Text = "";
            txtfechavencimiento.Text = "";
            cbocategoria.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
            cbosubcategoria.SelectedIndex = 0;
            cboimpuestos.SelectedIndex = 0;
            cbotipounidad.SelectedIndex = 0;
            cboproveedor.SelectedIndex = 0;
            txtcodigobarra.Select();
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
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();

                    //categoria
                    foreach (OpcionCombo oc in cbocategoria.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbocategoria.Items.IndexOf(oc);
                            cbocategoria.SelectedIndex = indice_combo;
                            break;
                        }

                    }
                    //Subcategoria
                    foreach (OpcionCombo oc in cbosubcategoria.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdSubcategoria"].Value))
                        {
                            int indice_combo = cbosubcategoria.Items.IndexOf(oc);
                            cbosubcategoria.SelectedIndex = indice_combo;
                            break;
                        }

                    }
                    //TASA IMPUESTO
                    foreach (OpcionCombo oc in cboimpuestos.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdTasaImpuesto"].Value))
                        {
                            int indice_combo = cboimpuestos.Items.IndexOf(oc);
                            cboimpuestos.SelectedIndex = indice_combo;
                            break;
                        }

                    }
                    //Tipo unidad
                    foreach (OpcionCombo oc in cbotipounidad.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdTipoUnidad"].Value))
                        {
                            int indice_combo = cbotipounidad.Items.IndexOf(oc);
                            cbotipounidad.SelectedIndex = indice_combo;
                            break;
                        }

                    }
                    //proveedor
                    foreach (OpcionCombo oc in cboproveedor.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdProveedor"].Value))
                        {
                            int indice_combo = cboproveedor.Items.IndexOf(oc);
                            cboproveedor.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    txtcodigobarra.Text = dgvdata.Rows[indice].Cells["CodigoBarras"].Value.ToString();
                    txtcodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtdescripciongeneral.Text = dgvdata.Rows[indice].Cells["DescripcionGeneral"].Value.ToString();
                    txtpreciocompra.Text = dgvdata.Rows[indice].Cells["PrecioCompra"].Value.ToString();
                    txtprecioventa.Text = dgvdata.Rows[indice].Cells["PrecioVenta"].Value.ToString();
                    txtpreciofinal.Text = dgvdata.Rows[indice].Cells["PrecioFinal"].Value.ToString();
                    txtubicacion.Text = dgvdata.Rows[indice].Cells["UbicacionProducto"].Value.ToString();
                    txtstockexistente.Text = dgvdata.Rows[indice].Cells["StockExistente"].Value.ToString();
                    txtstockminimo.Text = dgvdata.Rows[indice].Cells["StockMinimo"].Value.ToString();
                    txtfechavencimiento.Text = dgvdata.Rows[indice].Cells["FechaVencimiento"].Value.ToString();

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Productos obj = new Productos()
                    {
                        IdProducto = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Productos().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                        SumarProductos();
                        SumarProductosNoActivas();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }

            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GenerateRandomNumbers()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                sb.Append(random.Next(0, 9));
            }
            txtcodigobarra.Text = sb.ToString();
        }

        private void chechgenerarcod_CheckedChanged(object sender, EventArgs e)
        {
            if (chechgenerarcod.Checked)
            {
                GenerateRandomNumbers();
            }
        }

        private void txtcodigobarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { }
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { }
        }

        public void SumarProductos()
        {
            int Total = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                Total++;
            }

            lblTotalProductos.Text = Total.ToString();
        }

        public void SumarProductosNoActivas()
        {
            int TotalNoActivas = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                // Obtén el valor de la columna EstadoValor (ajústalo según el nombre real de la columna)
                int estado = Convert.ToInt32(row.Cells["EstadoValor"].Value);

                // Verifica si el estado es "No Activo"
                if (estado == 0)
                {
                    TotalNoActivas++;
                }
            }

            lblTotalProductosNoActivas.Text = TotalNoActivas.ToString();
        }

        
    }
}
