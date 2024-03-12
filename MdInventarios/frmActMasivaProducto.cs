using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentación.Utilidades;

namespace CapaPresentación.MdInventarios
{
    public partial class frmActMasivaProducto : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmActMasivaProducto instancia = null;

        public static frmActMasivaProducto ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmActMasivaProducto();
            }
            return instancia;
        }

        public frmActMasivaProducto()
        {
            InitializeComponent();
            // Suscribirse a los eventos SelectedIndexChanged de los ComboBox
            cbocategoria.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbosubcategoria.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        private void frmActMasivaProducto_Load(object sender, EventArgs e)
        {
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

            //-------------------------------------- PARA  Margenes de Ganancias-------------------------
            List<Margenes_Ganancias> Margenes_Ganancias = new CN_Margenes_Ganancias().Listar();

            foreach (Margenes_Ganancias item in Margenes_Ganancias)
            {
                cbomargenganancias.Items.Add(new OpcionCombo() { Valor = item.IdMargenGanancia, Texto = item.Porcentaje.ToString() });
            }

            cbomargenganancias.DisplayMember = "Texto";
            cbomargenganancias.ValueMember = "Valor";
            cbomargenganancias.SelectedIndex = 0;

            /*
            //----------Mostrar contenido al datagrid
            List <Productos> lista = new CN_Productos().Listar();

            foreach (Productos item in lista)
            {
                dgvdata.Rows.Add(new object[] {
                item.IdProducto,
                item.oCategorias.IdCategoria,
                item.oCategorias.NombreCategoria,
                item.oSubCategorias.IdSubcategoria,
                item.oSubCategorias.NombreSubcategoria,
                item.DescripcionGeneral,
                item.oTasaImpuestos.IdTasaImpuesto,
                item.oTasaImpuestos.Porcentaje,
                item.PrecioFinal,
                item.FechaActualizacion
                });
            }
            */

            dgvdata.Rows.Clear();

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

        private void cbomargenganancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox de márgenes de ganancias
            decimal porcentajeSeleccionado = Convert.ToDecimal(((OpcionCombo)cbomargenganancias.SelectedItem).Texto);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener los valores seleccionados de categoría y subcategoría
            int idCategoriaSeleccionada = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor);
            int idSubcategoriaSeleccionada = Convert.ToInt32(((OpcionCombo)cbosubcategoria.SelectedItem).Valor);

            // Mostrar contenido al datagrid basado en la categoría y subcategoría seleccionadas
            ActualizarDataGridView(idCategoriaSeleccionada, idSubcategoriaSeleccionada);

        }

        private void ActualizarDataGridView(int idCategoria, int idSubcategoria)
        {
            // Limpiar DataGridView antes de agregar nuevas filas
            dgvdata.Rows.Clear();

            // Mostrar contenido al datagrid basado en la categoría y subcategoría seleccionadas
            List<Productos> listaFiltrada = FiltrarProductosPorCategoriaSubcategoria(idCategoria, idSubcategoria);

            foreach (Productos item in listaFiltrada)
            {
                dgvdata.Rows.Add(new object[] {
                item.IdProducto,
                item.oCategorias.IdCategoria,
                item.oCategorias.NombreCategoria,
                item.oSubCategorias.IdSubcategoria,
                item.oSubCategorias.NombreSubcategoria,
                item.DescripcionGeneral,
                item.oTasaImpuestos.IdTasaImpuesto,
                item.oTasaImpuestos.Porcentaje,
                item.PrecioFinal,
                item.FechaActualizacion
            });
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

        //formateo de numeros a monedas
        private void txtAumentoProcentaje_Leave(object sender, EventArgs e)
        {
            CN_Formato_Monedas cnFormatoMonedas = new CN_Formato_Monedas();
            cnFormatoMonedas.FormatoMoneda(txtAumentoProcentaje);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores seleccionados
                int idCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor);
                int idSubcategoria = Convert.ToInt32(((OpcionCombo)cbosubcategoria.SelectedItem).Valor);

                // Obtener el porcentaje de "cbomargenganancias"
                decimal porcentajeCbomargen = Convert.ToDecimal(((OpcionCombo)cbomargenganancias.SelectedItem).Texto);

                // Obtener el porcentaje ingresado manualmente en "txtAumentoProcentaje"
                decimal porcentajeManual = string.IsNullOrWhiteSpace(txtAumentoProcentaje.Text) ? 0 : Convert.ToDecimal(txtAumentoProcentaje.Text);

                // Calcular el porcentaje total
                decimal porcentajeTotal = porcentajeCbomargen + porcentajeManual;

                // Mostrar un mensaje de confirmación
                DialogResult resultadoConfirmacion = MessageBox.Show("¿Está seguro que desea cambiar el precio a estos productos?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    // Declarar la variable de mensaje
                    string mensaje;

                    // Llamar al método de la capa de negocios para actualizar los precios masivamente
                    bool resultado = new CN_Productos().ActualizarPreciosMasivos(idCategoria, idSubcategoria, 0, porcentajeTotal, out mensaje);

                    // Asignar el mensaje correspondiente
                    mensaje = resultado ? "Los precios se actualizaron correctamente." : mensaje;

                    // Verificar el resultado y mostrar un mensaje al usuario
                    if (resultado)
                    {
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        // Actualizar y refrescar el DataGridView después de la actualización
                        ActualizarDataGridView(idCategoria, idSubcategoria);
                    }
                    else
                    {
                        MessageBox.Show($"Error al actualizar los precios: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()  
        {
            cbocategoria.SelectedIndex = 0;
            cbosubcategoria.SelectedIndex = 0;
            cbomargenganancias.SelectedIndex = 0;
            txtAumentoProcentaje.Text = "";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

       
    }
}
