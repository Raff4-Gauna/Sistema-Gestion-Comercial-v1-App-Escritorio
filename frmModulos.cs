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

namespace CapaPresentación
{
    public partial class frmModulos : Form
    {
        private static Usuario usuarioActual;
        private List<Permiso> ListaPermisos;
        public frmModulos(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
            ListaPermisos = new CN_Permiso().listar(usuarioActual.IdUsuario);
        }

        private bool TienePermiso(string nombreModulo)
        {
            // Verifica si el usuario actual tiene permisos para el módulo especificado
            return ListaPermisos.Any(m => m.NombreMenu == nombreModulo);
        }

        private void mdConfiguracion_Click(object sender, EventArgs e)
        {
            if (TienePermiso("mdConfiguracion"))
            {
                frmConfiguracion ajustesForm = new frmConfiguracion();
                ajustesForm.Show();
            }
            else
            {
                // Muestra un mensaje o toma alguna acción adecuada si no tiene permisos
                MessageBox.Show("No tiene permisos para acceder a este módulo.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
