using MySql.Data.MySqlClient;
using Projeto2025.Entity;
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
                                ID = reader.GetInt32("id"),
                                Mana = reader.GetInt32("mana"),
                                Poder = reader.GetInt32("poder"),
                                Resistencia = reader.GetInt32("resistencia"),
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
    }
}
