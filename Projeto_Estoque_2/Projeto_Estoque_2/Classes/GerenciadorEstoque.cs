namespace Projeto_Estoque_2.Classes;

public class GerenciadorEstoque
{
    public List<Produto> produtos { get; set; }
    public int id { get; set; }
    public string nome { get; set; }

    public GerenciadorEstoque(int Id, string Nome)
    {
        id = Id;
        nome = Nome;
        produtos = new List<Produto>()
        {
            new ProdutoEletronico("Celular", 1590, 300, "asdhb7r934ur7", "Bivolt", true),
             new ProdutoEletronico("Dell G15", 5000, 2435, "NOTE32d723", "Bivolt", true),
            new ProdutoVestuario("Camisa Brasil", 129.90, 10000, "CAMBR0001", "Camisa 1", "Azul", "P")
        };
    }

    public void ListarProdutos()
    {
        if (produtos.Count != 0)
        {
            int cont = 1;
            Console.WriteLine(" ");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($" ID: {cont} | Nome: {produto.nome} | SKU: {produto.sku} | Quantidade: {produto.quantidade}");
                cont++;
            }
        }
        else
        {
            Console.WriteLine("\nNão há produtos a serem listados!");
        }
    }
    public void BuscarProdutoPorSKU()
    {
        try
        {
            Console.Write("\nDigite o SKU do Produto: ");
            string sku = Console.ReadLine();
            Produto produtoBuscado = produtos.Find(produto => produto.sku == sku);
            produtoBuscado.ExibirDetalhes();
        }
        catch (Exception)
        {

            Console.WriteLine("Falha ao encontrar o produto!");
        }

        //foreach (Produto produto in produtos)
        //{
        //    if(produto.sku == sku)
        //    {
        //        return produto;
        //    }
        //}
    }
    public void BuscarProdutoPorNome()
    {
        try
        {
            Console.Write("\nDigite o Nome do Produto: ");
            string nome = Console.ReadLine();
            Produto produtoBuscado = produtos.Find(produto => produto.nome == nome);
            produtoBuscado.ExibirDetalhes();
        }
        catch (Exception)
        {

            Console.WriteLine("Falha ao encontrar o produto!");
        }
    }
    public bool AdicionarProduto()
    {
        int tipoProduto = 0;
        Console.Write($@"
Qual tipo de produto você deseja cadastrar
1 - Eletronico
2 - Vestuario
0 - Voltar
> ");
        try
        {
            tipoProduto = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

        switch (tipoProduto)
        {
            case 0:
                Console.WriteLine("Voltando para o menu anterior...");
                return false;
            case 1:
                //coletar informações do eletrônico
                Produto produtoEletronico = coletaDados(tipoProduto);
                if (produtoEletronico == null)
                {
                    return false;
                }
                else
                {
                    produtos.Add(produtoEletronico);
                    return true;
                }
            case 2:
                //coletar informações do usuário
                Produto produtoVestuario = coletaDados(tipoProduto);
                if (produtoVestuario == null)
                {
                    return false;
                }
                else
                {
                    produtos.Add(produtoVestuario);
                    return true;
                }
            default:
                return false;
        }

    }
    private Produto coletaDados(int tipoProduto)
    {
        try
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("SKU: ");
            string sku = Console.ReadLine();

            if (tipoProduto == 1)
            {
                Console.Write("Voltagem: ");
                string voltagem = Console.ReadLine();
                Console.Write("Bateria: ");
                bool bateria = bool.Parse(Console.ReadLine());

                ProdutoEletronico novoEletronico = new ProdutoEletronico(nome, preco, quantidade, sku, voltagem, bateria);

                return novoEletronico;
            }
            else
            {
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Cor: ");
                string cor = Console.ReadLine();
                Console.Write("Tamanho: ");
                string tamanho = Console.ReadLine();

                ProdutoVestuario novoVestuario = new ProdutoVestuario(nome, preco, quantidade, sku, modelo, cor, tamanho);

                return novoVestuario;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
    public void AtualizarQuantidade()
    {
        int idEscolhido;
        Produto produtoEscolhido;

        ListarProdutos();
        if (produtos.Count != 0)
        {
            Console.Write("Digite o número do produto que deseja atualizar a quantidade: ");
            try
            {
                idEscolhido = int.Parse(Console.ReadLine());
                produtoEscolhido = produtos[idEscolhido - 1];
                Console.Write("\nDigite a quantidade atual deste produto: ");
                int novaQuantidade = int.Parse(Console.ReadLine());
                produtoEscolhido.AtualizarQuantidade(novaQuantidade);
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada inválida tente novamente!");
            }
        }
    }
    public void RemoverProduto()
    {
        int idEscolhido;
        Produto produtoEscolhido;

        ListarProdutos();
        if (produtos.Count != 0)
        {
            Console.Write("Digite o número do produto que deseja remover: ");
            try
            {
                idEscolhido = int.Parse(Console.ReadLine());
                produtoEscolhido = produtos[idEscolhido - 1];
                produtos.Remove(produtoEscolhido);
                Console.WriteLine("Produto Removido com sucesso!");
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada inválida tente novamente!");
            }
        }
    }
}
