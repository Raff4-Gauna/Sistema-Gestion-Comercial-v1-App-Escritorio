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
using CapaPresentación.Usos;

namespace CapaPresentación.MdLicencia
{
    public partial class frmAjustesLicencia : Form
    {
        public frmAjustesLicencia()
        {
            InitializeComponent();
        }

        private void frmAjustesLicencia_Load(object sender, EventArgs e)
        {
            // Obtén y muestra la información de la licencia actual al cargar el formulario
            MostrarInformacionLicenciaActual();
        }

        private void MostrarInformacionLicenciaActual()
        {
            // Llama al método ObtenerInformacionLicencia que es la query para verificar datos de la licencia
            LicenciaCaducidad licenciaActual = new CN_LicenciaCaducidad().ObtenerInformacionLicencia();

            // Muestra la información en el formulario (por ejemplo, en etiquetas o controles TextBox)
             lblFechaInicioActual.Text = licenciaActual.FechaInicio.ToString("dd/MM/yyyy");
             lblFechaFinActual.Text = licenciaActual.FechaFin.ToString("dd/MM/yyyy");
             lblDiasDiferenciaActual.Text = licenciaActual.DiasDiferencia.ToString();

        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén las fechas de los DateTimePicker
                DateTime fechaInicio = txtfechainicio.Value;
                DateTime fechaFin = txtfechafin.Value;

                // Llama al método RegistrarFechaInicioFin para establecer una nueva fecha de inicio y fecha fin como periodo de uso del sistema
                new CN_LicenciaCaducidad().RegistrarFechaInicioFin(fechaInicio, fechaFin, out string mensaje);

                // Muestra el mensaje resultante (puede ser un mensaje de éxito o de error)
                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualiza la información de la licencia actual en el formulario principal
                MostrarInformacionLicenciaActual();
            }
            catch (Exception ex)
            {
                // Manejo de error: Muestra un mensaje de error al usuario o realiza alguna otra acción según tus necesidades
                MessageBox.Show($"Se ha producido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
