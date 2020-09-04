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

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++ ) {

                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Numeros na diagonal principal: ");

            for (int i = 0; i < n; i++) {

                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

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
