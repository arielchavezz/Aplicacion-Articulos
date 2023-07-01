using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace view
{
    public partial class FormListado : Form
    {
        private List<Articulo> listaArticulo;
        private Articulo articulo = new Articulo();
        public FormListado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cbxFiltrar.Items.Add("Codigo");
            cbxFiltrar.Items.Add("Nombre");
            cbxFiltrar.Items.Add("Marca");
            cbxFiltrar.Items.Add("Precio");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo alta = new FormAgregarArticulo();
            alta.ShowDialog();
            cargar();

        }
        private void cargar()
        {
            ArticuloNegocio objNeg = new ArticuloNegocio();
            try
            {
                listaArticulo = objNeg.listar();
                dgvPrincipal.DataSource = objNeg.listar();
                dgvPrincipal.Columns["imagen"].Visible = false;
                dgvPrincipal.Columns["id"].Visible = false;
                pbxImagen.Load(listaArticulo[0].imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null) articulo = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
            cargarImagen(articulo.imagen);

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception )
            {

                pbxImagen.Load("https://i1.wp.com/gelatologia.com/wp-content/uploads/2020/07/placeholder.png?ssl=1");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
            
            formModificar modificar = new formModificar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("Seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                negocio.EliminarFisica(seleccionado.id);
                cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxFiltrar.SelectedItem.ToString();
            if ( opcion == "Precio")
            {
                cbxForma.Items.Clear();
                cbxForma.Items.Add("Mayor a");
                cbxForma.Items.Add("Menor a");
                cbxForma.Items.Add("Igual a");
            }
            else
            {
                cbxForma.Items.Clear();
                cbxForma.Items.Add("Comienza con");
                cbxForma.Items.Add("Termina con");
                cbxForma.Items.Add("Contiene");

            }

        }

        private bool validarFiltro()
        {
            if (cbxFiltrar.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un campo para filtrar");
                return true;
            }
            if (cbxForma.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione una forma para filtrar");
                return true;
            }
            if (cbxFiltrar.SelectedItem.ToString() == "Precio" )
            {
                if (string.IsNullOrEmpty(tbxFiltroText.Text))
                {
                    MessageBox.Show("Debes cargar el campo");
                    return true;
                }
                if (!(soloNumero(tbxFiltroText.Text)))
                {
                    MessageBox.Show("Solo numero para filtrar por un campo numerico");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumero(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }
                string filtrar = cbxFiltrar.SelectedItem.ToString();    
                string forma = cbxForma.SelectedItem.ToString();
                string clave = tbxFiltroText.Text;
                dgvPrincipal.DataSource = negocio.filtrar(filtrar, forma, clave);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       
    }
}
