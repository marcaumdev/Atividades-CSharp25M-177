using JogoDaVelha;

Tabuleiro tabuleiro =  new Tabuleiro();
Jogador jogador1 = new Jogador("Jogador 1", 'X');
Jogador jogador2 = new Jogador("Jogador 2", 'O');
Jogador jogadorAtual = jogador1;

bool jogoTerminou = false;

while (!jogoTerminou)
{
    // Desenhar o tabuleiro para o usuário
    tabuleiro.Desenhar();

    // Pedir a jogada do jogador atual
    Console.WriteLine($"\n{jogadorAtual.Nome}, é a sua vez. Escolha uma posição (1-9):");
    int posicao = int.Parse(Console.ReadLine());

    //Marcar jogada
    if (tabuleiro.MarcarJogada(posicao, jogadorAtual.Simbolo))
    {
        if (tabuleiro.VerificarVencedor(jogadorAtual.Simbolo))
        {
            tabuleiro.Desenhar();
            Console.WriteLine($"\nParabéns {jogadorAtual.Nome} venceu!");
            jogoTerminou = true;
        }
        else if (tabuleiro.VerificarEmpate())
        {
            tabuleiro.Desenhar();
            Console.WriteLine("\nO jogo terminou em empate!");
            jogoTerminou = true;
        }
        else
        {
            jogadorAtual = jogadorAtual == jogador1 ? jogador2 : jogador1;
        }
    }
    else
    {
        Console.WriteLine("Jogada inválida! Pressione Enter para tentar novamente");
        Console.ReadKey();
    }
}