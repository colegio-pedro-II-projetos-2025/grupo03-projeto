using MySql.Data.MySqlClient;
using Projeto2025.Entity;
using Projeto2025.Forms;
using Projeto2025.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2025.Repository
{
    internal class CartaDeckRepository
    {
        private readonly string _connectionString;
        public CartaDeckRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Carta> ObterCartasPorIdDeck(int id)
        {
            var cartas = new List<Carta>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT c.* FROM cartas c, deck_cartas dc WHERE dc.deck = @Id AND dc.carta = c.id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cartas.Add(new Carta
                            {
                                Nome = reader.GetString("nome"),
                                ID = reader.GetInt32(reader.GetOrdinal("id")),
                                Mana = reader.GetInt32(reader.GetOrdinal("mana")),
                                Poder = reader.IsDBNull(reader.GetOrdinal("poder"))
                                    ? (int?)null
                                    : reader.GetInt32(reader.GetOrdinal("poder")),
                                Resistencia = reader.IsDBNull(reader.GetOrdinal("resistencia"))
                                    ? (int?)null
                                    : reader.GetInt32(reader.GetOrdinal("resistencia")),
                                Tipo = reader.GetString("tipo"),
                                Descricao = reader.GetString("descricao"),
                                Cor = reader.GetString("cor")
                            });
                        }
                    }
                }
            }
            return cartas;
        }
        public int DeckRemovido(int id)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM deck_cartas WHERE deck = @ID";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }
        public List<CartaDeck> ObterCartaDeckPorIdDeck(int id)
        {
            var cartas = new List<CartaDeck>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT carta, quantidade, deck FROM deck_cartas WHERE deck = @Id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cartas.Add(new CartaDeck
                            {
                                IdDeck = reader.GetInt32("deck"),
                                IdCarta = reader.GetInt32("carta"),
                                Quantidade = reader.GetInt32("quantidade"),
                            });
                        }
                    }
                }
            }
            return cartas;
        }
        public int AdicionarCartaAoDeck(int idDeck, int idCarta, int quantidade)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO deck_cartas(carta, deck, quantidade) VALUES (@IdCarta, @IdDeck, @Quantidade)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCarta", idCarta);
                    command.Parameters.AddWithValue("@IdDeck", idDeck);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }
        public void ColapsarCartasDuplicatas()
        {
            var cartas = new List<CartaDeck>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT carta, SUM(quantidade) as quantidade, deck FROM deck_cartas GROUP BY carta, deck";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cartas.Add(new CartaDeck
                            {
                                IdDeck = reader.GetInt32("deck"),
                                IdCarta = reader.GetInt32("carta"),
                                Quantidade = reader.GetInt32("quantidade")
                            });
                        }
                    }
                }
                query = "DELETE FROM deck_cartas";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            foreach (var carta in cartas)
            {
                AdicionarCartaAoDeck(carta.IdDeck, carta.IdCarta, carta.Quantidade);
            }

        }
    }
}
