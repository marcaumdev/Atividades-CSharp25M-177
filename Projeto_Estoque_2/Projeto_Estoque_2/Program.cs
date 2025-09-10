using Projeto_Estoque_2.Classes;
//nome, preço, quantidadeEmEstoque, SKU - OK

//Tipos de produto vestuário e eletrônico - OK
ProdutoVestuario camisaNike = new ProdutoVestuario("Camisa da Nike", 199.99, 100, "8234ASDJGIFU3", "esportivo", "Branca", "G");

ProdutoEletronico notebookDellG15 = new ProdutoEletronico("Dell G15", 3500.00, 50, "ASDJH384FDD", "110V", true);

//Criar estoque
GerenciadorEstoque estoque1 = new GerenciadorEstoque(1, "Estoque 1");

int escolhaUsuario;

do
{
    Console.Write($@"
|--------------------------------|
| Sistema de Controle de Estoque |
|--------------------------------|
| 1 - Cadastrar um Produto       |
| 2 - Listar Produtos            |
| 3 - Remover Produto            |
| 4 - Atualizar Quantidade       |
| 5 - Buscar Produto por SKU     |
| 0 - Sair                       |
|________________________________|
|> ");
    try
    {
        escolhaUsuario = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("\nEscreva uma opção válida");
        escolhaUsuario = 99;
    }

    switch (escolhaUsuario)
    {
        case 0:
            Console.WriteLine("\nSaindo do sistema...");
            break;
    //adicionar produtos
        case 1:
            bool cadastrado = estoque1.AdicionarProduto();
            if (cadastrado)
            {
                Console.WriteLine("\nProduto Cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nFalha ao cadastrar Produto, Tente novamente!");
            }
            break;
    //listar produto
        case 2:
            estoque1.ListarProdutos();
            break;
        //remover produtos
        case 3:
            estoque1.RemoverProduto();
            break;
        case 4:
            estoque1.AtualizarQuantidade();
            break;
        case 5:
            estoque1.BuscarProdutoPorSKU();
            break;
    }





    //atualizar quantidade de produto

    //pesquisar produto por nome ou SKU

} while (escolhaUsuario != 0);
