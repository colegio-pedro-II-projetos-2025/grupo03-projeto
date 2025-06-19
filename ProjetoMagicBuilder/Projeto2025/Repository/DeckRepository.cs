using MySql.Data.MySqlClient;
using Projeto2025.Entity;
using Projeto2025.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto2025.Repository
{
    internal class DeckRepository
    {
        private readonly string _connectionString;
        public DeckRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public int AdicionarDeck(Deck deck)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO deck (nome_deck, dono) VALUES (@Nome, @Dono)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Dono", deck.Dono);
                    command.Parameters.AddWithValue("@Nome", deck.Nome);
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }
        public List<Deck> ObterTodosDecksDeUsuario(string nome)
        {
            var decks = new List<Deck>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT id, dono, nome_deck FROM deck WHERE dono = @Nome";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decks.Add(new Deck
                            {
                                ID = reader.GetInt32("id"),
                                Nome = reader.GetString("nome_deck"),
                                Dono = reader.GetString("dono")
                            });
                        }
                    }
                }
            }
            return decks;
        }
    }
}
