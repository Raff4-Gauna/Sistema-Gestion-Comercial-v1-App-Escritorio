using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaPresentación.MdVentas.Modal
{
    public partial class frmAperturaCaja : Form
    {

        private Usuario usuarioActual;
        private int idAperturaCaja = 0;

        //--------------------------------------

        // Mantener activa solo una ventana y evitar duplicidad
        private static frmAperturaCaja instancia = null;

        public static frmAperturaCaja ventana_unica(Usuario oUsuario = null)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmAperturaCaja(oUsuario);
            }
            return instancia;
        }
        
        public frmAperturaCaja(Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmEstadoCaja_Load(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual.NombreCompleto;

            txtMontoIncialCaja.Select();

        }

        private void txtMontoIncialCaja_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de datos
                if (!decimal.TryParse(txtMontoIncialCaja.Text, out decimal montoInicial))
                {
                    MessageBox.Show("El monto inicial ingresado no es válido.");
                    return;
                }

                // Registro de apertura de caja
                AperturaCaja obj = new AperturaCaja()
                {
                    MontoInicial = montoInicial,
                    oUsuario = usuarioActual
                };

                string mensaje = string.Empty;
                idAperturaCaja = new CN_Apertura_Caja().AperturaCaja(obj, out mensaje); // Asignar el idAperturaCaja

                if (idAperturaCaja != 0)
                {
                    MessageBox.Show("Apertura de caja realizada con éxito.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar apertura de caja: {ex.Message}");
            }
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el idUsuario del usuario actual
                int idUsuario = usuarioActual.IdUsuario;

                // Realizar el cierre de caja
                int resultadoCierre;
                string mensajeCierre = ""; // Inicializar el parámetro mensaje

                new CN_Apertura_Caja().CierreCaja(idUsuario, out resultadoCierre, out mensajeCierre);

                if (resultadoCierre == 1)
                {
                    MessageBox.Show("Cierre de caja realizado con éxito.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensajeCierre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el cierre de caja: {ex.Message}");
            }
        }
    }
}
