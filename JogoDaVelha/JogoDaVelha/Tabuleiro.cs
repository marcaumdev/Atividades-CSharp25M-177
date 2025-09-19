namespace JogoDaVelha
{
    public class Tabuleiro
    {
        // char aceita apenas um caractere
        private char[] casas;

        // "cria o nosso tabuleiro"
        public Tabuleiro()
        {
            casas = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

        // mostra o nosso tabuleiro
        public void Desenhar()
        {
            Console.Clear();
            Console.WriteLine(@$"{casas[0]} | {casas[1]} | {casas[2]}
--+---+--
{casas[3]} | {casas[4]} | {casas[5]}
--+---+--
{casas[6]} | {casas[7]} | {casas[8]}");
        }

        // Anota a jogada no tabuleiro recebendo a posição e o simbolo
        public bool MarcarJogada(int posicao, char simbolo)
        {
            //verifica se a posição é válida
            if (posicao >= 1 && posicao <= 9)
            {
                // verifica se a casa está marcada
                if (casas[posicao - 1] != 'X' && casas[posicao - 1] != 'O')
                {
                    //caso não esteja marcada, marca
                    casas[posicao - 1] = simbolo;
                    return true;
                }
            }
            return false;
        }

        public bool VerificarVencedor(char simbolo)
        {
            // horizontais
            if (casas[0] == simbolo && casas[1] == simbolo && casas[2] == simbolo) { return true; }
            if (casas[3] == simbolo && casas[4] == simbolo && casas[5] == simbolo) { return true; }
            if (casas[6] == simbolo && casas[7] == simbolo && casas[8] == simbolo) { return true; }

            // verticais
            if (casas[0] == simbolo && casas[3] == simbolo && casas[6] == simbolo) { return true; }
            if (casas[1] == simbolo && casas[4] == simbolo && casas[7] == simbolo) { return true; }
            if (casas[2] == simbolo && casas[5] == simbolo && casas[8] == simbolo) { return true; }

            //diagonais
            if (casas[0] == simbolo && casas[4] == simbolo && casas[8] == simbolo) { return true; }
            if (casas[2] == simbolo && casas[4] == simbolo && casas[6] == simbolo) { return true; }

            return false;
        }

        public bool VerificarEmpate()
        {
            foreach (var casa in casas)
            {
                // caso uma das casas não esteja preenchida retorna falso
                if (casa != 'X' && casa != 'O')
                {
                    return false;
                }
            }

            return true;

        }
        public bool EstaVazio(int posicao)
        {
            if (posicao >= 1 && posicao <= 9)
            {
                return casas[posicao - 1] != 'X' && casas[posicao - 1] != 'O';
            }
            return false;
        }
    }
}
