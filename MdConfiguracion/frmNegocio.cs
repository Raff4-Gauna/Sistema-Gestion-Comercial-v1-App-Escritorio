using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.MdConfiguracion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            //Obtener datos del negocio al cargar el formulario
            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                picLogo.Image = ByteToImage(byteimage);

            Negocio datos = new CN_Negocio().ObtenerDatos();

            txtnombre.Text = datos.Nombre;
            txttelefono.Text = datos.Telefono;
            txtdireccion.Text = datos.Direccion;
            txttitular.Text = datos.Titular;
            txtcuit.Text = datos.CUIT;
            txtingresosbrutos.Text = datos.NumIngresosBrutos;

            //Mostrar todas las impresoras
            foreach (string Impresora in PrinterSettings.InstalledPrinters)
            {
                cbolistadoimpresoras.Items.Add(Impresora);
            }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                    picLogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                Nombre = txtnombre.Text,
                Telefono = txttelefono.Text,
                Direccion = txtdireccion.Text,
                Titular = txttitular.Text,
                CUIT = txtcuit.Text,
                NumIngresosBrutos = txtingresosbrutos.Text,
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
