using System;

namespace InvertiNumero_3Cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cen, dec, uni, numeroInvertio;

            Console.WriteLine("Ingresa un número de tres cifras: ");
            num = int.Parse(Console.ReadLine());

            cen = num / 100;
            num = num % 100;
            dec = num / 10;
            uni = num % 10;
            numeroInvertio = (uni * 100) + (dec * 10) + cen;

            Console.WriteLine("El número invertido es: " + numeroInvertio);
            Console.ReadKey();
        }
    }
}
