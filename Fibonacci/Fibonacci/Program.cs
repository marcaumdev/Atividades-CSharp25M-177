Console.Write("Quantos termos você deseja imprimir: ");
int quantidadeTermos = Convert.ToInt32(Console.ReadLine());

int numeroAtual = 0;
int numeroAnterior = 1;
int intermediaria;

for(int i = 1; i <= quantidadeTermos; i++)
{
    Console.Write($" {numeroAtual}");
    //guarda temporariamente o valor do numero atual
    intermediaria = numeroAtual;
    // calcula o novo número atual
    numeroAtual = numeroAtual + numeroAnterior;
    // Salva o numero anterior
    numeroAnterior = intermediaria;
    
}
