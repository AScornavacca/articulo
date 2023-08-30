using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo artic = new Articulo(); 
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                artic.Codigo = int.Parse(txtCodigo.Text);
                artic.Nombre = txtNombre.Text;
                artic.Descripcion = txtDescripcion.Text;
                artic.Precio = int.Parse(txtPrecio.Text);

                negocio.agregar(artic);
                MessageBox.Show("Agregado Exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
