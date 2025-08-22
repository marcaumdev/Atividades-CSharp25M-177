
//Console.WriteLine("Digite o seu nome: ");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite a sua idade:");
//int idade = int.Parse(Console.ReadLine());

//Console.WriteLine("Nome: " + nome);
//Console.WriteLine("Idade: " + idade);

// Coleta o primeiro número da soma
//Console.WriteLine("Digite o primeiro número");
//int num1  = int.Parse(Console.ReadLine());

//// Coleta o segundo número da soma
//Console.WriteLine("Digite o segundo número");
//int num2 = int.Parse(Console.ReadLine());

//// Faz a soma dos dois números
//int soma = num1 + num2;

////Mostra a soma na tela
//Console.WriteLine($"O resultado da soma é = {soma}");

//Console.Write("Digite o seu nome: ");
//string nome = Console.ReadLine();

//Console.Write("Digite a sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//Console.Write("Digite a sua altura: ");
//double altura = double.Parse(Console.ReadLine());

//Console.WriteLine($"Olá {nome}, com {idade} ano(s) de idade e {altura} de altura");

Console.WriteLine("Digite o nome do produto");
string nomeProduto = Console.ReadLine();

Console.WriteLine("\nDigite a quantidade do produto");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("\nDigite o valor do produto");
double valorUnitario = double.Parse(Console.ReadLine());

Console.WriteLine("\nDigite quanto você tem para pagar");
double temDeDinheiro = double.Parse(Console.ReadLine());

double valorAPagar = valorUnitario * quantidade;

if((temDeDinheiro - valorAPagar) >= 0)
{
    Console.WriteLine($"\nVocê está comprando {quantidade} {nomeProduto}(s), no valor de {valorUnitario} cada, saindo em um total de {valorAPagar} o seu troco é de {temDeDinheiro - valorAPagar}");
}
else
{
    Console.WriteLine($"\nVocê está tentando comprar {quantidade} {nomeProduto}(s), no valor de {valorUnitario} cada, saindo em um total de {valorAPagar}, porém você não tem saldo o suficiente");
}

