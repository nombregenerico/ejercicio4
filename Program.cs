using System;

namespace ejercicio4
{
    public sealed class ExpresionLambdaComoParametro
    {
        // Método que se encarga de operar los operandos 
        // de una operación binaria (e.g., suma, resta, producto, cociente):
        public static int Calcular(Func<int, int, int> operacion, int num1, int num2)
        {
            return operacion(num1, num2);
        }

        public static void Main()
        {
            Console.Write("Escriba un número entero: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Escribe otro número entero: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, Calcular((x, y) => x + y, num1, num2));
            Console.WriteLine("{0} - {1} = {2}", num1, num2, Calcular((x, y) => x - y, num1, num2));
            Console.WriteLine("{0} * {1} = {2}", num1, num2, Calcular((x, y) => x * y, num1, num2));
            Console.WriteLine("{0} / {1} = {2}", num1, num2, Calcular((x, y) => x / y, num1, num2));
        }
    }
}