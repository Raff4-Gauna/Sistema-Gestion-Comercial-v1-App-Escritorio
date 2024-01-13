﻿using CapaEntidad;
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
    public partial class frmTasaImpuestos : Form
    {
        public frmTasaImpuestos()
        {
            InitializeComponent();
        }

        private void frmTasaImpuestos_Load(object sender, EventArgs e)
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


            //Mostrar todos las Sucursales

            List<TasaImpuestos> Lista = new CN_Tasa_Impuesto().Listar();

            foreach (TasaImpuestos item in Lista)
            {

                dgvdata.Rows.Add(new object[] {"", item.IdTasaImpuesto, item.NombreTasa, item.Porcentaje, item.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Alta" : "Baja"
                });

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            TasaImpuestos obj = new TasaImpuestos()
            {
                IdTasaImpuesto = Convert.ToInt32(txtid.Text),
                NombreTasa = txtNombreTasa.Text,
                Porcentaje = txtPorcentaje.Text,
                Descripcion = txtDescripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false

            };

            if (obj.IdTasaImpuesto == 0)
            {

                int idgenerado = new CN_Tasa_Impuesto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"", idgenerado, txtNombreTasa.Text, txtPorcentaje.Text, txtDescripcion.Text,


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
                bool resultado = new CN_Tasa_Impuesto().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["NombreTasa"].Value = txtNombreTasa.Text;
                    row.Cells["Porcentaje"].Value = txtPorcentaje.Text;
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
            txtNombreTasa.Text = "";
            txtPorcentaje.Text = "";
            txtDescripcion.Text = "";
            cboestado.SelectedIndex = 0;
            txtNombreTasa.Select();
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
                    txtNombreTasa.Text = dgvdata.Rows[indice].Cells["NombreTasa"].Value.ToString();
                    txtPorcentaje.Text = dgvdata.Rows[indice].Cells["Porcentaje"].Value.ToString();
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
                if (MessageBox.Show("¿Desea eliminar la tasa de impuesto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    TasaImpuestos obj = new TasaImpuestos()
                    {
                        IdTasaImpuesto = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Tasa_Impuesto().Eliminar(obj, out mensaje);

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

        private void txtNombreTasa_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtNombreTasa.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtNombreTasa.Text = txtNombreTasa.Text.ToUpper();

            // Restaurar la posición del cursor
            txtNombreTasa.SelectionStart = posicionCursor;
        }
    }
}
