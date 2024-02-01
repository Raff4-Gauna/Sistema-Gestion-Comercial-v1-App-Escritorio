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
    public partial class frmVerificadorPrecio : Form
    {
        public frmVerificadorPrecio()
        {
            InitializeComponent();
            txtcodigobarra.Select();
        }

        private void frmVerificadorPrecio_Load(object sender, EventArgs e)
        {
            txtcodigo.Select();
        }
        //Buscar Productos
        private void BuscarDatosProductos(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Enter)
            {
                // Crear una instancia de CN_Productos
                CN_Productos cnProductos = new CN_Productos();

                // Obtener el producto por código de barras
                Productos producto = cnProductos.ObtenerProductoPorCodigoOCodigoBarras(txtcodigo.Text, txtcodigobarra.Text);

                // Mostrar los datos en los campos correspondientes
                if (producto != null)
                {
                    // Establecer el IdProducto en el campo txtid
                    txtid.Text = producto.IdProducto.ToString();

                    // Por codigo - codigo barra
                    txtcodigo.Text = producto.Codigo;
                    txtcodigobarra.Text = producto.CodigoBarras;
                    // Precio del producto
                    lblprecioactual.Text = producto.PrecioFinal.ToString();
                    // Limpiar el campo de código de barras
                    txtcodigo.Text = "";
                    txtcodigobarra.Text = "";
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con el código de barras especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void txtcodbarraproducto_KeyDown(object sender, KeyEventArgs e)
        {
            BuscarDatosProductos(sender, e);
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            BuscarDatosProductos(sender, e);
        }

    }
}
