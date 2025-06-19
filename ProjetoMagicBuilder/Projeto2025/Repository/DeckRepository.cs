using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2025.Repository
{
    internal class DeckRepository
    {
        private readonly string _connectionString;
        public DeckRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
