namespace JogoDaVelha
{
    public class JogadorMaquina : Jogador
    {
        private static readonly Random random = new Random();
        //public JogadorMaquina(string nome, char simbolo) : Jogador(nome, simbolo){ }
        public JogadorMaquina(string nome, char simbolo) : base(nome, simbolo) { }

        public override int ObterJogada(Tabuleiro tabuleiro)
        {
            Thread.Sleep(500);

            int posicao;
            do
            {
                posicao = random.Next(1,10);
            } while (!tabuleiro.EstaVazio(posicao));

            return posicao;
        }
    }
}
