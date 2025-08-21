using System;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Solicitar dos números(controlar que el primer número sea menor al segundo) 
                 y muestre todos los números entre los valores ingresados que sean pares. 
           
            Para salir se debe ingresar 0.*/
            try
            {

                string texto1, texto2;
                int num1, num2;
                Console.WriteLine("Ingrese primer numero");
                texto1 = Console.ReadLine();

                Console.WriteLine("Ingrese segundo numero");
                texto2 = Console.ReadLine();

                if (int.TryParse(texto1, out num1) && int.TryParse(texto2, out num2))
                {
                    if (num1 < num2)
                    {
                        for (int i = num1; i < num2; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine($"El numero {i} forma parte de los pares del rango {num1} al {num2} ");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Salir de la aplicacion");
                    Console.ReadLine();
                }
                Console.WriteLine("Enter para salir");
                Console.ReadLine();

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
           
        }
    }
}
