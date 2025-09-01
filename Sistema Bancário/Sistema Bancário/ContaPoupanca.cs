using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancário
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string titularRecebido) : base(titularRecebido)
        {
        }

        public override void Depositar(double valor)
        {
            double bonus = valor * 0.01;
            base.Depositar(valor + bonus);
            Console.WriteLine($"Bônus de R${bonus:F2} adicionado!");
        }
    }
}
