using System;

namespace EjercicioPropuesto1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* El usuario debe ingresar dos números y el programa mostrará 
            el resultado de la operación (a+b)*(a-b)*/ 

            int a, b, result;

            Console.WriteLine("Ingresa el valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de B: ");
            b = int.Parse(Console.ReadLine());
            result = (a+b)*(a-b);
            Console.WriteLine("Resultado: "+ result);

            Console.ReadKey();
        }
    }
}
