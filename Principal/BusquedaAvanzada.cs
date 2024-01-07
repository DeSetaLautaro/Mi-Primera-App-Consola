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
    public partial class Busqueda_avanzada : Form
    {
        public string Precio { get; private set; }

        public string Categorias { get; private set; }
        public string Marca { get; private set; }
        public string Nombre { get; private set; }

        public int FPrecio { get; private set; }
        public string FCat { get; private set; }
        public string FMarca { get; private set; }
        public string FNombre { get; private set; }
        public Busqueda_avanzada()
        {
            InitializeComponent();
        }

        private void Busqueda_avanzada_Load(object sender, EventArgs e)
        {
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            cmbPrecioBA.Items.Clear();
            cmbPrecioBA.Items.Add("mayor a");
            cmbPrecioBA.Items.Add("menor a");
            cmbPrecioBA.Items.Add("igual a");

            cmbCategoriaBA.DataSource = categoriasNegocio.Listar();
            cmbCategoriaBA.SelectedIndex= -1;

            cmbMarcaBA.DataSource = marcasNegocio.Listar();
            cmbMarcaBA.SelectedIndex = -1;
            
            cmbNombreBA.Items.Clear();
            cmbNombreBA.Items.Add("empieza con");
            cmbNombreBA.Items.Add("termina con");
            cmbNombreBA.Items.Add("contiene");










        }
        


        private bool ValidarFiltro()
        {
            
            if (txtPrecioBA.BackColor == Color.Red)
                    return false;
            
            if ((string.IsNullOrEmpty(txtPrecioBA.Text)) && cmbPrecioBA.SelectedIndex >= 0)
                    return false;
            if (cmbPrecioBA.SelectedIndex == -1 && (!string.IsNullOrEmpty(txtPrecioBA.Text)))
                    return false;

            if (cmbNombreBA.SelectedIndex >= 0 && (string.IsNullOrEmpty(txtNombreBA.Text)))
                    return false;
            if (cmbNombreBA.SelectedIndex == -1 && (!string.IsNullOrEmpty(txtPrecioBA.Text)))
                    return false;
                
            return true;





        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio Negocio = new ArticulosNegocio();


            
                try
                {
                    if (ValidarFiltro()== false)
                        return;

                    if (!string.IsNullOrEmpty(cmbPrecioBA.Text))
                        Precio = cmbPrecioBA.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(txtPrecioBA.Text))
                    FPrecio = int.Parse(txtPrecioBA.Text);
                if (cmbCategoriaBA.SelectedIndex >= 0)
                    Categorias = cmbCategoriaBA.SelectedItem?.ToString();
                if (cmbMarcaBA.SelectedIndex >= 0)
                    Marca = cmbMarcaBA.SelectedItem?.ToString();
                    if (cmbNombreBA.SelectedIndex >=0)
                        Nombre = cmbNombreBA.SelectedItem?.ToString();

                    
                   
                    if (!string.IsNullOrEmpty(txtNombreBA.Text))
                        FNombre = txtNombreBA.Text;


                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                

                
                catch (Exception ex)

                {
                    throw ex;
                }
        }
        private bool SoloNumeros(string cadena)
        {
            foreach (char c in cadena)
                if (!char.IsNumber(c))
                    return false;
            return true;
        }

        private void txtPrecioBA_Validating(object sender, CancelEventArgs e)
        {
            foreach (char caracter in txtPrecioBA.Text)
                if (!char.IsNumber(caracter))
                    txtPrecioBA.BackColor = Color.Red;
        }

        private void txtPrecioBA_Validated(object sender, EventArgs e)
        {
            if (SoloNumeros(txtPrecioBA.Text))
                txtPrecioBA.BackColor = SystemColors.Window;
        }
    }
}
