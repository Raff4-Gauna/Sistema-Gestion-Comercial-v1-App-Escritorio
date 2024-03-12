using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaPresentación.FomsModulos;
using FontAwesome.Sharp;
using CapaPresentación.Usos;

namespace CapaPresentación
{
    public partial class frmModulos : Form
    {
        private static Usuario ousuario;
        private List<Permiso> ListaPermisos;
        private LicenciaCaducidad licenciaCaducidad;
        public frmModulos(Usuario objusuario)
        {
            ousuario = objusuario;
            InitializeComponent();
            ListaPermisos = new CN_Permiso().listar(objusuario.IdUsuario);
        }

        private void frmModulos_Load(object sender, EventArgs e)
        {
            ListaPermisos = new CN_Permiso().listar(ousuario.IdUsuario);
            lblusuario.Text = ousuario.NombreCompleto;

            // Obtener información de la licencia al cargar el formulario
            licenciaCaducidad = new CN_LicenciaCaducidad().ObtenerInformacionLicencia();

            // Actualizar el estado de los botones según la licencia
            ActualizarEstadoBotones();
        }
        private bool TienePermiso(string nombreModulo)
        {
            // Verifica si el usuario actual tiene permisos para el módulo especificado
            return ListaPermisos.Any(m => m.NombreMenu == nombreModulo);
        }

        public void ActualizarEstadoBotones()
        {
            try
            {
                // Verificar si la licencia está activa y actualizar el estado de los botones
                if (licenciaCaducidad.EstaActiva())
                {
                    mdConfiguracion.Enabled = true;
                    mdSocios.Enabled = true;
                    mdInventarios.Enabled = true;
                    mdVentas.Enabled = true;
                    mdCompras.Enabled = true;
                    mdReportes.Enabled = true;
                }
                else
                {
                    mdConfiguracion.Enabled = false;
                    mdSocios.Enabled = false;
                    mdInventarios.Enabled = false;
                    mdVentas.Enabled = false;
                    mdCompras.Enabled = false;
                    mdReportes.Enabled = false;
                    // La licencia ha caducado, mostrar un mensaje
                    MessageBox.Show("¡La licencia ha caducado! Por favor, renueve su licencia para seguir utilizando el sistema.", "Licencia Caducada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejo de error: Puedes mostrar un mensaje de error, loggear la excepción o realizar otra acción según tus necesidades
                Console.WriteLine($"Error en método ActualizarEstadoBotones: {ex.Message}");
            }
        }

        private void mdConfiguracion_Click(object sender, EventArgs e)
        {
            // Verificar si tiene permisos y si la licencia está activa
            if (TienePermiso("mdConfiguracion") && licenciaCaducidad.EstaActiva())
            {
                frmConfiguracion ajustesForm = frmConfiguracion.ventana_unica_p_modulo();
                ajustesForm.Show();
                ajustesForm.BringToFront();
            }
            else
            {
                // Muestra un mensaje o toma alguna acción adecuada si no tiene permisos
                MessageBox.Show("No tiene permisos para acceder a este módulo.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mdSocios_Click(object sender, EventArgs e)
        {
            if (TienePermiso("mdSocios") && licenciaCaducidad.EstaActiva())
            {
                frmSocios sociosForm = frmSocios.ventana_unica_p_modulo();
                sociosForm.Show();
                sociosForm.BringToFront();
            }
            else
            {
                // Muestra un mensaje o toma alguna acción adecuada si no tiene permisos
                MessageBox.Show("No tiene permisos para acceder a este módulo.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mdInventarios_Click(object sender, EventArgs e)
        {
            if (TienePermiso("mdInventarios") && licenciaCaducidad.EstaActiva())
            {
                frmInventarios inventariosForm = frmInventarios.ventana_unica_p_modulo();
                inventariosForm.Show();
                inventariosForm.BringToFront();
            }
            else
            {
                // Muestra un mensaje o toma alguna acción adecuada si no tiene permisos
                MessageBox.Show("No tiene permisos para acceder a este módulo.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mdVentas_Click(object sender, EventArgs e)
        {
            if (TienePermiso("mdVentas") && licenciaCaducidad.EstaActiva())
            {
                frmVentas ventasForm = new frmVentas(ousuario);
                ventasForm.Show();
            }
            else
            {
                // Muestra un mensaje o toma alguna acción adecuada si no tiene permisos
                MessageBox.Show("No tiene permisos para acceder a este módulo.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mdCompras_Click(object sender, EventArgs e)
        {
            if (TienePermiso("mdCompras") && licenciaCaducidad.EstaActiva())
            {
                frmCompras comprasForm = new frmCompras(ousuario);
                comprasForm.Show();
            }
            else
            {
                // Muestra un mensaje o toma alguna acción adecuada si no tiene permisos
                MessageBox.Show("No tiene permisos para acceder a este módulo.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mdReportes_Click(object sender, EventArgs e)
        {
            if (TienePermiso("mdReportes") && licenciaCaducidad.EstaActiva())
            {
                frmReportes reportesForm = frmReportes.ventana_unica_p_modulo();
                reportesForm.Show();
                reportesForm.BringToFront();
            }
            else
            {
                // Muestra un mensaje o toma alguna acción adecuada si no tiene permisos
                MessageBox.Show("No tiene permisos para acceder a este módulo.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mdLicencia_Click(object sender, EventArgs e)
        {
            if (TienePermiso("mdLicencia"))
            {
                frmLicencia licenciaForm = frmLicencia.ventana_unica_p_modulo();
                licenciaForm.Show();
                licenciaForm.BringToFront();
            }
            else
            {
                // Muestra un mensaje o toma alguna acción adecuada si no tiene permisos
                MessageBox.Show("No tiene permisos para acceder a este módulo.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
