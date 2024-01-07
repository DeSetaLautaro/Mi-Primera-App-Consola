using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;

namespace Principal
{
    public partial class frmAltaArticulo : Form
    {
        private Articulos Articulo= null;

        OpenFileDialog ofd = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulos A)
        {
            InitializeComponent();
            Articulo = A;
        }
        private void btnAceptar_Click(object sender, EventArgs e)


        {
            ArticulosNegocio Negocio = new ArticulosNegocio();

            try
            {
                if (ValidarAlta() == false)
                {
                    MessageBox.Show("Por Favor complete los campos obligtorios");
                    return;
                }
                if (Articulo == null)
                {
                    Articulo = new Articulos();
                }
                if (!string.IsNullOrEmpty(txtNombre.Text))
                    Articulo.Nombre = txtNombre.Text;
                else

                Articulo.Descripcion = txtDescripcion.Text;
                Articulo.Precio = decimal.Parse(txtPrecio.Text);
                Articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
                Articulo.Marca = (Marca)cboxMarca.SelectedItem;
                Articulo.Imagen = txtUrlImagen.Text;
                Articulo.CodigoDeProducto = txtCodigo.Text;
                if (Articulo.Id == 0)
                { 
                    Negocio.Agregar(Articulo);
                    MessageBox.Show("Agregado exitosamente!");
                }
                else
                {
                    Negocio.Modificar(Articulo);
                    MessageBox.Show("Modificado exitosamente!");
                }

                try
                {
                    if (ofd != null && !Path.GetExtension(ofd.FileName).Equals(".html", StringComparison.OrdinalIgnoreCase))
                    {
                        if (!File.Exists(txtUrlImagen.Text))
                        {
                           File.Copy(ConfigurationManager.AppSettings["Carpeta Imagenes"], ofd.SafeFileName);
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

                Close();
            }

                
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            try
            {
                cboxMarca.DataSource = marcasNegocio.Listar();
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";

                cboxCategoria.DataSource = categoriasNegocio.Listar();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";
                if(Articulo !=null ) 
                {
                    txtDescripcion.Text = Articulo.Descripcion;
                    txtNombre.Text=Articulo.Nombre;
                    txtPrecio.Text=Articulo.Precio.ToString();
                    txtUrlImagen.Text=Articulo.Imagen.ToString();
                    cboxCategoria.SelectedValue = Articulo.Categoria.Id;
                    cboxMarca.SelectedValue = Articulo.Marca.Id;

                    
                    CargarImagen(Articulo.Imagen);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void CargarImagen(string A)
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

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }

        private void btnImportarImagen_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg;|png|*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = ofd.FileName;
                CargarImagen(ofd.FileName);
            }
        }

        private bool ValidarAlta()
        {
            int Bandera=0;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.BackColor = Color.IndianRed;
                Bandera = 1;
            }
           if (string.IsNullOrEmpty(cboxCategoria.SelectedItem.ToString()))
            {
                cboxCategoria.ForeColor = Color.IndianRed;
                Bandera=1;
            }
           if (string.IsNullOrEmpty(txtPrecio.Text))
            { 
                txtPrecio.BackColor = Color.IndianRed;
                Bandera = 1;
            }
           if (!SoloNumeros(txtPrecio.Text))
            {
                txtPrecio.BackColor = Color.IndianRed;
                Bandera=1;
            }
            return Bandera == 0;
        }

        private bool SoloNumeros(string cadena)
        {
            foreach (char c in cadena)
                if (!char.IsNumber(c))
                    return false;
            return true;
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            txtNombre.BackColor= SystemColors.Window;
        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            txtPrecio.BackColor= SystemColors.Window;
        }

        
    }
}
