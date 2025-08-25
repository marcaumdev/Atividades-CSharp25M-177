//0, 1, 2, 3, 4
//int[] numeros = new int[5];

int[] numeros = { 10, 20, 30, 40, 50 };

string[] nomes = new string[5];

//Console.WriteLine($"posição 0 = {numeros[0]}");

numeros[0] = 15;

//Console.WriteLine($"posição 0 = {numeros[0]}");

for(int contador = 0; contador < numeros.Length; contador++)
{
    //Console.WriteLine($"posição {contador} = {numeros[contador]}");
}

void Saudacao()
{
    Console.WriteLine("Qual o seu nome?");
    string nome = Console.ReadLine();
    Console.WriteLine($"Olá {nome}! Seja Bem-Vindo(a)!");
}

int Somar(int num1, int num2)
{
    return num1 + num2;
}

void Cadastrar(string[] nomes)
{
    for(int i = 0; i < nomes.Length; i++)
    {
        Console.Write($"Diga o nome {i+1}: ");
        nomes[i] = Console.ReadLine();
    }

    for (int i = 0; i < nomes.Length; i++) 
    {
        Console.WriteLine($"Nome {i + 1} = {nomes[i]}");
    }
}

Cadastrar(nomes);