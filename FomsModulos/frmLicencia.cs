using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CapaNegocio;
using CapaEntidad;
using CapaPresentación.MdLicencia;
using CapaPresentación.Usos;
using System.Windows.Forms;


namespace CapaPresentación.FomsModulos
{
    public partial class frmLicencia : Form
    {

        // Mantener activa solo una ventana y evitar duplicidad
        private static frmLicencia instancia = null;

        public static frmLicencia ventana_unica_p_modulo(frmModulos referenciaModulos = null)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmLicencia(referenciaModulos);
                return instancia;
            }
            return instancia;
        }

        public frmLicencia(frmModulos referenciaModulos)
        {
            InitializeComponent();

        }

        private void frmLicencia_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string claveUnicaAlmacenada = new CN_LicenciaCaducidad().ObtenerClaveUnica();

            // Luego puedes comparar la clave obtenida con la ingresada por el usuario
            if (claveUnicaAlmacenada == txtClaveUnica.Text)
            {
                // La clave es correcta, puedes abrir el formulario correspondiente
                frmAjustesLicencia ajustesLicencia = new frmAjustesLicencia();
                ajustesLicencia.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
