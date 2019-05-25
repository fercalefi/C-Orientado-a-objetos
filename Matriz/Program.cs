using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas da matriz 2:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de colunas da matriz:");
            int n2 = int.Parse(Console.ReadLine());

            int[,] m = new int[n1, n2];

  
            // linhas
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Digite a " + (i + 1) + "ª linha: ");

                string[] texto = Console.ReadLine().Split(' ');

                // colunas
                for (int j = 0; j < n2; j++)
                {
                    m[i, j] = int.Parse(texto[j]);
                }

            }

            Console.WriteLine("Digite o número a ser encontrado: ");
            int n3 = int.Parse(Console.ReadLine());

            //linha
            for (int i = 0; i  < n1; i++)
            {

                //colunas
                for (int j = 0; j < n2; j++)
                {
                    if (m[i,j] == n3){
                        Console.WriteLine("Posição: "+i+","+j);

                        if (j - 1 >= 0) 
                        {
                            Console.WriteLine("Esquerda: " + m[i, j - 1]);
                        }

                        if (j + 1 < n2)
                        {
                            Console.WriteLine("Direita: " + m[i, j + 1]);
                        }

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Acima: " + m[i-1, j]);
                        }

                        if (i + 1 < n1)
                        {
                            Console.WriteLine("Abaixo: " + m[i + 1, j]);
                        }



                    }
                    
     
                }

            }

    
          
        }
    }
}
