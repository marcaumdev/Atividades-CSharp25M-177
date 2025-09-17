using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public class Jogador
    {
        public string Nome { get; set; }
        public char Simbolo { get; private set; }

        public Jogador(string nome, char simbolo) 
        { 
            Nome = nome;
            Simbolo = simbolo;
        }
    }
}
