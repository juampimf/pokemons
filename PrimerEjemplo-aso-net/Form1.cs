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
    public partial class frmPokemons : Form
    {
        private List<Pokemon> ListaPokemons;
        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                ListaPokemons = negocio.listar();
                dgvPokemons.DataSource = ListaPokemons;
                dgvPokemons.Columns["UrlImagen"].Visible = false;
                cargarImagen(ListaPokemons[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            
          Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
               

        }
        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                ListaPokemons = negocio.listar();
                dgvPokemons.DataSource = ListaPokemons;
                dgvPokemons.Columns["UrlImagen"].Visible = false;
                cargarImagen(ListaPokemons[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
            cargar();

        }
    }
}
