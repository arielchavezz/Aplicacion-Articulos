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
    public partial class FormPrincipal : Form
    {
        private Form form;

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void frmPanel(object frmpanel)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Form form = frmpanel as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
        }

       

        private void btnArticulos_Click_1(object sender, EventArgs e)
        {
            frmPanel(new FormListado());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPanel(new FormAgregarArticulo());
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmPanel(new FormAgregarMarca());
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmPanel(new FormAgregarCategoria());
        }

        
    }
}
