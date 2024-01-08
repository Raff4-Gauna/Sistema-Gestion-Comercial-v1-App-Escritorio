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

namespace CapaPresentación.MdSocios
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<TipoContribuyentes> ListaTipoContribuyentes = new CN_Tipo_Contribuyentes().Listar();

            foreach (TipoContribuyentes item in ListaTipoContribuyentes)
            {
                cboTipoContribuyente.Items.Add(new OpcionCombo() { Valor = item.IdTipoContribuyentes, Texto = item.Contribuyente });
            }
            cboTipoContribuyente.DisplayMember = "Texto";
            cboTipoContribuyente.ValueMember = "Valor";
            cboTipoContribuyente.SelectedIndex = 0;

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


            //Mostrar todos los usuarios

            List<Clientes> Lista = new CN_Clientes().Listar();

            foreach (Clientes item in Lista)
            {

                dgvdata.Rows.Add(new object[] {"", 
                    item.IdCliente, 
                    item.oTipoContribuyentes.IdTipoContribuyentes,
                    item.oTipoContribuyentes.Contribuyente,
                    item.NombreCompleto, 
                    item.Documento, 
                    item.CUIT,
                    item.Correo, 
                    item.Telefono,
                    item.Notas,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });

            }

            // metodo de sumar todos los clientes
            SumarClientes();

        }
        private void txtnombrecompleto_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtnombrecompleto.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtnombrecompleto.Text = txtnombrecompleto.Text.ToUpper();

            // Restaurar la posición del cursor
            txtnombrecompleto.SelectionStart = posicionCursor;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Clientes obj = new Clientes()
            {
                IdCliente = Convert.ToInt32(txtid.Text),
                oTipoContribuyentes = new TipoContribuyentes() { IdTipoContribuyentes = Convert.ToInt32(((OpcionCombo)cboTipoContribuyente.SelectedItem).Valor) },
                NombreCompleto = txtnombrecompleto.Text,
                Documento = txtdocumento.Text,
                CUIT = txtcuit.Text,
                Correo = txtcorreo.Text,
                Telefono = txttelefono.Text,
                Notas = txtNotas.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false

            };

            if (obj.IdCliente == 0)
            {

                int idgenerado = new CN_Clientes().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {
                        "", 
                        idgenerado,
                        ((OpcionCombo)cboTipoContribuyente.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboTipoContribuyente.SelectedItem).Texto.ToString(),
                        txtnombrecompleto.Text, 
                        txtdocumento.Text,
                        txtcuit.Text,
                        txtcorreo.Text, 
                        txttelefono.Text,
                        txtNotas.Text,

                        ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                    // metodo de sumar todos los clientes
                    SumarClientes();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new CN_Clientes().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["IdTipoContribuyentes"].Value = ((OpcionCombo)cboTipoContribuyente.SelectedItem).Valor.ToString();
                    row.Cells["TipoContribuyentes"].Value = ((OpcionCombo)cboTipoContribuyente.SelectedItem).Texto.ToString();
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["CUIT"].Value = txtcuit.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Telefono"].Value = txttelefono.Text;
                    row.Cells["Notas"].Value = txtNotas.Text;
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
            txtnombrecompleto.Text = "";
            txtdocumento.Text = "";
            txtcuit.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";
            txtNotas.Text = "";
            cboTipoContribuyente.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
            txtdocumento.Select();
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

                    foreach (OpcionCombo oc in cboTipoContribuyente.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdTipoContribuyentes"].Value))
                        {
                            int indice_combo = cboTipoContribuyente.Items.IndexOf(oc);
                            cboTipoContribuyente.SelectedIndex = indice_combo;
                            break;
                        }

                    }

                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtcuit.Text = dgvdata.Rows[indice].Cells["CUIT"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txttelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtNotas.Text = dgvdata.Rows[indice].Cells["Notas"].Value.ToString();

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
                if (MessageBox.Show("¿Desea eliminar el cliente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Clientes obj = new Clientes()
                    {
                        IdCliente = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Clientes().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                        // metodo de sumar todos los clientes
                        SumarClientes();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                GenerateRandomNumbers();
            }
        }
        private void GenerateRandomNumbers()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                sb.Append(random.Next(0, 9));
            }
            txtdocumento.Text = sb.ToString();
        }

        // metodo de sumar todos los clientes
       
        public void SumarClientes()
        {
            int Total = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                Total++;
            }

            lblTotalSucursales.Text = Total.ToString();
        }
    }
}
