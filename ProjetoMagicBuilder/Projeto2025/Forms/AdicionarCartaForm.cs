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
    public partial class AdicionarCartaForm : Form
    {
        private Usuario usuarioLogado { get; set; }
        public AdicionarCartaForm()
        {
            InitializeComponent();
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
                lblManaValue.Text = selecionado.Mana.ToString();
                lblPoderValue.Text = selecionado.Poder.ToString();
                lblResistenciaValue.Text = selecionado.Resistencia.ToString();
            }
        }

        private void AdicionarCartaForm_Load(object sender, EventArgs e)
        {
            var cartaRepo = new CartaRepository(RepositoryUtil.ConnectionString);
            List<Carta> cartas = cartaRepo.ObterTodasCartas();
            lstCartas.DataSource = cartas;
            lstCartas.DisplayMember = "Nome";
            foreach (var carta in cartas)
            {
                lstCartas.Items.Add(carta);
            }
        }

        private void btnAdicionarCarta_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
