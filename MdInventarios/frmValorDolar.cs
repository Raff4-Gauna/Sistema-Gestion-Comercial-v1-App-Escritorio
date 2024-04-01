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
using System.Net.Http;

namespace CapaPresentación.MdInventarios
{
    public partial class frmValorDolar : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmValorDolar instancia = null;

        private CD_Api_Dolar apiDolar = new CD_Api_Dolar(); // Instancia de la clase CD_Api_Dolar

        public static frmValorDolar ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmValorDolar();
            }
            return instancia;
        }


        public frmValorDolar()
        {
            InitializeComponent();
        }

        private void frmValorDolar_Load(object sender, EventArgs e)
        {

        }

        private async void bntBuscarPreDolar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la respuesta JSON de la API
                string respuestaJson = await apiDolar.ConsultarPrecioDolarAsync();

                // Deserializar la respuesta JSON a un objeto DolarRespuesta
                dynamic dolar = Newtonsoft.Json.JsonConvert.DeserializeObject(respuestaJson);

                // Actualizar los labels con los datos recibidos
                lblMoneda.Text = dolar.moneda;
                lblCompraDolar.Text = dolar.compra.ToString("N2");
                lblVentaDolar.Text = dolar.venta.ToString("N2");
                lblFechaActualizada.Text = dolar.fechaActualizacion.ToString();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error al consultar el precio del dólar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido al consultar el precio del dólar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
