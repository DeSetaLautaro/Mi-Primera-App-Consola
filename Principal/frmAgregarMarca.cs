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
namespace Principal
{
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnAceptarAM_Click(object sender, EventArgs e)
        {
            Marca NuevaMarca = new Marca();
            ArticulosNegocio ArticulosNegocio = new ArticulosNegocio();
            try
            {
                if (!string.IsNullOrEmpty(txtNuevaMarca.Text))
                {
                    NuevaMarca.Descripcion = txtNuevaMarca.Text;
                    ArticulosNegocio.AgregarMarca(NuevaMarca);
                    Close();
                }
                else
                {
                    MessageBox.Show("Por favor introduzca un marca. Si no desea continuar presione cancelar");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnCancelarAM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
