using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancário
{
    public interface IContaBancaria
    {
        bool Sacar(double valor);
        void Depositar(double valor);
        void ConsultarSaldo();
    }
}
