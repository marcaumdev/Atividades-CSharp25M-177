namespace Correcao_Exercicios_POO
{
    public class Pessoa
    {
        public string Nome = "";
        private int Idade;

        public Pessoa(string NomeRecebido, int IdadeRecebida)
        {
            Nome = NomeRecebido;
            AlterarIdade(IdadeRecebida);
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Meu nome é {Nome} e eu tenho {Idade} anos");
        }

        public virtual void ExibirDados(string Sobrenome)
        {
            Console.WriteLine($"Meu nome é {Nome} {Sobrenome} e eu tenho {Idade} anos");
        }

        public void AlterarIdade(int idadeRecebida)
        {
            if (idadeRecebida <= 0)
            {
                Console.WriteLine("Idade inválida!");
            }
            else
            {
                Idade = idadeRecebida;
            }
        }

        public int BuscarIdade() {  return Idade; }
    }
}
