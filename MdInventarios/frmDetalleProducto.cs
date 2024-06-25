using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaPresentación.Utilidades;
using CapaPresentación.MdSocios;
using CapaPresentación.MdConfiguracion;
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
using CapaPresentación.Properties;

namespace CapaPresentación.MdInventarios
{
    public partial class frmDetalleProducto : Form
    {
        // Declarar el delegado y el evento
        public delegate void ProductUpdatedEventHandler(object sender, EventArgs e);
        public event ProductUpdatedEventHandler ProductUpdated;

        // Método para disparar el evento
        protected virtual void OnProductUpdated()
        {
            ProductUpdated?.Invoke(this, EventArgs.Empty);
        }

        public frmDetalleProducto()
        {
            InitializeComponent();
        }
        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "Imágenes|*.jpg;*.jpeg;*.png"; // Establece los formatos de imagen permitidos

            DialogResult rs = fo.ShowDialog();

            if (rs == DialogResult.OK)
            {
                // Abre el archivo seleccionado como un flujo (Stream)
                using (FileStream fs = new FileStream(fo.FileName, FileMode.Open, FileAccess.Read))
                {
                    // Asigna el flujo al control PictureBox
                    picImgProducto.Image = Image.FromStream(fs);
                }
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Convierte la imagen a bytes antes de guardarla
            byte[] imagenBytes = null;
            if (picImgProducto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Clona la imagen antes de intentar guardarla
                    Bitmap clonedImage = new Bitmap(picImgProducto.Image);
                    clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagenBytes = ms.ToArray();
                }
            }

            // Asume que los campos de texto contienen datos válidos y deja la validación a la capa de negocio
            Productos obj = new Productos()
            {
                IdProducto = string.IsNullOrEmpty(txtid.Text) ? 0 : Convert.ToInt32(txtid.Text),
                CodigoBarras = txtcodigobarra.Text,
                Codigo = txtcodigo.Text,
                DescripcionGeneral = txtdescripciongeneral.Text,
                Imagen = imagenBytes,
                PrecioCompra = string.IsNullOrEmpty(txtpreciocompra.Text) ? 0 : Convert.ToDecimal(txtpreciocompra.Text),
                PrecioFinal = string.IsNullOrEmpty(txtpreciofinal.Text) ? 0 : Convert.ToDecimal(txtpreciofinal.Text),
                StockExistente = string.IsNullOrEmpty(txtstockexistente.Text) ? 0 : Convert.ToDecimal(txtstockexistente.Text),
                StockMinimo = string.IsNullOrEmpty(txtstockminimo.Text) ? 0 : Convert.ToDecimal(txtstockminimo.Text)
            };

            bool resultado = new CN_Productos().EditarDesdeDetalleProducto(obj, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Producto actualizado correctamente.");
                OnProductUpdated(); // Disparar el evento
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            // Actualizar la interfaz de usuario
            this.Refresh();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Productos obj = new Productos()
                    {
                        IdProducto = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Productos().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        MessageBox.Show("Producto eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OnProductUpdated(); // Disparar el evento
                        this.Close(); // Cierra el formulario solo si el producto se elimina correctamente
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
