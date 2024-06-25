using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaPresentación.MdVentas.Modal
{
    public partial class frmEstadoCaja : Form
    {
        private CN_Apertura_Caja negocioAperturaCaja;

        private Usuario usuarioActual;
        private int idAperturaCaja = 0;

        //--------------------------------------

        // Mantener activa solo una ventana y evitar duplicidad
        private static frmEstadoCaja instancia = null;

        public static frmEstadoCaja ventana_unica(Usuario oUsuario = null)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmEstadoCaja(oUsuario);
            }
            return instancia;
        }

        public frmEstadoCaja(Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
            negocioAperturaCaja = new CN_Apertura_Caja();
        }

        private void frmEstadoCaja_Load(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual.NombreCompleto;

        }

        private void bntConsultarEstaCaja_Click(object sender, EventArgs e)
        {
            //string mensaje;
            //CD_Apertura_Caja objcd_Apertura_Caja = new CD_Apertura_Caja();
            //List<CD_Apertura_Caja.AperturaCajaAbierta> aperturasCajaAbiertas = objcd_Apertura_Caja.ObtenerAperturasCajaAbiertas(out mensaje);

            //// Verificar si hay algún mensaje de error
            //if (!string.IsNullOrEmpty(mensaje))
            //{
            //    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Mostrar los resultados en los labels
            //if (aperturasCajaAbiertas.Count > 0)
            //{
            //    CD_Apertura_Caja.AperturaCajaAbierta primeraApertura = aperturasCajaAbiertas[0];
            //    lblUsuarioApt.Text = primeraApertura.Usuario;
            //    lblEstadoCaja.Text = primeraApertura.EstadoCaja;
            //    lblFechaApertura.Text = primeraApertura.FechaDeApertura.ToString();
            //}
            //else
            //{
            //    // No hay aperturas de caja abiertas
            //    lblUsuarioApt.Text = "No hay";
            //    lblEstadoCaja.Text = "No hay";
            //    lblFechaApertura.Text = "No hay";
            //}

            string mensaje;
            CD_Apertura_Caja objcd_Apertura_Caja = new CD_Apertura_Caja();
            List<CD_Apertura_Caja.AperturaCajaAbierta> aperturasCajaAbiertas = objcd_Apertura_Caja.ObtenerAperturasCajaAbiertas(out mensaje);

            // Verificar si hay algún mensaje de error
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar el DataGridView antes de llenarlo
            dgvdata.Rows.Clear();

            // Llenar el DataGridView con los resultados
            foreach (var apertura in aperturasCajaAbiertas)
            {
                dgvdata.Rows.Add(apertura.Usuario, apertura.EstadoCaja, apertura.FechaDeApertura.ToString());
            }

            // Mostrar un mensaje si no hay aperturas de caja abiertas
            if (aperturasCajaAbiertas.Count == 0)
            {
                MessageBox.Show("No hay aperturas de caja abiertas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
