using JogoDaVelha;
using System.Timers;

bool jogarNovamente = false;
int numeroErros = 0;

int tempoSobrando = 10;
bool repostaRecebida = false;

do
{
    Console.WriteLine("######### JOGO DA VELHA ###########");

    Console.Write("Você quer jogar contra outro jogador (1) ou contra o computador (2): ");
    string tipoJogo = Console.ReadLine();
    bool contraComputador = tipoJogo == "2";

    Tabuleiro tabuleiro = new Tabuleiro();
    Console.Write("Digite o nome do jogador 1: ");
    string nomeJogador1 = Console.ReadLine();
    nomeJogador1 = String.IsNullOrWhiteSpace(nomeJogador1) ? "Jogador 1" : nomeJogador1;
    Jogador jogador1 = new Jogador(nomeJogador1, 'X');

    Jogador jogador2;
    if (contraComputador)
    {
        jogador2 = new JogadorMaquina("Computador", 'O');
    }
    else
    {
        Console.Write("Digite o nome do jogador 2: ");
        string nomeJogador2 = Console.ReadLine();
        nomeJogador2 = String.IsNullOrWhiteSpace(nomeJogador2) ? "Jogador 2" : nomeJogador2;
        jogador2 = new Jogador(nomeJogador2, 'O');
    }

    Jogador jogadorAtual = jogador1;

    bool jogoTerminou = false;

    while (!jogoTerminou)
    {
        // Desenhar o tabuleiro para o usuário
        tabuleiro.Desenhar();

        // Verificar se a jogada foi feita
        bool jogadaFeita = false;
        while (!jogadaFeita)
        {
            int posicao = 0;
            if (jogadorAtual is JogadorMaquina)
            {
                //Se for o computador ele decide a jogada
                Console.WriteLine($"\n{jogadorAtual.Nome} está pensando...");
                posicao = ((JogadorMaquina)jogadorAtual).ObterJogada(tabuleiro);
            }
            else
            {
                //Se for um jogador humano
                Console.WriteLine($"\n{jogadorAtual.Nome}, é a sua vez. Escolha uma posição (1 - 9)");
                string input = ReadLineWithTimeout(10);

                if (input != null)
                {
                    if (!int.TryParse(input, out posicao))
                    {
                        Console.WriteLine("Entrada inválida. Tente novamente");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("O tempo de espera de 10 segundos foi excedido. O turno será passado.");
                    posicao = -1;
                }
            }

            if (posicao == -1)
            {
                jogadaFeita = true;
            }
            else if (tabuleiro.MarcarJogada(posicao, jogadorAtual.Simbolo))
            {
                jogadaFeita = true;
            }
            else
            {
                if (jogadorAtual is not JogadorMaquina)
                {
                    numeroErros++;
                    Console.WriteLine($"Jogada inválida! Pressione Enter para tentar novamente - Erros: {numeroErros}");
                    Console.ReadKey();
                    tabuleiro.Desenhar();
                }

                if (numeroErros > 4)
                {
                    Console.WriteLine("Número de erros excedidos, encerrando a partida");
                    jogarNovamente = false;
                    jogoTerminou = true;
                }
            }
        }



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

        if (numeroErros > 4)
        {
            Console.WriteLine("Número de erros excedidos, encerrando a partida");
            jogarNovamente = false;
            jogoTerminou = true;
        }
    }

    bool decisaoInvalida = false;

    if (numeroErros > 4)
    {

    }
    else
    {
        do
        {
            Console.WriteLine("\nVocê deseja jogar novamente (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            switch (resposta)
            {
                case "S":
                    jogarNovamente = true;
                    decisaoInvalida = false;
                    break;
                case "N":
                    jogarNovamente = false;
                    decisaoInvalida = false;
                    Console.WriteLine("Obrigado por jogar, encerrando...");
                    break;
                default:
                    Console.WriteLine("Decisão inválida!");
                    decisaoInvalida = true;
                    jogarNovamente = false;
                    break;
            }

        } while (decisaoInvalida);
    }

} while (jogarNovamente);

string ReadLineWithTimeout(int timeout)
{
    tempoSobrando = timeout;

    //Configurar um timer pra disparar a cada um segundo (1000 milissegundos)
    System.Timers.Timer timer = new System.Timers.Timer(1000);
    timer.Elapsed += contador;
    timer.AutoReset = true;
    timer.Enabled = true;


    string input = null;
    Thread inputThread = new Thread(() =>
    {
        input = Console.ReadLine();
        repostaRecebida = true;
    });

    inputThread.Start();

    //evita consumo excessivo de CPU
    while (tempoSobrando > 0 && !repostaRecebida)
    {
        Thread.Sleep(100);
    }

    timer.Stop();
    timer.Dispose();

    if (repostaRecebida)
    {
        repostaRecebida = false;
        return input;
    }
    else
    {
        repostaRecebida = false;
        return null;
    }
}

void contador(object source, ElapsedEventArgs e)
{
    if (tempoSobrando > 0 && !repostaRecebida)
    {
        int linhaAtualDoCursor = Console.CursorTop;
        int colunaAtualDoCursor = Console.CursorLeft;

        Console.Write($"Tempo restante: {tempoSobrando} segundos");
        Console.SetCursorPosition(colunaAtualDoCursor, linhaAtualDoCursor);

        tempoSobrando--;
    }
}