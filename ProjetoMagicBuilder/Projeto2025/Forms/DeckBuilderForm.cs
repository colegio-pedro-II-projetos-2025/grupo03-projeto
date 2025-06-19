using Projeto2025.Entity;
using Projeto2025.Repository;
using Projeto2025.Utils;
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
    public partial class DeckBuilderForm : Form
    {
        private Usuario usuarioLogado { get; set; }
        private int DeckIndex { get; set; }
        public DeckBuilderForm()
        {
            InitializeComponent();
        }

        internal void ReceberUsuario(Usuario usuario)
        {
            usuarioLogado = usuario;
        }

        private void AtualizarQuantidadeDecks()
        {
            var deckRepo = new DeckRepository(RepositoryUtil.ConnectionString);
            int quantidadeDeck = deckRepo.ObterTodosDecksDeUsuario(usuarioLogado.Nome).Count();
            lblNumeroDeck.Text = $"Deck {DeckIndex} de {quantidadeDeck}";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProximoDeck_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarDeck_Click(object sender, EventArgs e)
        {
            var deckRepo = new DeckRepository(RepositoryUtil.ConnectionString);
            if (txtAdicionarDeck.Text == string.Empty || txtAdicionarDeck.Text == null)
            {
                MessageBox.Show("Preencha o nome do deck primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var deck = new Deck()
            {
                Dono = usuarioLogado.Nome,
                Nome = txtAdicionarDeck.Text
            };
            deckRepo.AdicionarDeck(deck);
            AtualizarQuantidadeDecks();
        }

        private void DeckBuilderForm_Load(object sender, EventArgs e)
        {
            AtualizarQuantidadeDecks();
        }
    }
}
