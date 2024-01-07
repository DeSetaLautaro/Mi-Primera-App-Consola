using Dominio;
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
    public partial class frmVerDetalles : Form
    {
        private Articulos Articulo = null;

        public frmVerDetalles()
        {
            InitializeComponent();
        }

        public frmVerDetalles(Articulos A)
        {
            InitializeComponent();
            Articulo = A;
        }

        private void frmVerDetalles_Load(object sender, EventArgs e)
        {
            lblNom.Text = Articulo.Nombre;
            lblCategoriaOriginal.Text = Articulo.Categoria.Descripcion;
            lblCodioOriginal.Text = Articulo.CodigoDeProducto;
            lblMarcaOriginal.Text=Articulo.Marca.Descripcion;
            rbtImagen.Text = Articulo.Imagen;
            rbtDescripcion.Text=Articulo.Descripcion;
            lblPrecioOriginal.Text = Articulo.Precio.ToString();

            CargarImagen(Articulo.Imagen);
        }


        private void CargarImagen(string A)
        {
            try
            {
                if (A != null)
                {
                    pcbAriculoVD.Load(A);

                }
            }
            catch (Exception)
            {

                pcbAriculoVD.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");

            }
        }
    }
}
