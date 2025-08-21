namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar números hasta que ingrese el 0(fin del ingreso).
            // Se debe mostrar la tabla del mismo.  
            // Ejemplo ingresando el numero 2
            // 2 x 1 = 2
            // 2 x 2 = 4
            // 2 x 3 = 6
            // Hasta el 9
            int numero = 0;
            Console.Write("Ingrese un número");
            string texto = Console.ReadLine();
            
            bool exito = int.TryParse(texto, out numero);
            if (numero != 0)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"{numero} * {i} = {numero * i}");
                }
            }

            else if (numero == 0)
            {
                Console.WriteLine("Ingresaste el 0");
            }

            Console.WriteLine("Enter para continuar");
            Console.ReadLine();



        }
    }
}
