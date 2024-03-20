using System;

namespace Matriz
{
    class Program
    {

        static void Main(string[] args)
        {

            //Escrevo
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [{0}.{1}]:", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //Imprimi
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine();
            }


            //Soma
            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine();
            }


            //Soma Linha 1
            int somaLinha1 = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                somaLinha1 += matriz[0, i];
            }

            Console.WriteLine(somaLinha1);
            Console.WriteLine();


            //Soma Linha 2
            int somaLinha2 = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                somaLinha2 += matriz[1, i];
            }

            Console.WriteLine(somaLinha2);
            Console.WriteLine();


            //Soma Linha 3
            int somaLinha3 = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                somaLinha3 += matriz[2, i];
            }

            Console.WriteLine(somaLinha3);
            Console.WriteLine();


            //Soma Coluna 1
            int somaColuna1 = 0;

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                somaColuna1 += matriz[j, 0];
            }

            Console.WriteLine(somaColuna1);
            Console.WriteLine();


            //Soma Coluna 2
            int somaColuna2 = 0;

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                somaColuna2 += matriz[j, 1];
            }

            Console.WriteLine(somaColuna2);
            Console.WriteLine();


            //Soma Coluna 3
            int somaColuna3 = 0;

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                somaColuna3 += matriz[j, 2];
            }

            Console.WriteLine(somaColuna3);
            Console.WriteLine();


            //Soma Diagonal 0
            int somaDiagonal0 = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                somaDiagonal0 += matriz[i, i];
            }

            Console.WriteLine(somaDiagonal0);
            Console.WriteLine();


            //Soma Diagonal 1
            int somaDiagonal1 = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                somaDiagonal1 += matriz[i,matriz.GetLength(1) -i - 1];
            }

            Console.WriteLine(somaDiagonal1);
            Console.WriteLine();




        }
    }
}

    
    
  