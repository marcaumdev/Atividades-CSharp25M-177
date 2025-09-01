using Sistema_Bancário;

Banco banco = new Banco();

int escolha;

do
{
    Console.Write($@"
|====== Sistema Bancário =======|
| 1 - Criar Conta               |
| 2 - Depositar                 |
| 3 - Sacar                     |
| 4 - Listar Contas             |
| 0 - Sair                      |
|===============================|
|> ");
    escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            banco.CriarConta();
            break;
        case 2:
            banco.Depositar();
            break;
        case 3:
            banco.Sacar();
            break;
        case 4:
            banco.Listar();
            break;
        case 0:
            Console.WriteLine("Saindo do sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (escolha != 0);
