using Projeto2025.Entity;
using Projeto2025.Repository;
using Projeto2025.Utils;
using Projeto2025.Forms;
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
    public partial class AdicionarCartaForm : Form
    {
        private int DeckIndex;
        private Usuario usuarioLogado { get; set; }
        public event EventHandler<string> AoSairFormulario;
        public AdicionarCartaForm(int deckIndex)
        {
            InitializeComponent();
            DeckIndex = deckIndex;  
        }

        internal void ReceberUsuario(Usuario usuario)
        {
            usuarioLogado = usuario;
        }

        private void lstCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCartas.SelectedItem is Carta selecionado)
            {
                lblNome.Text = selecionado.Nome;
                lblTxt.Text = selecionado.Descricao;
                lblManaValue.Text = selecionado.Mana.ToString();
                lblPoderValue.Text = selecionado.Poder.ToString() ?? "-";
                lblResistenciaValue.Text = selecionado.Resistencia.ToString() ?? "-";
            }
        }

        private void AdicionarCartaForm_Load(object sender, EventArgs e)
        {
            var cartaRepo = new CartaRepository(RepositoryUtil.ConnectionString);
            List<Carta> cartas = cartaRepo.ObterTodasCartas();
            lstCartas.DataSource = cartas;
            lstCartas.DisplayMember = "Nome";
        }

        private void btnAdicionarCarta_Click(object sender, EventArgs e)
        {
            var cartaDeckRepo = new CartaDeckRepository(RepositoryUtil.ConnectionString);
            var deckRepo = new DeckRepository(RepositoryUtil.ConnectionString);
            var decks = deckRepo.ObterDecksPorIdUsuario(usuarioLogado.Nome);
            int idDeck = decks[DeckIndex].ID;
            Carta selecionado = (Carta)lstCartas.SelectedItem;
            if (selecionado == null)
            {
                MessageBox.Show("Selecione uma Carta para Adicionar!");
                return;
            }
            else
            {
                int quantidade = (int)numQuant.Value;
                cartaDeckRepo.AdicionarCartaAoDeck(selecionado.ID, idDeck, quantidade);
                lblAdicionado.Text = "Carta adicionada com sucesso!";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AoSairFormulario?.Invoke(this, null);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPoderText_Click(object sender, EventArgs e)
        {

        }

        private void lblManaText_Click(object sender, EventArgs e)
        {

        }

        private void lblSlash2_Click(object sender, EventArgs e)
        {

        }

        private void lblResistenciaText_Click(object sender, EventArgs e)
        {

        }

        private void lblManaValue_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblQuant_Click(object sender, EventArgs e)
        {

        }
    }
}
