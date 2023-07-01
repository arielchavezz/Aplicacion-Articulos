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
    public partial class FormAgregarCategoria : Form
    {
        private List<Categoria> listaCategoria;
        private Categoria categoria = new Categoria();  
        public FormAgregarCategoria()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            CategoriaNegocio objNeg = new CategoriaNegocio();
            try
            {
                listaCategoria = objNeg.listar();
                dgvCategoria.DataSource = objNeg.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarCategoria()
        {
            if (string.IsNullOrEmpty(tbxCategoria.Text))
            {
                MessageBox.Show("Llenar campo");
                return true;
            }
            return false;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();

            try
            {
                if (validarCategoria())
                {
                    return;
                }
                categoria.descripcion = tbxCategoria.Text;

                negocio.agregar(categoria);
                MessageBox.Show("Agregado Correctamente");

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null) categoria = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
        }

        private void FormAgregarCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("Seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    negocio.EliminarFisica(seleccionado.id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
