namespace Projeto_Estoque_2.Classes
{
    //Essa classe não pode se transformar num objeto
    public abstract class Produto
    {
        //nome, preço, quantidade, SKU
        public string nome { get; private set; }
        public double preco { get; private set; }
        public int quantidade { get; private set; }
        public string sku { get; private set; }

        //método construtor
        public Produto(string NomeRecebido, double Preco, int Quantidade, string sku)
        {
            nome = NomeRecebido;
            preco = Preco;
            quantidade = Quantidade;
            this.sku = sku;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($@"
|-------------------------
| Nome: {nome}
| Preço: {preco}
| Quantidade: {quantidade}
| Sku: {sku}");
        }

        public void AtualizarQuantidade(int quantidadeAtualizada)
        {
            if(quantidadeAtualizada >= 0)
            {
                quantidade = quantidadeAtualizada;
                Console.WriteLine("\nQuantidade atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("\nFalha ao atualizar a quantidade em estoque, a quantidade do produto não pode ser menor que zero!");
            }
        }

        //public string GetNome() { return nome; }

        //string Nome = GetNome();

    }
}
