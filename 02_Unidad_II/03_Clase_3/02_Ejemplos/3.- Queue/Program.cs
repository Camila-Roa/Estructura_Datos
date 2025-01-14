﻿using System;
using System.Collections;
using System.Text;


namespace AplicacionBase
{

    class Program
    {
        // Esta  es   la  funcion principal del   programa
        // Aqui inicia  la aplicacion static void   Main(string[] args)

        static void Main(string[] args)
        {

            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;

            // Creamos el Queue
            Queue miCola = new Queue();

            do
            {
                // Menú para manipular la Cola

                Console.WriteLine("1- Enqueue");     // Agregar un elemento a la cola
                Console.WriteLine("2- Dequeue");     // Borrar un elemento de la cola
                Console.WriteLine("3- Clear");       // Limpiar toda a cola
                Console.WriteLine("4- Contains");    // Ubicar un elemento en la cola
                Console.WriteLine("5- Salir");

                Console.Write("Dime una opcion del menú: ");
                
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);


                if (opcion == 1)
                {
                    // Agregar un valor al Queue

                    Console.WriteLine("");
                    Console.Write("Introduce un número para la cola:  ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    // Adicionamos  el  valor en  el queue
                    miCola.Enqueue(numero);

                }

                if (opcion == 2)
                {
                    // Mostrar y extraer un elemento del Queue

                    numero = (int)miCola.Dequeue();


                    // Mostramos el  elemento
                    Console.WriteLine("");
                    Console.WriteLine("El valor obtenido es: {0}", numero);

                }

                if (opcion == 3)
                {

                    // Limpiamos todos los contenidos del Queue
                    miCola.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("La cola ha sido limpiada");
                }

                if (opcion == 4)
                {

                    // Pedimos  el  valor a  encontrar
                    Console.WriteLine("");
                    Console.Write("Dame el valor a encontrar:  ");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    // Vemos si el elemento se encuentra
                    encontrado = miCola.Contains(numero);

                    // Mostramos el  resultado
                    
                    Console.WriteLine("");
                    Console.WriteLine("Encontrado = {0}", encontrado);

                }

                // Mostramos la  informacion del   stack
                Console.WriteLine("");
                Console.WriteLine("La cola tiene {0} elemento(s)", miCola.Count);
                Console.WriteLine("");


            } while (opcion != 5);

            foreach (int n in miCola)
                Console.Write("  {0} ", n);

            Console.WriteLine("");
            Console.WriteLine("___________________");
            Console.WriteLine("");
        }
    }
}
