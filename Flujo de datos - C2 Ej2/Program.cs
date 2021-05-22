using System;

namespace Flujo_de_datos___C2_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe un nombre de persona");
            string persona = Console.ReadLine();
            Console.WriteLine("Escribe un nombre de ciudad");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + persona + " bienvenido a " + ciudad);
        }
    }
}
