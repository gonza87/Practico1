namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar una palabra y mostrar la cantidad de vocales que tiene.
            
            Console.WriteLine("Ingrese una palabra para saber cuantas vocales tiene");
            string palabra = Console.ReadLine().ToLower();
            int cantVocales = examinarvocal(palabra);
            Console.WriteLine($"La cantiad de vocales que tiene la palabra :{palabra} es {cantVocales}");
            Console.WriteLine("Enter para salir");
            Console.ReadLine();
        }

        static int examinarvocal(string palabra)
        {
            int contador = 0;
            for(int i =0; i<palabra.Length; i++)
            {
                if (palabra[i]== 'a' || palabra[i] == 'e' || palabra[i] =='i' || palabra[i]== 'o' || palabra[i]=='u')
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
