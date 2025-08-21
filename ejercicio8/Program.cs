namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar una palabra e indicar si es palíndromo(somos).
            // Un palíndromo es una palabra, frase o número que se lee igual de izquierda a derecha que de derecha a izquierda.
            // Algunos ejemplos comunes son "reconocer", "oso" y "ala".

            Console.WriteLine("ingrese una palabra para saber si es Polindromo");
            string palabra = Console.ReadLine().ToLower();
            bool esPolindromo;
            esPolindromo = examinarPalabra(palabra);
            if (esPolindromo)
            {
                Console.WriteLine("es polindromo");
            }
            else
            {
                Console.WriteLine("NO es polindromo");

            }
            Console.WriteLine("Enter para salir");
            Console.ReadLine();

        }

        static bool examinarPalabra(string palabra)
        {
            
            bool esPalindromo = true;

         

            // Iteramos solo hasta la mitad de la palabra para evitar comparaciones duplicadas.
            int longitud = palabra.Length;
            for (int i = 0; i < longitud / 2; i++)
            {
                // Si encontramos un par de caracteres que no coinciden...
                if (palabra[i] != palabra[longitud - 1 - i])
                {
                    // ...la palabra no es un palíndromo.
                    // Cambiamos el estado a false y salimos del bucle con 'break'.
                    esPalindromo = false;
                    break;
                }
            }

            // Devolvemos el resultado final. Si el bucle terminó sin encontrar diferencias,
            // esPalindromo se mantendrá como true.
            return esPalindromo;
        }
    }
}
