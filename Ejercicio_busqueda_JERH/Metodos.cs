using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_busqueda_JERH
{
    public class Metodos
    {
        public void Ejercicio1() {
            // Declarar una matriz de números enteros (puedes modificar esta matriz según tus necesidades).
            int[] numeros = { 10, 23, 5, 42, 8, 17, 33, 15, 29, 11 };

            Console.Write("Ingresa el número que deseas buscar: ");
            int numeroABuscar = Convert.ToInt32(Console.ReadLine());
            int posicion=-1;
            for (int X = 0; X < numeros.Length; X++) {
                if (numeros[X] == numeroABuscar)
                {
                    posicion = X;
                    break;
                }  
            }
            
            Impreciones(posicion,"Ejercicio 1");
            
        }
        public void Ejercicio2()
        {
            // Declarar una matriz de números enteros (puedes modificar esta matriz según tus necesidades).
            string[] cadenas = { "Manzana", "Banana", "Naranja", "Uva", "Pera", "Kiwi" };

            Console.Write("Ingresa la cadena que deseas buscar: ");
            string cadenaABuscar = Console.ReadLine();
            int posicion = -1;

            for (int X = 0; X < cadenas.Length; X++)
            {
                if (cadenas[X] == cadenaABuscar)
                {
                    posicion = X;
                    break;
                }
            }

            Impreciones(posicion, "Ejercicio 2");

        }
        public void Ejercicio3()
        {
            // Declarar una matriz de números enteros (puedes modificar esta matriz según tus necesidades).
            int[] numeros = { 10, 23, 5, 42, 8, 17, 33, 15, 29, 11 };

         
            int posicion = -1;
            for (int X = 0; X < numeros.Length; X++)
            {
                if (numeros[X]%2 == 0)
                {
                    posicion = X;
                    break;
                }
            }

            Impreciones(posicion, "Ejercicio 3");

        }
        public void Ejercicio4()
        {
            // Declarar una matriz de números enteros (puedes modificar esta matriz según tus necesidades).
            int[] numeros = { 15, 7, 1, 21, 1, 1, 1, 3 };


            int contador=-1;
            for (int X = 0; X < numeros.Length; X++)
            {
                if (numeros[X] % 2 == 0)
                {
                    Console.WriteLine($"Se encontro el numero par{numeros[X]} en la posicion {X}");
                    contador++; 
                
                }else if(contador <= 0  && X==numeros.Length-1)
                    Console.WriteLine("No se encontro numero par");
            }

            

        }

        public void BinEjercicio1() {
            int[] numeros = { 0,11,22,23,60,99,88,646,1000,1009 };

            Console.Write("Ingresa el número que deseas buscar: ");
            
            int numeroABuscar = Convert.ToInt32(Console.ReadLine());
            busquedaEnteros(numeros, numeroABuscar);
            
        }

        public void BinEjercicio2()
        {
            string[] cadenas = { "hola", "programacion", "XD", "Eloy", "Limon", "Manzana", "SSS" };

            Console.Write("Ingrese una cadena a buscar: ");
            string candenaBuscar = Console.ReadLine();
            busquedaString(cadenas, candenaBuscar);

        }


        public void BinEjercicio3()
        {
            int[] numeros = { 1, 3, 5, 42, 8, 17, 33, 15, 29, 11 };


            BusquedaBe3(numeros);

        }

        //enteros
        public void busquedaEnteros(int[] numeros, int numeroABuscar) {

            int inicio = 0;
            int medio = 0;
            int fin = numeros.Length - 1;
            int indice = -1;

            while (inicio <= fin)
            {
               
                if (numeros[medio] == numeroABuscar)
                {
                    indice = medio;
                    break;
                }
                else if (numeroABuscar < numeros[medio])
                {
                    fin = medio - 1;
                }
                else
                {
                    inicio = medio + 1;
                }
                medio = (fin + inicio) / 2;
            }

            Impreciones(indice, "Ejercicio 1 de los binarios");

        }
        //String
        public void busquedaString(string[] cadena, string cadenaBuscar)
        {

            int inicio = 0;
            int medio = 0;
            int fin = cadena.Length - 1;
            int indice = -1;

            while (inicio <= fin)
            {
                int comparisonResult = string.Compare(cadena[medio], cadenaBuscar);

                if (comparisonResult == 0)
                {
                    indice = medio;
                    break;
                }
                else if (comparisonResult < 0)
                {
                    inicio = medio + 1;
                    
                }
                else
                {
                    fin = medio - 1;
                }
                medio = (fin + inicio) / 2;
            }

            Impreciones(indice, "Ejercicio 2 de los binarios");

        }

        public void BusquedaBe3(int[] numeros)
        {
            int inicio = 0;
            int right = numeros.Length - 1;
            int indice = -1;

            while (inicio <= right)
            {
                int Medio = inicio + (right - inicio) / 2;

                if (numeros[Medio] % 2 == 0)
                {
                    indice = Medio;
                    right = Medio - 1; // Buscar el primer número par, retrocediendo a la izquierda.
                }
                else
                {
                    inicio = Medio + 1;
                }
            }
        Impreciones(indice, "Ejercicio 3 de los binarios");
        }

        public void Impreciones(int posicion,string Mensage) {
            if (posicion != -1)
                Console.WriteLine($"En el {Mensage} se encontroen la posicion {posicion}");
            else
                Console.WriteLine($"En el {Mensage} no se encontro ");
        }

    }
}
