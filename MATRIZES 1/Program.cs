using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIZES_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aula 79 Matrizes, aqui instanciação e algumas funções
            //Instanciar uma matriz
            //double[,] mat = new double[2, 3];
            //Usando length aponta a somatória total de caixinhas da matriz.
            //Console.WriteLine(mat.Length);
            //Usando rank é a primeira dimensão da matriz, indica o número de linhas.
            //Console.WriteLine(mat.Rank);
            //Usando getlength a dimensão da primeira dimensão é o numero de linhas, mas se eu por um numero diferente de zero aparece outro.
            //Console.WriteLine(mat.GetLength(0));
            //Aqui aparece o numero de coluna.
            //Console.WriteLine(mat.GetLength(1));
            //Console.ReadKey();
            #endregion

            #region Exercício resolvido Matrizes (aula 80)
            //int n = int.Parse(Console.ReadLine());
            //int[,] mat1 = new int[n, n];
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        string[] valor = Console.ReadLine().Split(' ');
            //        for (j = 0; j < n; j++)
            //        {
            //            mat1[i, j] = int.Parse(valor[j]);
            //        }
            //    }
            //}
            //Console.WriteLine("Main diagonal: ");
            //int count = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(mat1[i,i] + " ");
            //}
            //Console.WriteLine();
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        if(mat1[i, j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("Negative number: " + count);
            //Console.ReadKey();

            #endregion

            #region Exercicio de fixação 
            //Declarando as linhas e colunas n e m
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);
            //Fazer a inicialização
            int[,] mat2 = new int[m, n];
            //Percorrendo as linhas e colunas
            for(int i = 0; i < m; i++)
            {
                string[] valor1 = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat2[i, j] = int.Parse(valor1[j]);
                }
            }
            //Fazendo um x para percorrer as linhas e colunas e dando as posições de x.
            //Dando os valores de x, sendo os número a esquerda, direita, encima e embaixo.
            int x = int.Parse(Console.ReadLine());
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat2[i,j] == x)
                    {
                        Console.WriteLine("Posição " + i + ", " + j + " : ");
                    }
                    if(j > 0)
                    {
                        Console.WriteLine("Esquerda " + mat2[i, j - 1]);
                    }
                    if(i > 0)
                    {
                        Console.WriteLine("Acima " + mat2[i - 1, j]);
                    }
                    if(j < n - 1)
                    {
                        Console.WriteLine("Direita " + mat2[i, j + 1]);
                    }
                    if(i < m - 1)
                    {
                        Console.WriteLine("Abaixo " + mat2[i + 1, j]);
                    }
                }
            }
            Console.ReadKey();

            #endregion
        }
    }
}
