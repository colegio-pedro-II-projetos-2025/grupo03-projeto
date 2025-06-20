using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2025.Entity
{
    internal class Carta
    {
        public string Nome { get; set; }
        public int ID { get; set; }
        public int Mana { get; set; }
        public int? Poder { get; set; }
        public int? Resistencia { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Cor { get; set; }
    }
}
