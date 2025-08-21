namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar una palabra y mostrarla en el otro sentido(Hola -> aloH).

            Console.WriteLine("Ingrese una palabra para invertir");
            string palabra = Console.ReadLine();
            string palabraInvertida = invertirPalabra(palabra);
            Console.WriteLine($"La palabra {palabra} invertida es {palabraInvertida}");
            Console.WriteLine("enter para salir");
            Console.ReadLine();
        }

        static string invertirPalabra (string palabra)
        {
            string palabraInvertida = "";
            for(int i= palabra.Length -1 ; i>=0; i--)
            {
                palabraInvertida += palabra[i];
            }
            return palabraInvertida; 
        }
    }
}
