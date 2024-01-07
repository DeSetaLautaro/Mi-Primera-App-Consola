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

namespace Principal
{
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();
            Categoria categoria = new Categoria();
            try
            {
                if (!string.IsNullOrEmpty(txtAgregarCategoriaAG.Text))
                {
                    categoria.Descripcion = txtAgregarCategoriaAG.Text;
                    articulosNegocio.AgregarCategoria(categoria);
                    Close();
                }
                else
                {
                    MessageBox.Show("Por favor introduzca una categoria. Si no desea continuar presione cancelar");
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
