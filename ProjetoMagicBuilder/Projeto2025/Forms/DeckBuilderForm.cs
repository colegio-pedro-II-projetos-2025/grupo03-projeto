using Projeto2025.Entity;
using Projeto2025.Repository;
using Projeto2025.Utils;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        public int DeckIndex { get; set; }
        private int QuantidadeDeck { get; set; }
        public DeckBuilderForm()
        {
            InitializeComponent();
        }

        internal void ReceberUsuario(Usuario usuario)
        {
            usuarioLogado = usuario;
        }

        private void AtualizarDecks()
        {
            var deckRepo = new DeckRepository(RepositoryUtil.ConnectionString);
            var decks = deckRepo.ObterDecksPorIdUsuario(usuarioLogado.Nome);
            QuantidadeDeck = decks.Count();

            if (decks.Count > 0)
            {
                lblNumeroDeck.Text = $"Deck {DeckIndex + 1} de {QuantidadeDeck}";
                lblNomeDeck.Text = $"Deck {decks[DeckIndex].Nome}";
            }
            else if (decks.Count == 0)
            {
                lblNumeroDeck.Text = $"Deck {DeckIndex} de {QuantidadeDeck}";
                lblNomeDeck.Text = $"Nenhum Deck Selecionado";
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
            AtualizarDecks();
        }

        private void DeckBuilderForm_Load(object sender, EventArgs e)
        {
            AtualizarDecks();
        }

        private void btnProximoDeck_Click(object sender, EventArgs e)
        {
            DeckIndex--;
            if (DeckIndex < 0)
            {
                DeckIndex = QuantidadeDeck - 1;
            }
            AtualizarDecks();
        }

        private void btnAnteriorDeck_Click(object sender, EventArgs e)
        {
            DeckIndex++;
            if (DeckIndex >= QuantidadeDeck)
            {
                DeckIndex = 0;
            }
            AtualizarDecks();
        }

        private void btnExcluirDeck_Click(object sender, EventArgs e)
        {
            var deckRepo = new DeckRepository(RepositoryUtil.ConnectionString);
            var decks = deckRepo.ObterDecksPorIdUsuario(usuarioLogado.Nome);
            deckRepo.RemoverDeck(decks[DeckIndex].ID);
            AtualizarDecks();
        }

        private void lblNumeroDeck_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarCarta_Click(object sender, EventArgs e)
        {
            var adicionarCartaForm = new AdicionarCartaForm(this.DeckIndex);
            adicionarCartaForm.Show();
        }
    }
}
