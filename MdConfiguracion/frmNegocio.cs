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
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using CapaPresentación.MdConfiguracion;



namespace CapaPresentación.MdConfiguracion
{
    public partial class frmNegocio : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmNegocio instancia = null;

        public static frmNegocio ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmNegocio();
            }
            return instancia;
        }

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

            //Mostrar datos de las credenciales de correo smtp
            Smtp datosSmpt = new CN_Smtp().ObtenerDatosSmtp();
            txtRemitente.Text = datosSmpt.EmailRemitente;
            txtContraseña.Text = datosSmpt.ContraseñaRemitente;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtnombre.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtnombre.Text = txtnombre.Text.ToUpper();

            // Restaurar la posición del cursor
            txtnombre.SelectionStart = posicionCursor;
        }
        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar la entrada del carácter si no es un número
                e.Handled = true;
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

        private void btnGuardarCredenCorreo_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Smtp obj = new Smtp()
            {
                EmailRemitente = txtRemitente.Text,
                ContraseñaRemitente = txtContraseña.Text,
            };

            bool respuesta = new CN_Smtp().GuardarDatosSmtp(obj, out mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEnviaCorreo_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Dirección de correo del destinatario
                string destinatario = txtDestinatario.Text;

                // Obtener la configuración del correo desde la base de datos
                Smtp configuracionSmtp = new CN_Smtp().ObtenerDatosSmtp();

                if (configuracionSmtp != null)
                {
                    // Usar la configuración obtenida para el remitente y la contraseña
                    string remitente = configuracionSmtp.EmailRemitente;
                    string contraseña = configuracionSmtp.ContraseñaRemitente;

                    // Contenido del mensaje
                    string mensajeContenido = txtMensaje.Text;

                    // Crear el mensaje
                    MailMessage mensaje = new MailMessage(remitente, destinatario, "Asunto del correo", mensajeContenido);

                    // Configurar el cliente SMTP
                    SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
                    clienteSmtp.Port = 587;
                    clienteSmtp.Credentials = new NetworkCredential(remitente, contraseña);
                    clienteSmtp.EnableSsl = true;

                    // Enviar el correo
                    clienteSmtp.Send(mensaje);

                    MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró la configuración del correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }

}
