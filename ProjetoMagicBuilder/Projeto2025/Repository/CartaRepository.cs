using MySql.Data.MySqlClient;
using Projeto2025.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2025.Repository
{
    internal class CartaRepository
    {
        private readonly string _connectionString;
        public CartaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Carta> ObterTodasCartas()
        {
            var cartas = new List<Carta>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM cartas";

                using (var command = new MySqlCommand(query, connection))
                {
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
        public Carta ObterCartaPorNome(string nome)
        {
            Carta carta = null;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM cartas WHERE nome = @Nome";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            carta = new Carta
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
                            };
                        }
                    }
                }
            }
            return carta;
        }
    }
}
