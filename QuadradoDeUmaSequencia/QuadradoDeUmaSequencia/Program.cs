Console.Write("Informe a quantidade de número que deseja calcular: ");
int resposta = Convert.ToInt32(Console.ReadLine());

for(int numero = 1; numero <= resposta; numero++)
{
    Console.WriteLine($"Quadrado do número {numero}: {numero * numero}");
}