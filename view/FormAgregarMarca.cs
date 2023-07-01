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
    public partial class FormAgregarMarca : Form
    {
        private List<Marca> listaMarca;
        private Marca marca = new Marca();
        public FormAgregarMarca()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            MarcaNegocio objNeg = new MarcaNegocio();
            try
            {
                listaMarca = objNeg.listar();
                dgvMarca.DataSource = objNeg.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarMarca()
        {
            if (string.IsNullOrEmpty(tbxAgregarMarca.Text))
            {
                MessageBox.Show("Llenar campo...");
                return true;

            }
            return false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();  
            Marca marca = new Marca();

            try
            {
                if (validarMarca()){
                    return;
                }
                marca.descripcion = tbxAgregarMarca.Text;

                negocio.agregar(marca);
                MessageBox.Show("Agregado Correctamente");

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMarca_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMarca.CurrentRow != null) marca = (Marca)dgvMarca.CurrentRow.DataBoundItem;
        }

        private void FormAgregarMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("Seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
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
