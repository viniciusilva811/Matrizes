using System;
using System.Globalization;
using System.Text.Json;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz desejada: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os numeros na matriz com espaco e após aperte ENTER para próxima linha: ");
            int[,] matriz = new int[n, n];

            for (int i=0; i < n; i++) {
                /*vai ler a linha e guardar o resultado no values e 
                 usando split pra separar os numeros */

                string[] values = Console.ReadLine().Split(' ');
                /* o FOR vai percorrer o "values" e 
                  guardando na matriz os elementos */

                for (int j = 0; j < n; j++ ) {
                    /*aqui percorre o vetor "values" já que é string 
                     e convertendo em int e guardando nas linhas da matriz */
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Numeros na diagonal principal: ");

            for (int i = 0; i < n; i++) {
             
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();



            /* abaixo é só uma comparação pra saber se é negativo ou não, 
              caso seja, ele retorna a quantidade de negativos. */
            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("Quantidade de numeros negativos: " +count); 
        }

    }
}
