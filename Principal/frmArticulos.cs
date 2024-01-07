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
    public partial class frmPrincipal : Form
    {
        private List<Articulos> ListaArticulos;
        



        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            CargarGrilla();

        }
        private void OcultarColumnas()
        {
            dgvArticulos.Columns["Descripcion"].Visible=false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void CargarGrilla()
        {
            ArticulosNegocio ArticulosNegocio = new ArticulosNegocio();
            try
            {
                ListaArticulos = ArticulosNegocio.Listar();
                dgvArticulos.DataSource = ListaArticulos;
                OcultarColumnas();
                CargarImagen(ListaArticulos[0].Imagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void FiltrarGrilla(string Precio, string Categorias, string Marcas, string Nombre, int FPrecio, string FNombre)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            List<Articulos> ListaDeArticulos;




            try

            {

                ListaDeArticulos = negocio.Filtrar(Precio, Categorias, Marcas, Nombre, FPrecio, FNombre);

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = ListaDeArticulos;
                CargarImagen(string.Empty);


                OcultarColumnas();
                if(dgvArticulos.Rows.Count > 0) 
                    CargarImagen(ListaDeArticulos[0].Imagen);
                if (ListaDeArticulos.Count >= 1)
                {
                    MessageBox.Show("llegamos");

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvArticulos.CurrentRow != null)
            {
                Articulos Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                CargarImagen(Seleccionado.Imagen);

            }
           
        }

        private void CargarImagen(string A)
        {
         
            {
                try
                {

                    
                        if (A != null)
                        {
                            pcbArticulos.Load(A);

                        }
                    
                }
                catch (Exception)
                {

                    pcbArticulos.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
                }


            } 
        } 
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo AltaArticulo = new frmAltaArticulo();
            AltaArticulo.ShowDialog();
            CargarGrilla();
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos Seleccionado;
            Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            
            frmAltaArticulo Modiicar= new frmAltaArticulo(Seleccionado);
            Modiicar.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio Negocio = new ArticulosNegocio();
            Articulos Seleccionado;

            try
            {

                DialogResult Respuesta= MessageBox.Show("¿Está seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ;
                if (Respuesta == DialogResult.Yes)
                {
                    Seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    Negocio.Eliminar(Seleccionado.Id);
                    CargarGrilla();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> ListaFiltrada;
            string Filtro= txtFiltro.Text;

            if (Filtro.Length > 0)
            {
                ListaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().StartsWith(Filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().StartsWith(Filtro.ToUpper()));

            }
            else
            {
                ListaFiltrada = ListaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = ListaFiltrada;

            


        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {

            string FNombre= "";
            string Cat = "";
            string Marcas = "";
            string Nombre = "";
            using (Busqueda_avanzada Busqueda = new Busqueda_avanzada()) 
            
                if(Busqueda.ShowDialog() == DialogResult.OK) 
                
                {
                    

                   string  Precio = Busqueda.Precio;
                   Cat = Busqueda.Categorias;
                   Marcas = Busqueda.Marca;
                   Nombre = Busqueda.Nombre;
                   int FPrecio = Busqueda.FPrecio;
                   FNombre= Busqueda.FNombre;
                   FiltrarGrilla(Precio, Cat, Marcas, Nombre, FPrecio, FNombre);
                }


            
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Articulos Selec = new Articulos();
            Selec = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            frmVerDetalles VerDetalles = new frmVerDetalles(Selec);
            VerDetalles.ShowDialog();
        
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca frmAgregarMarca = new frmAgregarMarca();
            frmAgregarMarca.ShowDialog();

            
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria frmAgregarCategoria = new frmAgregarCategoria();
            frmAgregarCategoria.ShowDialog();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
