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


namespace PrimerEjemplo_aso_net
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon poke= new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                poke.Numero = int.Parse(txbNumero.Text);
                poke.Nombre = txbNombre.Text;
                poke.Descripcion = txbDescripcion.Text;
                poke.UrlImagen = txbUrlImagen.Text;
                poke.Tipo = (Elemento)cboTipo.SelectedItem;
                poke.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                negocio.agregar(poke);
                MessageBox.Show("agregado exitosamente");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboDebilidad.DataSource = elementoNegocio.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemons.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxPokemons.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
    }
}
