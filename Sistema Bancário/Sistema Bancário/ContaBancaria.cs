using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancário
{
    public class ContaBancaria : IContaBancaria
    {
        private double saldo;
        public string titular;
        public static int proximoNumero = 0;
        public int numeroConta;

        // método construtor que constrói o objeto
        public ContaBancaria(string titularRecebido)
        {
            //cria o objeto conta bancaria com o titular sendo o valor recebido
            titular = titularRecebido;
            // primeiro ele adiciona 1 e depois salva o número da conta
            numeroConta = ++proximoNumero;
            // primeiro ele salva o número da conta e depois adiciona 1
            //numeroConta = proximoNumero++;

            //saldo da conta iniciado em 0
            saldo = 0;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Conta: {numeroConta} | Titular: {titular} | Saldo: R$ {saldo:F2}");
        }

        public virtual void Depositar(double valor)
        {
            //saldo = saldo + valor;
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado.\nSaldo atual: R${saldo:F2}");
            
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }
            else
            {
                //saldo = saldo - valor;
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado.\nSaldo atual: R${saldo:F2}");
                return true;
            }
        }
    }
}
