using Projeto2025.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2025.Forms
{
    public partial class SelectorForm : Form
    {
        private Usuario UsuarioLogado { get; set; }
        public SelectorForm()
        {
            InitializeComponent();
        }
        internal void ReceberUsuario(Usuario usuario)
        {
            UsuarioLogado = usuario;
        }
        private void SelectorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCartaAleatoria_Click(object sender, EventArgs e)
        {
            CartaAleatoriaForm cartaAleatoriaForm = new CartaAleatoriaForm();
            cartaAleatoriaForm.ReceberUsuario(UsuarioLogado);
            cartaAleatoriaForm.Show();
            this.Close();
        }

        private void btnDeckBuilder_Click(object sender, EventArgs e)
        {
            DeckBuilderForm deckBuilderForm = new DeckBuilderForm();
            deckBuilderForm.ReceberUsuario(UsuarioLogado);
            deckBuilderForm.Show();
            this.Close();
        }
    }
}
