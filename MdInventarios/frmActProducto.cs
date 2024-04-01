using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using CapaEntidad;
using System.Data.SqlClient;
using CapaPresentación.Modales;


namespace CapaPresentación.MdInventarios
{
    public partial class frmActProducto : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmActProducto instancia = null;
        public static frmActProducto ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmActProducto();
            }
            return instancia;
        }

        private CN_Productos cnProductos = new CN_Productos();
        public frmActProducto()
        {
            InitializeComponent();
        }

        private void frmActProducto_Load(object sender, EventArgs e)
        {
            txtcodigo.Select();
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            frmConsultarProductos FrmConsultarProductos = new frmConsultarProductos();
            FrmConsultarProductos.ShowDialog();

            // Verificar si se ha establecido el código de barras en el formulario consultado
            if (!string.IsNullOrEmpty(FrmConsultarProductos.CodigoBarra))
            {
                // Asignar el valor del código de barras al control txtcodigobarra
                txtcodigobarra.Text = FrmConsultarProductos.CodigoBarra;
                txtcodigobarra.Select();
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

        //formateo de numeros a monedas
        private void txtpreciofinal_Leave(object sender, EventArgs e)
        {
            CN_Formato_Monedas cnFormatoMonedas = new CN_Formato_Monedas();
            cnFormatoMonedas.FormatoMoneda(txtpreciofinal);
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
        }

        //Buscar Productos
        private void BuscarDatosProductos(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // Crear una instancia de CN_Productos
                CN_Productos cnProductos = new CN_Productos();

                // Verificar que se haya ingresado un código o código de barras
                if (!string.IsNullOrEmpty(txtcodigo.Text) || !string.IsNullOrEmpty(txtcodigobarra.Text))
                {
                    // Obtener el producto por código o código de barras
                    Productos producto = cnProductos.ObtenerProductoPorCodigoOCodigoBarras(txtcodigo.Text, txtcodigobarra.Text);

                    // Mostrar los datos en los campos correspondientes
                    if (producto != null)
                    {
                        // Establecer el IdProducto en el campo txtid
                        txtid.Text = producto.IdProducto.ToString();

                        // Resto del código
                        txtcodigo.Text = producto.Codigo;
                        txtcodigobarra.Text = producto.CodigoBarras;
                        txtpreciofinal.Text = producto.PrecioFinal.ToString();
                        lbldescripciongeneral.Text = producto.DescripcionGeneral;
                        lblstockexistente.Text = producto.StockExistente.ToString();
                        lblprecioactual.Text = producto.PrecioFinal.ToString("N2");
                        lblubicacionproducto.Text = producto.UbicacionProducto;

                        // Limpiar el campo de código de barras
                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un producto con el código o código de barras especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un código o código de barras para buscar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //Buscar por Codigo Barra
        private void txtcodigobarra_KeyDown(object sender, KeyEventArgs e)
        {
            BuscarDatosProductos(sender, e);
        }

        //Buscar por Codigo
        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            BuscarDatosProductos(sender, e);
        }

        //Actualizar el precio o el stock
        private void btnactualizarprod_Click(object sender, EventArgs e)
        {
            // Verificar que se haya ingresado un código o código de barras
            if (!string.IsNullOrEmpty(txtcodigo.Text) || !string.IsNullOrEmpty(txtcodigobarra.Text))
            {
                decimal stockExistente;
                decimal precioFinal;

                // Verificar si el texto en txtstockexistente y txtpreciofinal son números válidos
                if (decimal.TryParse(txtstockexistente.Text, out stockExistente) && decimal.TryParse(txtpreciofinal.Text, out precioFinal))
                {
                    // Crear un objeto Producto con los datos ingresados
                    Productos producto = new Productos
                    {
                        IdProducto = Convert.ToInt32(txtid.Text), // Agregamos el IdProducto
                        PrecioFinal = precioFinal,
                        StockExistente = stockExistente
                    };

                    // Actualizar el producto en la base de datos
                    string mensaje;
                    if (cnProductos.ActualizarProducto(producto, out mensaje))
                    {
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el producto: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese valores válidos para el precio final o el stock existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código o código de barras para buscar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnlimpiarcampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            // Limpiar todos los campos del formulario
            txtcodigobarra.Text = "";
            txtcodigo.Text = "";
            lbldescripciongeneral.Text = "";
            lblfechavencimiento.Text = "";
            txtpreciofinal.Text = "";
            lblstockexistente.Text = "";
            lblprecioactual.Text = "";
            lblubicacionproducto.Text = "";
            txtstockexistente.Text = "0";
            txtcodigo.Select();
        }

        private void txtstockexistente_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
