Console.WriteLine("=== Calculadora de IMC ===");
bool calcularNovamente = false;

do
{
    Console.Write("\nDigite seu peso (kg): ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite sua altura (m): ");
    double altura = Convert.ToDouble(Console.ReadLine());

    double imc = peso / (altura * altura);

    if (imc <= 18.5)
    {
        Console.WriteLine($"IMC de {imc:F2} classificação Baixo Peso");
    }
    else if (imc >= 18.6 && imc <= 24.9)
    {
        Console.WriteLine($"IMC de {imc:F2} classificação Peso Normal");
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        Console.WriteLine($"IMC de {imc:F2} classificação Sobrepeso");
    }
    else if (imc >= 30 && imc <= 34.9)
    {
        Console.WriteLine($"IMC de {imc:F2} classificação Obesidade Grau I");
    }
    else if (imc >= 35 && imc <= 39.9)
    {
        Console.WriteLine($"IMC de {imc:F2} classificação Obesidade Grau II");
    }
    else
    {
        Console.WriteLine($"IMC de {imc:F2} classificação Obesidade Grau III");
    }

    bool decisaoValida;

    do
    {
        Console.WriteLine("\nDeseja calcular o IMC novamente? (1 = Sim, 2 = Não)");
        string decisao = Console.ReadLine();

        switch (decisao)
        {
            case "1":
                calcularNovamente = true;
                decisaoValida = true;
                break;
            case "2":
                Console.WriteLine("\nObrigado por usar a nossa calculadora de IMC!");
                calcularNovamente = false;
                decisaoValida = true;
                break;
            default:
                Console.WriteLine("\nOpção inválida digite uma opção válida");
                decisaoValida = false;
                break;
        }
    }while(decisaoValida == false);

}while(calcularNovamente == true);