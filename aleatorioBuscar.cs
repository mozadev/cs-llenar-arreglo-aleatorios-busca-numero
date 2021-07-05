using System;
using System.Collections;
using System.Collections.Generic;

namespace ensenanza
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[20];
            //int RepUno = 0;

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(1, 30);// 1,2...29
                //array[0]=5
                //array[1]=7
                Console.Write(array[i] + " ");

                // if (array[i] == 1)
                // RepUno++;
            }

            Console.Write("escriba el numero a buscar:");
            int valorBuscado;
            valorBuscado = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (valorBuscado == array[i])
                {
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                Console.Write("\nEl valor buscado si esta en el arreglo");
            }
            else
                    {
                Console.Write("\nEl valor buscado si esta en el arreglo ");
            }

        }

    }
}