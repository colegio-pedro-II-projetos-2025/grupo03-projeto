using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2025.Entity
{
    internal class CartaComQuantidade
    {
        public Carta Carta { get; set; }
        public int Quantidade { get; set; }
        public string NomeDaCarta => Carta.Nome;
    }
}
