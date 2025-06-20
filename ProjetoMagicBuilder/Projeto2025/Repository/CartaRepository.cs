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
    }
}
