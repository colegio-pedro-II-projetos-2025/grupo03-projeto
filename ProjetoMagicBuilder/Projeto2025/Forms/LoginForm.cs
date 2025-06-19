using Projeto2025.Entity;
using Projeto2025.Forms;
using Projeto2025.Repository;
using Projeto2025.Utils;

namespace Projeto2025
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lnkCadastar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SigninForm signinform = new SigninForm();
            signinform.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;

            UsuarioRepository repo = new UsuarioRepository(RepositoryUtil.ConnectionString);
            Usuario usuario = repo.ObterPorEmailESenha(email, senha);

            if (usuario != null)
            {
                DeckBuilderForm deckBuilderForm = new DeckBuilderForm();
                deckBuilderForm.Show();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
