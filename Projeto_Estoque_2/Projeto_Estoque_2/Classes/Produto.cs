namespace Projeto_Estoque_2.Classes
{
    //Essa classe não pode se transformar num objeto
    public abstract class Produto
    {
        //nome, preço, quantidade, SKU
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }
        public string sku { get; set; }

        //método construtor
        public Produto(string NomeRecebido, double Preco, int Quantidade, string sku)
        {
            nome = NomeRecebido;
            preco = Preco;
            quantidade = Quantidade;
            this.sku = sku;
        }

    }
}
