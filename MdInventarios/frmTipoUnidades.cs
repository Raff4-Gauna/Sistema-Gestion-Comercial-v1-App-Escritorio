using CapaEntidad;
using CapaNegocio;
using CapaPresentación.Usos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.MdInventarios
{
    public partial class frmTipoUnidades : Form
    {
        public frmTipoUnidades()
        {
            InitializeComponent();
        }

        private void frmTipoUnidades_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {

                }
            }


            //Mostrar todos las unidades de medidas

            List<TiposUnidades> Lista = new CN_Tipos_Unidades().Listar();

            foreach (TiposUnidades item in Lista)
            {
                dgvdata.Rows.Add(new object[] {"", item.IdTipoUnidad, item.NombreTipoUnidad
                });
            }
        }

        private void txtNombreUnidad_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtNombreUnidad.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtNombreUnidad.Text = txtNombreUnidad.Text.ToUpper();

            // Restaurar la posición del cursor
            txtNombreUnidad.SelectionStart = posicionCursor;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            TiposUnidades obj = new TiposUnidades()
            {
                IdTipoUnidad = Convert.ToInt32(txtid.Text),
                NombreTipoUnidad = txtNombreUnidad.Text
            };

            if (obj.IdTipoUnidad == 0)
            {

                int idgenerado = new CN_Tipos_Unidades().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"", idgenerado, txtNombreUnidad.Text
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new CN_Tipos_Unidades().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["NombreTipoUnidad"].Value = txtNombreUnidad.Text;
             
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtNombreUnidad.Text = "";
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombreUnidad.Text = dgvdata.Rows[indice].Cells["NombreTipoUnidad"].Value.ToString();
                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la unidad de medida", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    TiposUnidades obj = new TiposUnidades()
                    {
                        IdTipoUnidad = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Tipos_Unidades().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
