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
    }
}
