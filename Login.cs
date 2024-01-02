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
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                picLogo.Image = ByteToImage(byteimage);
        }
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdocumento.Text) || string.IsNullOrEmpty(txtclave.Text))
            {
                MessageBox.Show("Ingrese documento y clave", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                List<Usuario> listaUsuarios = new CN_Usuario().listar();


                Usuario usuarioEncontrado = listaUsuarios
                    .FirstOrDefault(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text);

                if (usuarioEncontrado != null)
                {
                    frmModulos form = new frmModulos(usuarioEncontrado);

                    form.Show();
                    this.Hide();


                    form.FormClosing += frm_closing;
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar ingresar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {

            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
