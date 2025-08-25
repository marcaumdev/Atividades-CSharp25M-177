bool EhPrimo(int numero)
{
    Console.WriteLine(" ");
    if(numero < 2)
    {
        Console.WriteLine("Número menor que 2, não pode ser primo");
        return false;
    }
    for(int i = 2; i < numero; i++)
    {
        Console.WriteLine($"{numero}/{i} = {numero / i}");
        if(numero % i == 0)
        {
            Console.WriteLine("Esse número não é primo!");
            return false;
        }
    }

    return true;
}

bool Contem(int[] lista, int valor)
{
    foreach (int item in lista)
    {
        if (item == valor)
        {
            return true;
        }
    }
    return false;
}

int[] lista = { 1, 2, 3 };

int Fibonnaci(int numero)
{
    if(numero == 0)
    {
        Console.WriteLine("Numero é 0");
        return 0;
    }
    else if (numero == 1)
    {
        Console.WriteLine("Numero é 1");
        return 1;
    }

    return Fibonnaci(numero - 1) + Fibonnaci(numero - 2);
}

Console.WriteLine(Fibonnaci(14));