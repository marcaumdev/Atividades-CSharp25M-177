Console.WriteLine("===== Bem-vindo a Calculadora =====");

Console.Write("Insira o primeiro número: ");
double num1 = ColetarValor();
Console.Write("Insira o segundo número: ");
double num2 = ColetarValor();

Console.Write(@$"
________________________
| Escolha sua operação |
|______________________|
| 1 - Soma             |
| 2 - Subtração        |
| 3 - Divisão          |
| 4 - Multiplicação    |
|______________________|
> ");
double operacao = ColetarValor();

switch (operacao)
{
    case 1:
        Soma(num1, num2);
        break;
    case 2:
        Subtracao(num1, num2);
        break;
    case 3:
        Divisao(num1, num2);
        break;
    case 4:
        Multiplicacao(num1, num2);
        break;
}

double ColetarValor()
{
    bool numeroValido = false;
    double valorColetado;

    while (!numeroValido)
    {
        try
        {
            valorColetado = Convert.ToDouble(Console.ReadLine());
            numeroValido = true;

            return valorColetado;
        }
        catch
        {
            Console.Write("Entrada digitada inválida, digite somente números: ");
        }
    }

    return 0;
}
void Soma(double num1, double num2)
{
    double soma = num1 + num2;
    Console.WriteLine($"\n{num1} + {num2} = {soma}");
}
void Subtracao(double num1, double num2)
{
    double subtracao = num1 - num2;
    Console.WriteLine($"\n{num1} - {num2} = {subtracao}");
}
void Divisao(double num1, double num2)
{
    double divisao = num1 / num2;
    Console.WriteLine($"\n{num1} / {num2} = {divisao}");
}
void Multiplicacao(double num1, double num2)
{
    double mutiplicacao = num1 * num2;
    Console.WriteLine($"\n{num1} X {num2} = {mutiplicacao}");
}