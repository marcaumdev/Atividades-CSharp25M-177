Random randNum = new Random();
bool acertou = false;

//Gera um número aleatório de 1 a 100
int numero_secreto = randNum.Next(100);

do
{
    //Recebe um número
    Console.Write($"\nDigite um número de 1 a 100: ");
    int numero_chutado = Convert.ToInt32(Console.ReadLine());

    acertou = VerificaNumero(numero_secreto, numero_chutado);

} while (!acertou);

bool VerificaNumero(int numero_secreto, int numero_chutado)
{
    //Verifica se esse numero é igual ao número secreto
    if (numero_secreto == numero_chutado)
    {
        //se for retorna sucesso!!
        Console.WriteLine($"Você acertou! o número é {numero_secreto}");
        return true;
    }
    //senão diz se o número é maior ou menor que o chutado
    else if (numero_chutado < numero_secreto)
    {
        Console.WriteLine($"O número é maior que {numero_chutado}");
    }
    else
    {
        Console.WriteLine($"O número é menor que {numero_chutado}");
    }
    return false;
}