using System;

namespace InvertirNumero_2Cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, uni, dec, numeroInvertido;

            Console.WriteLine("Ingresa un número de dos cifras: ");
            num = int.Parse(Console.ReadLine());
            
            uni = num % 10;
            dec = num / 10;
            numeroInvertido = (uni * 10) + dec;

            Console.WriteLine("El número invertido es: " + numeroInvertido);
            Console.ReadKey();
        }
    }
}
