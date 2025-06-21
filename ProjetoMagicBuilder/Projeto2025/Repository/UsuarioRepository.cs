using MySql.Data.MySqlClient;
using Projeto2025.Entity;
using Projeto2025.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2025.Repository
{
    internal class UsuarioRepository
    {
        private readonly string _connectionString;
        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Usuario ObterPorEmailESenha(string email, string senha)
        {
            Usuario usuario = null;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT email, nome, senha FROM usuario WHERE email = @Email AND senha = @Senha";
                using (var command = new MySqlCommand(query, connection))
                {
                    string senhaFormatada = HashUtil.GerarHashSha256(senha);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senhaFormatada);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Nome = reader.GetString("nome"),
                                Email = reader.GetString("email"),
                                Senha = reader.GetString("senha")
                            };
                        }
                    }
                }
            }
            return usuario;
        }

        public int InserirUsuario(Usuario usuario)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO usuario (email, nome, senha) VALUES (@Email, @Nome, @Senha)";
                using (var command = new MySqlCommand(query, connection))
                {
                    string senhaFormatada = HashUtil.GerarHashSha256(usuario.Senha);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@Nome", usuario.Nome);
                    command.Parameters.AddWithValue("@Senha", senhaFormatada);
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }

        public int MudarRecorde(int vitorias, int partidas, string email)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE usuario SET vitorias = @Vitorias, partidas = @Partidas WHERE email = @Email";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Partidas", partidas);
                    command.Parameters.AddWithValue("@Vitorias", vitorias);
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }
    }
}
