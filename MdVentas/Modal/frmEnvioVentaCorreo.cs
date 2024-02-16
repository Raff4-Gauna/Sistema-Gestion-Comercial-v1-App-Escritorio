using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System.Net;
using System.Net.Mail;
using System.IO;



namespace CapaPresentación.MdVentas.Modal
{
    public partial class frmEnvioVentaCorreo : Form
    {
        private Venta venta;
        private MemoryStream pdfStream;

        public frmEnvioVentaCorreo(Venta venta, MemoryStream pdfStream)
        {
            InitializeComponent();
            this.venta = venta;
            this.pdfStream = pdfStream;
        }

        private void frmEnvioVentaCorreo_Load(object sender, EventArgs e)
        {
            txtemaildestino.Select();
        }
        
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // Dirección de correo del destinatario
                string destinatario = txtemaildestino.Text;

                // Verificar si se ingresó una dirección de correo destinataria
                if (string.IsNullOrEmpty(destinatario))
                {
                    MessageBox.Show("Por favor, ingresa la dirección de correo del destinatario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si no se ingresó un destinatario
                }

                // Obtener la configuración del correo desde la base de datos
                Smtp configuracionSmtp = new CN_Smtp().ObtenerDatosSmtp();

                if (configuracionSmtp != null)
                {
                    // Usar la configuración obtenida para el remitente y la contraseña
                    string remitente = configuracionSmtp.EmailRemitente;
                    string contraseña = configuracionSmtp.ContraseñaRemitente;

                    // Contenido del mensaje
                    string mensajeContenido = txtmensaje.Text;

                    // Crear el mensaje
                    MailMessage mensaje = new MailMessage(remitente, destinatario, "Asunto del correo", mensajeContenido);

                    // Adjuntar el PDF al correo (usando una copia del MemoryStream)
                    MemoryStream pdfStreamCopy = new MemoryStream(pdfStream.ToArray());
                    mensaje.Attachments.Add(new Attachment(pdfStreamCopy, "Venta.pdf", "application/pdf"));


                    // Configurar el cliente SMTP
                    SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
                    clienteSmtp.Port = 587;
                    clienteSmtp.Credentials = new NetworkCredential(remitente, contraseña);
                    clienteSmtp.EnableSsl = true;

                    // Enviar el correo
                    clienteSmtp.Send(mensaje);

                    MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cerrar el formulario después de enviar el correo
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró la configuración del correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
