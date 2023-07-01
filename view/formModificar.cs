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
    public partial class formModificar : Form
    {
        private Articulo articulo = null;

        public formModificar()
        {
            InitializeComponent();
        }
        public formModificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modicar Articuloxd";
        }
        private void formModificar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            cbxMarcaModificar.DataSource = marcaNegocio.listar();
            cbxMarcaModificar.ValueMember = "id";
            cbxMarcaModificar.DisplayMember = "descripcion";
            cbxCategoriaModificar.DataSource = categoriaNegocio.listar();
            cbxCategoriaModificar.ValueMember = "id";
            cbxCategoriaModificar.DisplayMember = "descripcion";
            
            if (articulo != null)
            {
                txbCodigoModificar.Text = articulo.codigo;
                txbNombreModificar.Text = articulo.nombre;  
                txbDescripcionModificar.Text = articulo.descripcion;
                cbxMarcaModificar.SelectedValue = articulo.marca.id;
                cbxCategoriaModificar.SelectedValue = articulo.categoria.id;
                txbImagenModificar.Text = articulo.imagen;
                txbPrecioModificar.Text = articulo.precio.ToString();
                //cargarImagen(articulo.imagen);
            }
        }

        private void btnAceptarModificar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            articulo.codigo = txbCodigoModificar.Text;
            articulo.nombre = txbNombreModificar.Text;
            articulo.descripcion = txbDescripcionModificar.Text;
            articulo.marca = (Marca)cbxMarcaModificar.SelectedItem;
            articulo.categoria = (Categoria)cbxCategoriaModificar.SelectedItem;
            articulo.imagen = txbImagenModificar.Text;
            articulo.precio = decimal.Parse(txbPrecioModificar.Text);

            negocio.modificar(articulo);
            MessageBox.Show("modificado correctamente");

            Close();
        }

        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
