using CapaEntidad;
using CapaNegocio;
using CapaPresentación.Utilidades;
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
    public partial class frmCrudCategoria : Form
    {
        public frmCrudCategoria()
        {
            InitializeComponent();
        }

        private void frmCrearCategoria_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;


            Negocio datosNegocio = new CN_Negocio().ObtenerDatos();

            if (datosNegocio != null) // Verifica que se haya obtenido un objeto Negocio
            {
                cbonegocio.Items.Add(new OpcionCombo() { Valor = datosNegocio.IdNegocio, Texto = datosNegocio.Nombre });
                cbonegocio.DisplayMember = "Texto";
                cbonegocio.ValueMember = "Valor";
                cbonegocio.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            //Mostrar todas las categorias

            List<Categorias> Lista = new CN_Categorias().Listar();

            foreach (Categorias item in Lista)
            {

                dgvdata.Rows.Add(new object[] {"",
                    item.IdCategoria,
                    item.NombreCategoria,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });

            }
            SumarCategorias();
            SumarCategoriasNoActivas();

        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtNombreCategoria.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtNombreCategoria.Text = txtNombreCategoria.Text.ToUpper();

            // Restaurar la posición del cursor
            txtNombreCategoria.SelectionStart = posicionCursor;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Categorias obj = new Categorias()
            {
                IdCategoria = Convert.ToInt32(txtid.Text),
                NombreCategoria = txtNombreCategoria.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false

            };

            if (obj.IdCategoria == 0)
            {

                int idgenerado = new CN_Categorias().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"", idgenerado, txtNombreCategoria.Text,
                    ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                    SumarCategorias();
                    SumarCategoriasNoActivas();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new CN_Categorias().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["NombreCategoria"].Value = txtNombreCategoria.Text;
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
            cbonegocio.SelectedIndex = 0;
            txtNombreCategoria.Text = "";
            cboestado.SelectedIndex = 0;
            txtNombreCategoria.Select();
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
                    txtNombreCategoria.Text = dgvdata.Rows[indice].Cells["NombreCategoria"].Value.ToString();

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
                if (MessageBox.Show("¿Desea eliminar la categoria", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categorias obj = new Categorias()
                    {
                        IdCategoria = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Categorias().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                        SumarCategorias();
                        SumarCategoriasNoActivas();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }

            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void SumarCategorias()
        {
            int Total = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                Total++;
            }

            lblTotalCategorias.Text = Total.ToString();
        }

        public void SumarCategoriasNoActivas()
        {
            int TotalNoActivas = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                // Obtén el valor de la columna EstadoValor (ajústalo según el nombre real de la columna)
                int estado = Convert.ToInt32(row.Cells["EstadoValor"].Value);

                // Verifica si el estado es "No Activo"
                if (estado == 0)
                {
                    TotalNoActivas++;
                }
            }

            lblTotalCategoriasNoActivas.Text = TotalNoActivas.ToString();
        }

    }
}
