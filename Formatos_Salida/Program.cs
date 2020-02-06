using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Formatos_Salida
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite un número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("{0:####.00}", num));
            Console.WriteLine(String.Format("{0:c}", num));
            Console.WriteLine(String.Format("{0:f}", num));
            Console.WriteLine( String.Format("{0:0%}", num));
            Console.WriteLine( String.Format("{0:f}", DateTime.Now));
            Console.WriteLine(String.Format("{0:dddd}{0:dd/MM//yyy}", DateTime.Now));

            Console.WriteLine("\nPresiona una tecla");
            Console.ReadKey();
        }
    }
}
