using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MatrizTotalPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Mi codigo
             * 
            int[,] matriz =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };
            */
            
            // Siendo transparente: El codigo corregido por ChatGPT

            Console.WriteLine("Ingresa numeros enteros separados por " + "," + " representando una matriz");
            string numeroIngresados = Console.ReadLine();
            string[] stringConvertidos = numeroIngresados.Split(',');
            int[,] matriz = new int[stringConvertidos.Length, 1] ;

            for (int i = 0; i < stringConvertidos.Length; i++)
            {
                matriz[i, 0] = Convert.ToInt32(stringConvertidos[i]);
            }
            //


            int totalPares = SumaPares(matriz);
            Console.WriteLine("El resultado total de la suma de pares de la matriz es: " + totalPares);
            Console.Read();
        }

        static int SumaPares(int[,] matriz)
        {
            int total = 0;
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength (1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i,j] % 2 == 0)
                    {
                        total += matriz[i, j];
                    }
                }
            }
            return total;
        }
    }
}
