using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoTriangular
{
    class Program
    {
        static void Main(string[] args)
        {
         //Datos
            int[,] tri = new int[,] { { 3, 0, 0, 0 },
                { 7, 4, 0, 0 },
                { 2, 4, 6, 0 },
                { 8, 5, 9, 3 } };

            Console.WriteLine("Problema original \n");
            imprimirArreglo(tri);
            sumaArr(tri);
            imprimirArreglo(tri);

            Console.WriteLine("Maximum path sum = " + pasar(tri).Max().ToString()+ "\n");

            Console.WriteLine("Ejercicio \n");

            int[,] trifinal = new int[,] {
                { 75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 95, 64, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 17, 47, 82, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 18, 35, 87 ,10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 20, 04, 82, 47, 65, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 19, 01, 23, 75, 03, 34, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 88, 02, 77, 73, 07, 63, 67, 0, 0, 0, 0, 0, 0, 0, 0},
                { 99, 65, 04, 28, 06, 16 ,70 ,92, 0, 0, 0, 0, 0, 0, 0},
                { 41, 41, 26, 56, 83, 40, 80, 70, 33, 0, 0, 0, 0, 0, 0},
                { 41, 48, 72, 33, 47, 32, 37 ,16, 94, 29, 0, 0, 0, 0, 0},
                { 53, 71, 44, 65, 25, 43, 91, 52 ,97, 51, 14, 0, 0, 0, 0},
                { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57, 0, 0, 0},
                { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48, 0, 0},
                { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40 ,31, 0},
                { 04, 62, 98, 27, 23, 09, 70, 98, 73 ,93, 38, 53, 60, 04, 23} };


            imprimirArreglo(trifinal);
            sumaArr(trifinal);
            imprimirArreglo(trifinal);
            Console.WriteLine("Maximum path sum = " + pasar(trifinal).Max().ToString());
            Console.ReadKey();
        }

        //Sumar los arreglos hacia abajo
        public static int[,] sumaArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(1) - 1; i++)
            {
                int bandera = 0;
                for (int j = 0; j < arr.GetLength(0) - 1; j++)
                {
                    {
                        if (bandera == 0)
                        {
                            arr[i + 1, j] = arr[i + 1, j] + arr[i, j];
                        }
                        bandera = 0;
                        if (arr[i + 1, j + 1] + arr[i, j] > arr[i + 1, j + 1] + arr[i, j + 1])
                        {
                            arr[i + 1, j + 1] = arr[i + 1, j + 1] + arr[i, j];
                            bandera = 1;
                        }

                    }
                }
            }

            return arr;
        }

        //Imprimir arreglo
        public static void imprimirArreglo(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //Pasar la ultima fila sumada a un arreglo de una dimension para encontrar el mayor valor
        public static int[] pasar(int[,] arr)
        {
            int[] arr2=new int[arr.GetLength(0)];
           
                for (int j = 0; j < arr.GetLength(0)-1; j++)
                {
                    arr2[j]= arr[arr.GetLength(0)-1,j];
                }
   
         
            return arr2;
        }
    }
}

