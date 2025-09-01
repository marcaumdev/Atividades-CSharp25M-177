using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancário
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(string titularRecebido) : base(titularRecebido)
        {
        }

        public override bool Sacar(double valor)
        {
            double taxa = 2.50;
            if(valor > 0)
            {
                bool sacou = base.Sacar(valor + taxa);
                if (sacou)
                {
                    Console.WriteLine($"Taxa de saque de R${taxa:F2} aplicada");
                }
                return sacou;
            }
            return false;
        }
    }
}
