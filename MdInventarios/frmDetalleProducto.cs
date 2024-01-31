using CapaEntidad;
using CapaNegocio;
using CapaDatos;
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
using System.IO;
using System.Globalization;


namespace CapaPresentación.MdInventarios
{
    public partial class frmDetalleProducto : Form
    {
        public Productos _Productos { get; set; }

        // Constructor que recibe el ID del producto
        public frmDetalleProducto(string id)
        {
            InitializeComponent();
        }

        private void frmDetalleProducto_Load(object sender, EventArgs e)
        {

           

            //-------------------------------------- PARA LOS ESTADOS -------------------------
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            //-------------------------------------- PARA Listar categorias -------------------------
            List<Categorias> Listacategoria = new CN_Categorias().Listar();

            foreach (Categorias item in Listacategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.NombreCategoria });
            }
            cbocategoria.DisplayMember = "Texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 0;

            //-------------------------------------- PARA  ListaSubCategorias-------------------------
            List<SubCategorias> ListaSubCategorias = new CN_SubCategoria().Listar();

            foreach (SubCategorias item in ListaSubCategorias)
            {
                cbosubcategoria.Items.Add(new OpcionCombo() { Valor = item.IdSubcategoria, Texto = item.NombreSubcategoria });
            }
            cbosubcategoria.DisplayMember = "Texto";
            cbosubcategoria.ValueMember = "Valor";
            cbosubcategoria.SelectedIndex = 0;

            //-------------------------------------- PARA  TasaImpuestos-------------------------
            List<TasaImpuestos> ListaTasaImpuestos = new CN_Tasa_Impuesto().Listar();

            foreach (TasaImpuestos item in ListaTasaImpuestos)
            {
                cboimpuestos.Items.Add(new OpcionCombo() { Valor = item.IdTasaImpuesto, Texto = item.Porcentaje.ToString() });
            }

            cboimpuestos.DisplayMember = "Texto";
            cboimpuestos.ValueMember = "Valor";
            cboimpuestos.SelectedIndex = 0;


            //-------------------------------------- PARA  TiposUnidades-------------------------
            List<TiposUnidades> ListaTiposUnidades = new CN_Tipos_Unidades().Listar();

            foreach (TiposUnidades item in ListaTiposUnidades)
            {
                cbotipounidad.Items.Add(new OpcionCombo() { Valor = item.IdTipoUnidad, Texto = item.NombreTipoUnidad });
            }
            cbotipounidad.DisplayMember = "Texto";
            cbotipounidad.ValueMember = "Valor";
            cbotipounidad.SelectedIndex = 0;

            //-------------------------------------- PARA  TiposUnidades-------------------------
            List<Proveedor> ListaProveedor = new CN_Proveedor().Listar();

            foreach (Proveedor item in ListaProveedor)
            {
                cboproveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });
            }
            cboproveedor.DisplayMember = "Texto";
            cboproveedor.ValueMember = "Valor";
            cboproveedor.SelectedIndex = 0;

        }

    }
}
