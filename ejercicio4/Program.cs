namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar dos números y un valor, indicar si el valor está comprendido entre los números

            try
            {
                int num1, num2, valor;
                string texto1, texto2, textoValor;
                Console.WriteLine("Ingrese el primer numero");
                texto1 = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo numero");
                texto2= Console.ReadLine();
                Console.WriteLine("Ingrese un valor");
                textoValor = Console.ReadLine();
                
                if(int.TryParse(texto1,out num1) && int.TryParse(texto2, out num2) && int.TryParse(textoValor, out valor))
                {
                   
                    if (num1 < num2 && valor > num1 && valor < num2)
                    {
                        Console.WriteLine($"El numero {valor} se encuentra dentro del rango {num1} al {num2}");
                    }
                    else if(num2 < num1 && valor < num1 && valor >num2)
                    {

                        Console.WriteLine($"El numero {valor} se encuentra dentro del rango {num2} al {num1}");
                    }
                    else
                    {
                        Console.WriteLine("El numero no se encuentra dentro del rango");
                    }
                   
                }

                Console.WriteLine("Enter para salir");
                Console.ReadLine();

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
