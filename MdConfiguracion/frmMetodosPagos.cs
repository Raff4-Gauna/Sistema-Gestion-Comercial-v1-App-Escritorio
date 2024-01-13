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


namespace CapaPresentación.MdConfiguracion
{
    public partial class frmMetodosPagos : Form
    {
        public frmMetodosPagos()
        {
            InitializeComponent();
        }

        private void frmMetodosPagos_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Alta" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Baja" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {

                }
            }


            //Mostrar todos los Metodos de Pagos

            List<MetodosPagos> Lista = new CN_Metodos_Pagos().Listar();

            foreach (MetodosPagos item in Lista)
            {

                dgvdata.Rows.Add(new object[] {"", item.IdMetodosPagos, item.NombreMetodo, item.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Alta" : "Baja"
                });

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            MetodosPagos obj = new MetodosPagos()
            {
                IdMetodosPagos = Convert.ToInt32(txtid.Text),
                NombreMetodo = txtNombreMetodo.Text,
                Descripcion = txtDescripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false

            };

            if (obj.IdMetodosPagos == 0)
            {

                int idgenerado = new CN_Metodos_Pagos().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"", idgenerado, txtNombreMetodo.Text, txtDescripcion.Text,


                    ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
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
                bool resultado = new CN_Metodos_Pagos().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["NombreMetodo"].Value = txtNombreMetodo.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

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
            txtNombreMetodo.Text = "";
            txtDescripcion.Text = "";
            cboestado.SelectedIndex = 0;
            txtNombreMetodo.Select();
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
                    txtNombreMetodo.Text = dgvdata.Rows[indice].Cells["NombreMetodo"].Value.ToString();
                    txtDescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo oc in cboestado.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }

                    }
                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el método de pago", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    MetodosPagos obj = new MetodosPagos()
                    {
                        IdMetodosPagos = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Metodos_Pagos().Eliminar(obj, out mensaje);

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

        private void txtNombreMetodo_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtNombreMetodo.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtNombreMetodo.Text = txtNombreMetodo.Text.ToUpper();

            // Restaurar la posición del cursor
            txtNombreMetodo.SelectionStart = posicionCursor;
        }
    }
}
