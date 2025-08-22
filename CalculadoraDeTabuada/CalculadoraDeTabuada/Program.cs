//bool calcularNovamente;

//do
//{
Console.WriteLine("=== Calculadora de Tabuada ===");
//Console.Write("Insira o número que deseja calcular: ");
for (int numero = 1; numero <= 9; numero = numero + 1)
{
    Console.WriteLine($"\n=== Tabuada do {numero} ===");
    for (int contador = 1; contador <= 10; contador++)
    {

        Console.WriteLine($"=== {numero} x {contador} = {contador * numero}");
    }
}