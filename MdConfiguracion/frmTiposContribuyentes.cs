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
    public partial class frmTiposContribuyentes : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmTiposContribuyentes instancia = null;

        public static frmTiposContribuyentes ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmTiposContribuyentes();
            }
            return instancia;
        }
        public frmTiposContribuyentes()
        {
            InitializeComponent();

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

            //Mostrar los tipos de contribuyententes

            List<TipoContribuyentes> Lista = new CN_Tipo_Contribuyentes().Listar();

            foreach (TipoContribuyentes item in Lista)
            {

                dgvdata.Rows.Add(new object[] {"", item.IdTipoContribuyentes, item.Contribuyente, item.PrMaximoEfectivo,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Alta" : "Baja"
                });

            }
        }

        private void txtPrMaximoEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números y la coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Permitir solo una coma
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        // convertir a monedas
        private void txtPrMaximoEfectivo_Leave(object sender, EventArgs e)
        {
            CN_Formato_Monedas cnFormatoMonedas = new CN_Formato_Monedas();
            cnFormatoMonedas.FormatoMoneda(txtPrMaximoEfectivo);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            TipoContribuyentes obj = new TipoContribuyentes()
            {
                IdTipoContribuyentes = Convert.ToInt32(txtid.Text),
                Contribuyente = txtContribuyente.Text,
                PrMaximoEfectivo = Convert.ToDecimal(txtPrMaximoEfectivo.Text),
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false

            };

            if (obj.IdTipoContribuyentes == 0)
            {

                int idgenerado = new CN_Tipo_Contribuyentes().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"", idgenerado, txtContribuyente.Text, txtPrMaximoEfectivo.Text,


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
                bool resultado = new CN_Tipo_Contribuyentes().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Contribuyente"].Value = txtContribuyente.Text;
                    row.Cells["PrMaximoEfectivo"].Value = txtPrMaximoEfectivo.Text;
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
            txtContribuyente.Text = "";
            txtPrMaximoEfectivo.Text = "";
            cboestado.SelectedIndex = 0;
            txtContribuyente.Select();
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
                    txtContribuyente.Text = dgvdata.Rows[indice].Cells["Contribuyente"].Value.ToString();
                    txtPrMaximoEfectivo.Text = dgvdata.Rows[indice].Cells["PrMaximoEfectivo"].Value.ToString();

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
                if (MessageBox.Show("¿Desea eliminar el contribuyente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    TipoContribuyentes obj = new TipoContribuyentes()
                    {
                        IdTipoContribuyentes = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Tipo_Contribuyentes().Eliminar(obj, out mensaje);

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
