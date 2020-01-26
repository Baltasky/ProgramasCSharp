using System;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;

            Console.WriteLine("Ingresa el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("La suma es: {0}", result);
            result = num1 - num2;
            Console.WriteLine("La resta es: {0} - {1} = {2}", num1, num2, result);
            result = num1 * num2;
            Console.WriteLine("La multiplicación es: {0}", result);
            result = num1 / num2;
            Console.WriteLine("La división es: {0}", result);
            result = num1 % num2;
            Console.WriteLine("El residuo es: {0}", result);

            Console.WriteLine("\nPresiona una tecla");
            Console.ReadKey();
        }
    }
}
