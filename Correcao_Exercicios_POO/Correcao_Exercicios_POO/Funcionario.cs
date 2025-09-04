namespace Correcao_Exercicios_POO
{
    public class Funcionario : Pessoa
    {
        double Salario;
        public Funcionario(string NomeRecebido, int IdadeRecebida, double SalarioRecebido) : base(NomeRecebido, IdadeRecebida)
        {
            Salario = SalarioRecebido;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Meu nome é {Nome}, eu tenho {BuscarIdade()} Anos e ganho R${Salario:F2}");
        }

        public override void ExibirDados(string Sobrenome)
        {
            Console.WriteLine($"Meu nome é {Nome} {Sobrenome}, eu tenho {BuscarIdade()} Anos e ganho R${Salario:F2}");
        }
    }
}
