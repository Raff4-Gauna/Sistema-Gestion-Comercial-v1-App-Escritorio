using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace CapaPresentación.MdConfiguracion
{
    public partial class frmRespaldo : Form
    {

        public frmRespaldo()
        {
            InitializeComponent();

        }

        private void txtSeleccionarUbi_TextChanged(object sender, EventArgs e)
        {
            txtUbicacionActual.Text = txtSeleccionarUbi.Text;
        }

        private void BackupDatabase(string backupFilePath)
        {
            try
            {
                // Obtener la cadena de conexión desde el archivo de configuración
                string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

                // Obtener el nombre de la base de datos desde la cadena de conexión
                string databaseName = new SqlConnectionStringBuilder(connectionString).InitialCatalog;

                // Crear un objeto SqlConnection y abrir la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crear un objeto SqlCommand para ejecutar el comando BACKUP DATABASE
                    SqlCommand command = new SqlCommand($"BACKUP DATABASE {databaseName} TO DISK = @backupFilePath", connection);

                    // Agregar el parámetro de la ubicación del archivo de respaldo
                    command.Parameters.AddWithValue("@backupFilePath", backupFilePath);

                    // Ejecutar el comando BACKUP DATABASE
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo crear el respaldo de la base de datos. Error: " + ex.Message);
            }
        }

        private void RestoreDatabase(string backupFilePath)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
                string databaseName = new SqlConnectionStringBuilder(connectionString).InitialCatalog;

                // Construir el script SQL con StringBuilder para mejorar la legibilidad
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.AppendLine("USE [master];");
                queryBuilder.AppendLine($"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;");
                queryBuilder.AppendLine($"RESTORE DATABASE [{databaseName}] FROM DISK = @backupFilePath WITH REPLACE;");
                queryBuilder.AppendLine($"ALTER DATABASE [{databaseName}] SET MULTI_USER;");

                string query = queryBuilder.ToString();

                // Utilizar using para la conexión y el comando
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@backupFilePath", backupFilePath);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("La base de datos se ha restaurado correctamente desde el archivo de respaldo seleccionado.", "Restauración de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al restaurar la base de datos: " + ex.Message, "Restauración de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime now = DateTime.Now;

            // Construir el nombre del archivo de respaldo
            string fileName = "Backup_" + DateTime.Now.ToString("HH-mm-dd-MM-yyyy") + ".bak";

            // Abrir un cuadro de diálogo para que el usuario seleccione la ubicación donde se creará el archivo de respaldo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
            saveFileDialog.Title = "Guardar respaldo";
            saveFileDialog.FileName = fileName; // Establecer el nombre del archivo predeterminado

            // Si el usuario seleccionó una ubicación para el archivo de respaldo, iniciar el proceso de respaldo
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // El usuario seleccionó una ubicación para el archivo de respaldo
                try
                {
                    BackupDatabase(saveFileDialog.FileName);
                    MessageBox.Show("El respaldo se ha creado correctamente.", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear el respaldo de la base de datos. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSeleccionarUbic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de respaldo de base de datos (*.bak)|*.bak";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupFilePath = openFileDialog.FileName;
                txtSeleccionarUbi.Text = backupFilePath;
            }
        }

        private void bntRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                string backupFilePath = txtUbicacionActual.Text;
                if (string.IsNullOrEmpty(backupFilePath))
                {
                    throw new Exception("Debes seleccionar un archivo de respaldo de la base de datos.");
                }

                if (!File.Exists(backupFilePath))
                {
                    throw new Exception("El archivo de respaldo seleccionado no existe en la ubicación especificada.");
                }

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas restaurar la base de datos? Esto sobrescribirá la base de datos existente.", "Confirmación de restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    RestoreDatabase(backupFilePath);
                    MessageBox.Show("La base de datos se ha restaurado correctamente desde el archivo de respaldo seleccionado.", "Restauración de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al restaurar la base de datos: " + ex.Message, "Restauración de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
