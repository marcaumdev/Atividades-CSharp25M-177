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

        public virtual int ObterJogada(Tabuleiro tabuleiro)
        {
            int posicao;
            while (!int.TryParse(Console.ReadLine(), out posicao) || posicao < 1 || posicao > 9)
            {
                Console.WriteLine("Entra inválida, digite um número de 1 a 9.");
            }
            return posicao;
        }
    }
}
