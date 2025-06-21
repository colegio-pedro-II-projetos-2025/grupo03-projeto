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
    public partial class CartaAleatoriaForm : Form
    {
        private Usuario UsuarioLogado { get; set; }
        private List<Carta> Cartas { get; set; }
        private Carta Atual { get; set; }
        private int Vitorias { get; set; }
        private int Partidas { get; set; }
        private bool Comecado { get; set; }
        private List<string> Tentativas { get; set; }
        public CartaAleatoriaForm()
        {
            InitializeComponent();
        }

        internal void ReceberUsuario(Usuario usuario)
        {
            UsuarioLogado = usuario;
            Comecado = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var cartaRepo = new CartaRepository(RepositoryUtil.ConnectionString);
            string tentativa = txtNome.Text;
            if (tentativa == Atual.Nome)
            {
                Vitorias++;
                lblInfo.Text = "Acertou!";

            }
            else
            {
                var cartaErrada = cartaRepo.ObterCartaPorNome(tentativa);
                if (cartaErrada == null)
                {
                    lblInfo.Text = "Esta carta não existe.";
                }
                else
                {
                    lblInfo.Text = "Errou!";
                    string txtMana = string.Empty;
                    if (Atual.Mana > cartaErrada.Mana)
                    {
                        txtMana = "maior";
                    }
                    else if (Atual.Mana < cartaErrada.Mana)
                    {
                        txtMana = "menor";
                    }
                    else
                    {
                        txtMana = "igual";
                    }
                    string txtCor = string.Empty;
                    if (Atual.Cor == cartaErrada.Cor)
                    {
                        txtCor = "igual";
                    }
                    else
                    {
                        txtCor = "diferente";
                    }
                    lstTentativa.Items.Add($"{cartaErrada.Nome}: A mana da carta é {txtMana}; A cor da carta é {txtCor}");
                }
            }
            lblPontuacao.Text = $"Pontuação: {Vitorias} / {Partidas}";
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (Comecado == false)
            {
                var cartaRepo = new CartaRepository(RepositoryUtil.ConnectionString);
                Cartas = cartaRepo.ObterTodasCartas();
                var num = random.Next(0, Cartas.Count - 1);
                Atual = Cartas[num];
                lblDescricao.Text = "Descrição da Carta: " + Atual.Descricao;
                Partidas++;
                Comecado = true;
                lstTentativa.DataSource = Tentativas;

            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            var usuarioRepo = new UsuarioRepository(RepositoryUtil.ConnectionString);
            lstTentativa.Items.Clear();
            lblDescricao.Text = "Descrição da Carta: ";
            Comecado = false;
            if (UsuarioLogado.Vitorias < Vitorias && Partidas <= UsuarioLogado.Partidas)
            {
                usuarioRepo.MudarRecorde(Vitorias, Partidas, UsuarioLogado.Email);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CartaAleatoriaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
