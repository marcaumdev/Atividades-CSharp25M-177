namespace Controle_de_Estoque
{
    public class GerenciadorEstoque
    {
        private List<Produto> produtos = new List<Produto>();
        public string Nome;
        public string Id;
        public string Endereco;

        public GerenciadorEstoque(string nome, string id, string endereco)
        {
            Nome = nome;
            Id = id;
            Endereco = endereco;
        }

        public bool CadastrarProduto()
        {
            Console.WriteLine(@"Qual tipo do produto você deseja cadastrar?
1 - Eletrônico
2 - Vestuário");
            int tipoCadastro = int.Parse(Console.ReadLine());

            if(tipoCadastro != 1 && tipoCadastro != 2) { return false; }

            string nome = ColetarVarivel("Nome");
            double valor = Convert.ToDouble(ColetarVarivel("Valor"));
            int quantidade = Convert.ToInt32(ColetarVarivel("Quantidade"));
            string sku = ColetarVarivel("SKU");
            string cor = ColetarVarivel("Cor");

            if (tipoCadastro == 1)
            {
                //Cadastra Eletrônico
                string voltagem = ColetarVarivel("Voltagem");
                double peso = Convert.ToDouble(ColetarVarivel("Quantidade"));
                bool bateria = Convert.ToBoolean(ColetarVarivel("Bateria"));

                Produto novoEletronico = new ProdutoEletronico(nome, valor, quantidade, sku, cor, voltagem, peso, bateria);
                produtos.Add(novoEletronico);

                return true;

            }
            else if(tipoCadastro == 2)
            {
                //Cadastrar Vestuário
                string tamanho = ColetarVarivel("Tamanho");
                string tecido = ColetarVarivel("Tecido");

                Produto novoVestuario = new ProdutoVestuario(nome, valor, quantidade, sku, cor, tamanho, tecido);
                produtos.Add(novoVestuario);
                return true;
            }

            return false;
        }

        private string ColetarVarivel(string titulo)
        {
            Console.Write($"{titulo}: ");
            return Console.ReadLine();
        }
    }
}
