using System;

namespace FuncionesBasicas_LibreriaMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            long result;
            
            Console.Write("Digite un número: ");
            num = int.Parse(Console.ReadLine());

            result = Math.Abs(num); //Es la distancia al que hay del num al 0 ejemplo: |-5-10|= 15
            Console.WriteLine("\nValor absoluto: "+ result);
            Console.WriteLine("Potencia: "+ Math.Pow(num,3)); //Elevado a la 3ra potencia
            Console.WriteLine("Raiz cuadrada: "+ Math.Sqrt(num));
            Console.WriteLine("Seno: "+ Math.Sin(num * Math.PI / 180)); //Sen = CO / HIP
            Console.WriteLine("Coseno: "+ Math.Cos(num * Math.PI / 180)); //Cos = CA / HIP
            Console.WriteLine("Número maximo: "+ Math.Max(num,50)); 
            Console.WriteLine("Número minimo: "+ Math.Min(num,50));
            Console.WriteLine("Parte entera: "+ Math.Truncate(30.95));
            Console.WriteLine("Redondeo: "+ Math.Round(30.78));
            
            Console.WriteLine("\nPulsa una tecla");
            Console.ReadKey();
        }
    }
}
