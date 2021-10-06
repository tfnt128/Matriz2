using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetor de string para o espaço
            string[] s = Console.ReadLine().Split(' ');           
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]); 

            //criando a matriz mat
            int[,] mat = new int[m, n];

            //for para a digitação e alocação em cada área da matriz
            for (int i = 0; i < m; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < m; i++)
            {
                //for para cada posição do inteiro "x" escolhido
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Posição " + i + ", " + j + ":");
                        if (j != 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, (j - 1)]);
                        }
                        if (j != (n - 1))
                        {
                            Console.WriteLine("Direita: " + mat[i, (j + 1)]);
                        }
                        if (i != 0)
                        {
                            Console.WriteLine("Cima: " + mat[(i - 1), j]);
                        }
                        if (i != (m - 1))
                        {
                            Console.WriteLine("Baixo: " + mat[(i + 1), j]);
                        }

                    }

                }
            }
        }
    }
}
