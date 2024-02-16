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
       
        public frmDetalleProducto()
        {
            InitializeComponent();
        }

        private void frmDetalleProducto_Load(object sender, EventArgs e)
        {



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

        private void txtdescripciongeneral_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtdescripciongeneral.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtdescripciongeneral.Text = txtdescripciongeneral.Text.ToUpper();

            // Restaurar la posición del cursor
            txtdescripciongeneral.SelectionStart = posicionCursor;
        }

        private void txtdescripciongeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es una letra ni un número ni un carácter de control, excepto la barra espaciadora
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Cancelar la entrada del carácter si no es una letra ni un número ni un carácter de control, excepto la barra espaciadora
                e.Handled = true;
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

        private void txtpreciocompra_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        private void cboimpuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        private void cbomargenganancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
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

        private void txtpreciofinal_TextChanged(object sender, EventArgs e)
        {
            if (!calculandoPrecioFinal)
            {
                calculandoPrecioFinal = true;


                calculandoPrecioFinal = false;
            }
        }

        private void radioButtonRedondeo_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        private void radioButtonSinRedondeo_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;

                // Crear el objeto Productos con la información del formulario
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
                    oMargenes_Ganancias = new Margenes_Ganancias() { IdMargenGanancia = Convert.ToInt32(((OpcionCombo)cbomargenganancias.SelectedItem).Valor) },
                    PrecioFinal = Convert.ToDecimal(txtpreciofinal.Text),
                    UbicacionProducto = txtubicacion.Text,
                    StockExistente = Convert.ToDecimal(txtstockexistente.Text),
                    StockMinimo = Convert.ToDecimal(txtstockminimo.Text),
                    FechaVencimiento = txtfechavencimiento.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
                };

                // Llamar al método de edición en la capa de negocio
                bool resultado = new CN_Productos().Editar(obj, out mensaje);

                if (resultado)
                {
                    MessageBox.Show("Producto editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
