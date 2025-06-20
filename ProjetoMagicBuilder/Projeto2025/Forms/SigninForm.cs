using MySql.Data.MySqlClient;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projeto2025.Forms
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmarSenha.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nome) ||
               string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmarSenha))
            {
                lblErro.Text = "Preencha todos os campos.";
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblErro.Text = "Email inválido.";
                return;
            }

            if (senha.Length < 6)
            {
                lblErro.Text = "A senha deve ter pelo menos 6 caracteres.";
                return;
            }

            if (nome.Length < 3)
            {
                lblErro.Text = "O nome de usuário deve ter pelo menos 3 caracteres.";
                return;
            }

            if (senha != confirmarSenha)
            {
                lblErro.Text = "As senhas não coincidem.";
                return;
            }

            UsuarioRepository usuarioRepo = new UsuarioRepository(RepositoryUtil.ConnectionString);
            Usuario usuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Senha = senha
            };

            try
            {
                int linhas = usuarioRepo.InserirUsuario(usuario);
                if (linhas > 0)
                {
                    lblErro.ForeColor = Color.Green;
                    lblErro.Text = "Usuário cadastrado com sucesso!";
                    LimparCampos();
                }
                else
                {
                    lblErro.Text = "Erro ao cadastrar.";
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    lblErro.Text = "Já existe um usuário com este e-mail.";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro inesperado: " + ex.Message;
            }
        }

        private void SigninForm_Load(object sender, EventArgs e)
        {

        }
    }
}
