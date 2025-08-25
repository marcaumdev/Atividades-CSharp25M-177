//1. Remover Duplicatas 
//    - Receba 10 números em um array e exiba-os sem valores duplicados.

int[] numeros = new int[10];

int[] lista1 = new int[5];
int[] lista2 = new int[5];

void Mostrar_Array(int[] numeros)
{
    Console.WriteLine(" ");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine($"Numero {i + 1}: {numeros[i]}");
    }
}

void Coletar_Valores_Array(int[] valores)
{
    for (int i = 0; i < valores.Length; i++)
    {
        Console.Write($"Digite o número {i}: ");
        valores[i] = Convert.ToInt32(Console.ReadLine());
    }
}


//for (int i = 0;i < numeros.Length; i++)
//{
//    //1
//    int numero = numeros[i];
//    int repetido = 0;
//    //10
//    for (int j = 0; j < numeros.Length; j++)
//    {       //1  ==  1
//        if(numero == numeros[j])
//        {
//            repetido++;
//            if(repetido == 2)
//            {
//                numeros[j] = 0;
//            }
//        }
//    }
//}
//Coletar_Valores_Array(numeros);

//numeros = numeros.Distinct().ToArray();

//Mostrar_Array(numeros);

//Array.Sort(numeros);

//Mostrar_Array(numeros);

Coletar_Valores_Array(lista1);
Coletar_Valores_Array(lista2);

int[] interseccao_arrays = lista1.Intersect(lista2).ToArray();

Mostrar_Array(interseccao_arrays);