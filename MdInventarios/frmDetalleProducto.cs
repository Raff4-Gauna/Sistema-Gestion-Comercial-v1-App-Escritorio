using CapaEntidad;
using CapaNegocio;
using CapaDatos;
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
using System.IO;
using System.Globalization;


namespace CapaPresentación.MdInventarios
{
    public partial class frmDetalleProducto : Form
    {
       
        public Productos _Productos { get; set; }

        // Constructor que recibe el ID del producto
        public frmDetalleProducto(string id)
        {
            InitializeComponent();
            try
            {
                // Obtener los datos del producto usando el ID
                _Productos = ObtenerDatosProductoPorID(id);

                // Cargar los datos del producto en los controles del formulario
                CargarDatosEnControles();
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones si es necesario
                Console.WriteLine("Error al crear el formulario: " + ex.Message);
            }

            // Cargar los datos del producto en los controles del formulario
            CargarDatosEnControles();
        }

        private void frmDetalleProducto_Load(object sender, EventArgs e)
        {
            // Cargar los datos del producto en los controles del formulario
            CargarDatosEnControles();
        }
        private void CargarDatosEnControles()
        {
            // Verificar si se obtuvieron datos del producto
            if (_Productos != null)
            {
                // Cargar los datos del producto en los controles del formulario
                txtid.Text = _Productos.IdProducto.ToString();
                cbocategoria.Text = _Productos.oCategorias.NombreCategoria.ToString();
                cbosubcategoria.Text = _Productos.oSubCategorias.NombreSubcategoria.ToString();
                cboimpuestos.Text = _Productos.oTasaImpuestos.Porcentaje.ToString();
                cbotipounidad.Text = _Productos.oTiposUnidades.NombreTipoUnidad.ToString();
                cboproveedor.Text = _Productos.oProveedor.RazonSocial.ToString();
                txtcodigobarra.Text = _Productos.CodigoBarras.ToString();
                txtcodigo.Text = _Productos.Codigo.ToString();
                txtdescripciongeneral.Text = _Productos.DescripcionGeneral.ToString();
                txtpreciocompra.Text = _Productos.PrecioCompra.ToString();
                cbomargenganancias.Text = _Productos.oMargenes_Ganancias.Porcentaje.ToString();
                txtpreciofinal.Text = _Productos.PrecioFinal.ToString();
                txtubicacion.Text = _Productos.UbicacionProducto.ToString();
                txtstockexistente.Text = _Productos.StockExistente.ToString();
                txtstockminimo.Text = _Productos.StockMinimo.ToString();
                txtfechavencimiento.Text = _Productos.FechaVencimiento.ToString();
                cboestado.Text = _Productos.Estado.ToString();
            }
            else
            {
                // Manejar el caso en que no se obtengan datos del producto
                MessageBox.Show("No se pudo obtener información del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Productos ObtenerDatosProductoPorID(string id)
        {
            // Instanciar la clase de la capa de negocios
            CN_Productos objcd_Producto = new CN_Productos();

            // Llamar al método de la capa de negocios para obtener el producto por ID
            return objcd_Producto.ObtenerProductoPorID(id);
        }
    }
}
