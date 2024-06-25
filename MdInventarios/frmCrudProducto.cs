using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaPresentación.Utilidades;
using CapaPresentación.MdSocios;
using CapaPresentación.MdConfiguracion;
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
using CapaPresentación.Properties;

namespace CapaPresentación.MdInventarios
{
    public partial class frmCrudProducto : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmCrudProducto instancia = null;

        public static frmCrudProducto ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmCrudProducto();
            }
            return instancia;
        }

        public frmCrudProducto()
        {
            InitializeComponent();
            // Suscribirse a los eventos SelectedIndexChanged de los ComboBox
            cbocategoria.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbosubcategoria.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // Cargar imagen por defecto al abrir el formulario
            CargarImagenPorDefecto();
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

            //-------------------------------------- PARA  Margenes de Ganancias-------------------------
            List<Margenes_Ganancias> Margenes_Ganancias = new CN_Margenes_Ganancias().Listar();

            foreach (Margenes_Ganancias item in Margenes_Ganancias)
            {
                cbomargenganancias.Items.Add(new OpcionCombo() { Valor = item.IdMargenGanancia, Texto = item.Porcentaje.ToString() });
            }

            cbomargenganancias.DisplayMember = "Texto";
            cbomargenganancias.ValueMember = "Valor";
            cbomargenganancias.SelectedIndex = 0;


            //-------------------------------------- PARA  TiposUnidades-------------------------
            List<TiposUnidades> ListaTiposUnidades = new CN_Tipos_Unidades().Listar();

            foreach (TiposUnidades item in ListaTiposUnidades)
            {
                cbotipounidad.Items.Add(new OpcionCombo() { Valor = item.IdTipoUnidad, Texto = item.NombreTipoUnidad });
            }
            cbotipounidad.DisplayMember = "Texto";
            cbotipounidad.ValueMember = "Valor";
            cbotipounidad.SelectedIndex = 0;

            //-------------------------------------- PARA  Proveedor-------------------------
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
                    item.Imagen,
                    item.CodigoBarras,
                    item.Codigo,
                    item.DescripcionGeneral,
                    item.PrecioCompra,
                    item.oMargenes_Ganancias.IdMargenGanancia,
                    item.oMargenes_Ganancias.NombreMargen,
                    item.PrecioFinal,
                    item.UbicacionProducto,
                    item.StockExistente,
                    item.StockMinimo,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo",
                });
            }
            //--------------------- cantidad de productos ----------------------------
            SumarProductos();
            SumarProductosNoActivas();

            radioButtonRedondeo.Select();
            rbCodigo.Select();
        }


        //ATAJOS DE FORMS
        //Abrir forms CRUD CATEGORIAS
        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmCrudCategoria FrmCrudCategoria = new frmCrudCategoria();
            FrmCrudCategoria.FormClosed += FrmCrudCategoria_FormClosed; // Suscribir al evento FormClosed
            FrmCrudCategoria.ShowDialog();
        }
        
        //Forms CRUD CATEGORIAS
        private void FrmCrudCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Actualizar la lista de categorías en el ComboBox
            cbocategoria.Items.Clear(); // Limpiar el ComboBox
            List<Categorias> Listacategoria = new CN_Categorias().Listar();
            Listacategoria = Listacategoria.OrderBy(c => c.NombreCategoria).ToList();
            foreach (Categorias item in Listacategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.NombreCategoria });
            }
            cbocategoria.DisplayMember = "Texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 0;
        }

        //Abrir forms CRUD SUBCATEGORIAS
        private void btnAgregarSubCat_Click(object sender, EventArgs e)
        {
            frmCrudSubCategoria FrmCrudSubCategoria = new frmCrudSubCategoria();
            FrmCrudSubCategoria.FormClosed += frmCrudSubCategoria_FormClosed; // Suscribir al evento FormClosed
            FrmCrudSubCategoria.ShowDialog();
        }

        //Forms CRUD SUBCATEGORIAS
        private void frmCrudSubCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Actualizar la lista de categorías en el ComboBox
            cbosubcategoria.Items.Clear(); // Limpiar el ComboBox
            List<SubCategorias> ListaSubCategorias = new CN_SubCategoria().Listar();
            ListaSubCategorias = ListaSubCategorias.OrderBy(c => c.NombreSubcategoria).ToList();
            foreach (SubCategorias item in ListaSubCategorias)
            {
                cbosubcategoria.Items.Add(new OpcionCombo() { Valor = item.IdSubcategoria, Texto = item.NombreSubcategoria });
            }
            cbosubcategoria.DisplayMember = "Texto";
            cbosubcategoria.ValueMember = "Valor";
            cbosubcategoria.SelectedIndex = 0;
        }

        //Abrir forms TIPOS DE UNIDADES
        private void btnAbrirUnidadMedidas_Click(object sender, EventArgs e)
        {
            frmTipoUnidades FrmTipoUnidades = new frmTipoUnidades();
            FrmTipoUnidades.FormClosed += frmTipoUnidades_FormClosed; // Suscribir al evento FormClosed
            FrmTipoUnidades.ShowDialog();
        }

        //Forms CRUD TIPOS DE UNIDADES
        private void frmTipoUnidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Actualizar la lista de categorías en el ComboBox
            cbotipounidad.Items.Clear(); // Limpiar el ComboBox
            List<TiposUnidades> ListaTiposUnidades = new CN_Tipos_Unidades().Listar();
            ListaTiposUnidades = ListaTiposUnidades.OrderBy(c => c.NombreTipoUnidad).ToList();
            foreach (TiposUnidades item in ListaTiposUnidades)
            {
                cbotipounidad.Items.Add(new OpcionCombo() { Valor = item.IdTipoUnidad, Texto = item.NombreTipoUnidad });
            }
            cbotipounidad.DisplayMember = "Texto";
            cbotipounidad.ValueMember = "Valor";
            cbotipounidad.SelectedIndex = 0;
        }


        //Abrir forms PROVEEDORES
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores FrmProveedores = new frmProveedores();
            FrmProveedores.FormClosed += frmProveedores_FormClosed; // Suscribir al evento FormClosed
            FrmProveedores.ShowDialog();
        }

        //Forms CRUD PROVEEDORES
        private void frmProveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Actualizar la lista de categorías en el ComboBox
            cboproveedor.Items.Clear(); // Limpiar el ComboBox
            List<Proveedor> ListaProveedor = new CN_Proveedor().Listar();
            ListaProveedor = ListaProveedor.OrderBy(c => c.RazonSocial).ToList();
            foreach (Proveedor item in ListaProveedor)
            {
                cboproveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });
            }
            cboproveedor.DisplayMember = "Texto";
            cboproveedor.ValueMember = "Valor";
            cboproveedor.SelectedIndex = 0;
        }


        //Abrir forms TASA DE IMPRUESTO
        private void btnAgregarImpuestos_Click(object sender, EventArgs e)
        {
            frmTasaImpuestos FrmTasaImpuestos = new frmTasaImpuestos();
            FrmTasaImpuestos.FormClosed += frmTasaImpuestos_FormClosed; // Suscribir al evento FormClosed
            FrmTasaImpuestos.ShowDialog();
        }

        //Forms CRUD PROVEEDORES
        private void frmTasaImpuestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Actualizar la lista de categorías en el ComboBox
            cboimpuestos.Items.Clear(); // Limpiar el ComboBox
            List<TasaImpuestos> ListaTasaImpuestos = new CN_Tasa_Impuesto().Listar();
            ListaTasaImpuestos = ListaTasaImpuestos.OrderBy(c => c.Porcentaje).ToList();
            foreach (TasaImpuestos item in ListaTasaImpuestos)
            {
                cboimpuestos.Items.Add(new OpcionCombo() { Valor = item.IdTasaImpuesto, Texto = item.Porcentaje.ToString() });
            }
            cboimpuestos.DisplayMember = "Texto";
            cboimpuestos.ValueMember = "Valor";
            cboimpuestos.SelectedIndex = 0;
        }


        //Abrir forms MARGENES DE GANANCIAS
        private void btnAgregarMarGanancia_Click(object sender, EventArgs e)
        {
            frmMargenGanancias frmMargenGanancias = new frmMargenGanancias();
            frmMargenGanancias.FormClosed += frmMargenGanancias_FormClosed; // Suscribir al evento FormClosed
            frmMargenGanancias.ShowDialog();
        }

        //Forms CRUD MARGENES DE GANANCIAS
        private void frmMargenGanancias_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Actualizar la lista de categorías en el ComboBox
            cbomargenganancias.Items.Clear(); // Limpiar el ComboBox
            List<Margenes_Ganancias> ListaMargenesGanancias = new CN_Margenes_Ganancias().Listar();
            ListaMargenesGanancias = ListaMargenesGanancias.OrderBy(c => c.Porcentaje).ToList();
            foreach (Margenes_Ganancias item in ListaMargenesGanancias)
            {
                cbomargenganancias.Items.Add(new OpcionCombo() { Valor = item.IdMargenGanancia, Texto = item.Porcentaje.ToString() });
            }
            cbomargenganancias.DisplayMember = "Texto";
            cbomargenganancias.ValueMember = "Valor";
            cbomargenganancias.SelectedIndex = 0;
        }


        private void CargarImagenPorDefecto()
        {
            // Obtener la imagen desde los recursos
            Image imagenPorDefecto = Resources.sin_img;

            // Asignar la imagen al control picImgProducto
            picImgProducto.Image = imagenPorDefecto;
        }

        //Radio button de seleccion
        private void rbCodigoBarra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigoBarra.Checked)
            {
                txtcodigobarra.Select();
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo.Checked)
            {
                txtcodigo.Select();
            }
        }

        private void cbocategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el Id de la categoría seleccionada
            int idCategoriaSeleccionada = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor);

            // Obtener las subcategorías relacionadas a la categoría seleccionada
            List<SubCategorias> subcategoriasRelacionadas = ObtenerSubcategoriasPorCategoria(idCategoriaSeleccionada);

            // Limpiar el ComboBox de subcategorías
            cbosubcategoria.Items.Clear();

            // Llenar el ComboBox de subcategorías con las opciones relacionadas
            foreach (SubCategorias subcategoria in subcategoriasRelacionadas)
            {
                cbosubcategoria.Items.Add(new OpcionCombo() { Valor = subcategoria.IdSubcategoria, Texto = subcategoria.NombreSubcategoria });
            }

            // Seleccionar el primer elemento del ComboBox de subcategorías
            if (cbosubcategoria.Items.Count > 0)
            {
                cbosubcategoria.SelectedIndex = 0;
            }
        }

        // Método para obtener las subcategorías relacionadas a una categoría
        private List<SubCategorias> ObtenerSubcategoriasPorCategoria(int idCategoria)
        {
            return new CN_Productos().ObtenerSubcategoriasPorCategoria(idCategoria);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores seleccionados de categoría y subcategoría
                int idCategoriaSeleccionada = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor);
                int idSubcategoriaSeleccionada = Convert.ToInt32(((OpcionCombo)cbosubcategoria.SelectedItem).Valor);

                // Mostrar contenido al datagrid basado en la categoría y subcategoría seleccionadas
                List<Productos> listaFiltrada = FiltrarProductosPorCategoriaSubcategoria(idCategoriaSeleccionada, idSubcategoriaSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al obtener las categorías y subcategorías seleccionadas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Productos> FiltrarProductosPorCategoriaSubcategoria(int idCategoria, int idSubcategoria)
        {
            // Filtrar la lista de productos por categoría y subcategoría
            List<Productos> lista = new CN_Productos().Listar();
            List<Productos> listaFiltrada = lista
                .Where(p => p.oCategorias.IdCategoria == idCategoria && p.oSubCategorias.IdSubcategoria == idSubcategoria)
                .ToList();

            return listaFiltrada;
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

        private bool calculandoPrecioFinal = false;

        // Método para calcular el precio final
        private void CalcularPrecioFinal()
        {
            if (!calculandoPrecioFinal)
            {
                if (decimal.TryParse(txtpreciocompra.Text, out decimal precioVenta))
                {
                    if (cboimpuestos.SelectedItem is OpcionCombo opcion)
                    {
                        decimal porcentajeImpuestos = decimal.Parse(opcion.Texto);

                        decimal precioFinal = precioVenta * (1 + porcentajeImpuestos / 100);

                        if (!string.IsNullOrWhiteSpace(cbomargenganancias.Text) && decimal.TryParse(cbomargenganancias.Text, out decimal porcentajeGanancia))
                        {
                            precioFinal *= (1 + porcentajeGanancia / 100);
                        }

                        // Redondeo según el RadioButton seleccionado
                        if (radioButtonRedondeo.Checked)
                        {
                            precioFinal = Math.Round(precioFinal, 0, MidpointRounding.AwayFromZero);
                        }
                        else if (radioButtonSinRedondeo.Checked)
                        {
                            precioFinal = Math.Round(precioFinal, 2);
                        }

                        string precioFinalFormateado = string.Format("{0:#,##0.00}", precioFinal);

                        txtpreciofinal.Text = precioFinalFormateado;
                    }
                }
            }
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

        //precio compra
        private void txtpreciocompra_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        // impuestos
        private void cboimpuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        // procentaje de ganancia
        private void cbomargenganancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llamar al método que realiza el cálculo del precio final
            CalcularPrecioFinal();
        }

        //aplica el redondeo y cambia el valor en txtpreciofinal
        private void radioButtonRedondeo_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        //no aplica el redondeo deja el valor que tiene por defecto en txtpreciofinal
        private void radioButtonSinRedondeo_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        //Stock
        private void txtstockexistente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números y la coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permitir solo una coma
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        //stock minimo
        private void txtstockminimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números y la coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permitir solo una coma
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void txtpreciofinal_TextChanged(object sender, EventArgs e)
        {
            if (!calculandoPrecioFinal)
            {
                calculandoPrecioFinal = true;


                calculandoPrecioFinal = false;
            }
        }

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

            // Permitir borrar el contenido
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        //formateo de numeros a monedas
        private void txtpreciocompra_Leave(object sender, EventArgs e)
        {
            CN_Formato_Monedas cnFormatoMonedas = new CN_Formato_Monedas();
            cnFormatoMonedas.FormatoMoneda(txtpreciocompra);
        }

        private void txtpreciofinal_Leave(object sender, EventArgs e)
        {
            CN_Formato_Monedas cnFormatoMonedas = new CN_Formato_Monedas();
            cnFormatoMonedas.FormatoMoneda(txtpreciofinal);
        }

        //Eleccion en el cbo de unidades y mostrar en los lbl
        private void cbotipounidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén la selección actual del ComboBox
            OpcionCombo seleccion = (OpcionCombo)cbotipounidad.SelectedItem;

            // Asigna la selección a las etiquetas correspondientes
            lblEleccion1CboUniMed.Text = seleccion.Texto;
            lblEleccion2CboUniMed.Text = seleccion.Texto;
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Convierte la imagen a bytes antes de guardarla
            byte[] imagenBytes = null;
            if (picImgProducto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Clona la imagen antes de intentar guardarla
                    Bitmap clonedImage = new Bitmap(picImgProducto.Image);
                    clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagenBytes = ms.ToArray();
                }
            }

            Productos obj = new Productos()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                oCategorias = new Categorias() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
                oSubCategorias = new SubCategorias() { IdSubcategoria = Convert.ToInt32(((OpcionCombo)cbosubcategoria.SelectedItem).Valor) },
                oTasaImpuestos = new TasaImpuestos() { IdTasaImpuesto = Convert.ToInt32(((OpcionCombo)cboimpuestos.SelectedItem).Valor) },
                oTiposUnidades = new TiposUnidades() { IdTipoUnidad = Convert.ToInt32(((OpcionCombo)cbotipounidad.SelectedItem).Valor) },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(((OpcionCombo)cboproveedor.SelectedItem).Valor) },
                Imagen = imagenBytes,
                CodigoBarras = txtcodigobarra.Text,
                Codigo = txtcodigo.Text,
                DescripcionGeneral = txtdescripciongeneral.Text,
                PrecioCompra = Convert.ToDecimal(txtpreciocompra.Text),
                oMargenes_Ganancias = new Margenes_Ganancias() { IdMargenGanancia = Convert.ToInt32(((OpcionCombo)cbomargenganancias.SelectedItem).Valor) },
                PrecioFinal = Convert.ToDecimal(txtpreciofinal.Text),
                UbicacionProducto = txtubicacion.Text,
                StockExistente = Convert.ToDecimal(txtstockexistente.Text),
                StockMinimo = Convert.ToDecimal(txtstockminimo.Text),
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
                    imagenBytes,
                    txtcodigobarra.Text,
                    txtcodigo.Text,
                    txtdescripciongeneral.Text,
                    txtpreciocompra.Text,
                    ((OpcionCombo)cbomargenganancias.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbomargenganancias.SelectedItem).Texto.ToString(),
                    txtpreciofinal.Text,
                    txtubicacion.Text,
                    txtstockexistente.Text,
                    txtstockminimo.Text,


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
                        row.Cells["Imagen"].Value = imagenBytes;
                        row.Cells["CodigoBarras"].Value = txtcodigobarra.Text;
                        row.Cells["Codigo"].Value = txtcodigo.Text;
                        row.Cells["DescripcionGeneral"].Value = txtdescripciongeneral.Text;
                        row.Cells["PrecioCompra"].Value = Convert.ToDecimal(txtpreciocompra.Text);
                        row.Cells["IdMargenGanancia"].Value = ((OpcionCombo)cbomargenganancias.SelectedItem).Valor.ToString();
                        row.Cells["DescripcionPorcentaje"].Value = ((OpcionCombo)cbomargenganancias.SelectedItem).Texto.ToString();
                        row.Cells["PrecioFinal"].Value = Convert.ToDecimal(txtpreciofinal.Text);
                        row.Cells["UbicacionProducto"].Value = txtubicacion.Text;
                        row.Cells["StockExistente"].Value = Convert.ToDecimal(txtstockexistente.Text);
                        row.Cells["StockMinimo"].Value = Convert.ToDecimal(txtstockminimo.Text);

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
            txtpreciofinal.Text = "";
            txtubicacion.Text = "";
            txtstockexistente.Text = "";
            txtstockminimo.Text = "1";
            txtbusqueda.Text = "";

            cbocategoria.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
            cbosubcategoria.SelectedIndex = 0;
            cboimpuestos.SelectedIndex = 0;
            cbotipounidad.SelectedIndex = 0;
            cboproveedor.SelectedIndex = 0;
            CargarImagenPorDefecto();
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

                    // Convertir el valor de la celda "Imagen" a bytes
                    byte[] imagenBytes = dgvdata.Rows[indice].Cells["Imagen"].Value as byte[];

                    // Asignar los bytes de la imagen al control picImgProducto
                    if (imagenBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            picImgProducto.Image = Image.FromStream(ms);
                        }
                    }

                    txtcodigobarra.Text = dgvdata.Rows[indice].Cells["CodigoBarras"].Value.ToString();
                    txtcodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtdescripciongeneral.Text = dgvdata.Rows[indice].Cells["DescripcionGeneral"].Value.ToString();
                    txtpreciocompra.Text = dgvdata.Rows[indice].Cells["PrecioCompra"].Value.ToString();

                    //Margen de Ganancia
                    foreach (OpcionCombo oc in cbomargenganancias.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdMargenGanancia"].Value))
                        {
                            int indice_combo = cbomargenganancias.Items.IndexOf(oc);
                            cbomargenganancias.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    txtpreciofinal.Text = dgvdata.Rows[indice].Cells["PrecioFinal"].Value.ToString();
                    txtubicacion.Text = dgvdata.Rows[indice].Cells["UbicacionProducto"].Value.ToString();
                    txtstockexistente.Text = dgvdata.Rows[indice].Cells["StockExistente"].Value.ToString();
                    txtstockminimo.Text = dgvdata.Rows[indice].Cells["StockMinimo"].Value.ToString();


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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GenerateRandomNumbers()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            // Añadimos los dos primeros dígitos fijos "77"
            sb.Append("77");

            // Generamos los siguientes 11 dígitos de manera aleatoria
            for (int i = 0; i < 11; i++)
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
            // Verificar si el carácter ingresado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar la entrada del carácter si no es un número
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter) { }
        }
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar la entrada del carácter si no es un número
                e.Handled = true;
            }

        }
        private void txtdescripciongeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es una letra, un número ni un carácter de control, excepto el espacio y el punto
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '.')
            {
                // Cancelar la entrada del carácter si no es una letra, un número ni un carácter de control, excepto el espacio y el punto
                e.Handled = true;
            }
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

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "Imágenes|*.jpg;*.jpeg;*.png"; // Establece los formatos de imagen permitidos

            DialogResult rs = fo.ShowDialog();

            if (rs == DialogResult.OK)
            {
                // Abre el archivo seleccionado como un flujo (Stream)
                using (FileStream fs = new FileStream(fo.FileName, FileMode.Open, FileAccess.Read))
                {
                    // Asigna el flujo al control PictureBox
                    picImgProducto.Image = Image.FromStream(fs);
                }
            }
        }
    }
}
