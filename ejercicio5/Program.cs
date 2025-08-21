namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 5 Solicitar números hasta que se ingrese el 0.Se debe mostrar la suma de todos ellos.

            string texto;
            int numero;
            int acumulador =0;
           
            Console.WriteLine("Ingrese numero");
            texto = Console.ReadLine();
            bool exito = int.TryParse(texto, out numero);
            while (numero != 0 )
            {
                acumulador += numero;
                Console.WriteLine("Ingrese numero");
                texto = Console.ReadLine();
                exito = int.TryParse(texto, out numero);
            }
            if (exito && numero==0)
            {
               
                 Console.WriteLine("Saliste porque ingresaste 0");
                Console.WriteLine($"La suma total de los numeros ingresados es: {acumulador}");
                Console.ReadLine();
            }
           


        }
    }
}
