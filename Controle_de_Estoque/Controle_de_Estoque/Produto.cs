namespace Controle_de_Estoque
{
    //2. cada produto deve ter um nome, um preço, uma quantidade em estoque e um código SKU.
    public abstract class Produto
    {
        public string nome;
        public double valor;
        public int quantidade;
        public string sku;
        public string cor;
        public Produto(string Nome, double Valor, int Quantidade, string SKU, string Cor)
        {
            nome = Nome;
            valor = Valor;
            quantidade = Quantidade;
            sku = SKU;
            cor = Cor;
        }
    }
    public class ProdutoEletronico : Produto
    {
        public string voltagem;
        public double peso;
        public bool bateria;

        public ProdutoEletronico(string Nome, double Valor, int Quantidade, string SKU, string Cor, string Voltagem, double Peso, bool Bateria) : base(Nome, Valor, Quantidade, SKU, Cor)
        {
            voltagem = Voltagem;
            peso = Peso;
            bateria = Bateria;
        }
    }

    public class ProdutoVestuario : Produto
    {
        public string tamanho;
        public string tecido;

        public ProdutoVestuario(string Nome, double Valor, int Quantidade, string SKU, string Cor, string Tamanho, string Tecido) : base(Nome, Valor, Quantidade, SKU, Cor)
        {
            tamanho = Tamanho;
            tecido = Tecido;
        }
    }
}
