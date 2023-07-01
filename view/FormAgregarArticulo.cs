using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class FormAgregarArticulo : Form
    {
       
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }
        
        private void FromAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cbxIdMarcaAlta.DataSource = marcaNegocio.listar();
                cbxIdMarcaAlta.ValueMember = "id";
                cbxIdMarcaAlta.DisplayMember = "descripcion";
                cbxIdCategoriaAlta.DataSource = categoriaNegocio.listar();
                cbxIdCategoriaAlta.ValueMember = "id";
                cbxIdCategoriaAlta.DisplayMember = "descripcion";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(tbxPrecioAlta.Text))
            {
                MessageBox.Show("Debe cargar el campo...");
                return true;
            }
            return false;
        }

        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
          
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo(); 
            try
            {
                if (validar())
                {
                    return;
                }

                articulo.codigo = tbxCodigoAlta.Text;
                articulo.nombre = tbxNombreAlta.Text;
                articulo.descripcion = tbxDescripcionAlta.Text;
                articulo.marca = (Marca)cbxIdMarcaAlta.SelectedItem;
                articulo.categoria = (Categoria)cbxIdCategoriaAlta.SelectedItem;
                articulo.imagen = tbxImagenAlta.Text;
                articulo.precio = decimal.Parse(tbxPrecioAlta.Text);
               
                negocio.agregar(articulo);
                MessageBox.Show("Agregado correctamente");
                
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxImagenAlta_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxImagenAlta.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenAlta.Load(imagen);
            }
            catch (Exception)
            {

                pbxImagenAlta.Load("https://i1.wp.com/gelatologia.com/wp-content/uploads/2020/07/placeholder.png?ssl=1");
            }
        }
    }
}
