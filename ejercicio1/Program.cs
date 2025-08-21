namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar números hasta que ingrese el 0(fin del ingreso).
            // Se debe comparar con un número random e indicar cuando son iguales.
            try
            {
                int numero = 0;
                Random rnd = new Random();
                int numeroAleatorio = rnd.Next(1, 11);
                Console.WriteLine($"Numero aleatorio es: {numeroAleatorio}");

                Console.WriteLine("Ingrese un numero entre el 1 al 10");
                string texto = Console.ReadLine();
                bool exito = int.TryParse(texto, out numero);

                if (numero != 0 && numero <11 && exito)
                {
                    if(numero == numeroAleatorio)
                    {
                        Console.WriteLine("Son iguales");
                    }
                }
                else
                {
                    Console.WriteLine("Ingresaste 0 o un valor invalido");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            


        }
    }
}
