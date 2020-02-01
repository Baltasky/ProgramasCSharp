using System;

namespace Compra_en_Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
           byte canitdadCangreburgers, ordenPapas, cantidadBebidas;
           double pagar;
           const double precioCangreburguers = 60;
           const double precioPapas = 25.99;
           const double precioBebida = 15.50;

           Console.WriteLine("Catidad de cangreburgers: ");
           canitdadCangreburgers = byte.Parse(Console.ReadLine());
           Console.WriteLine("Catidad de orden de papas: ");
           ordenPapas = byte.Parse(Console.ReadLine());
           Console.WriteLine("Catidad de bebidas: ");
           cantidadBebidas = byte.Parse(Console.ReadLine());
           
           pagar = (canitdadCangreburgers * precioCangreburguers) 
           + (ordenPapas * precioPapas) + (cantidadBebidas * precioBebida);

           Console.WriteLine("Valor a pagar: " + pagar); 

           Console.WriteLine("\nPrecione na tecla");
           Console.ReadKey();
        }
    }
}
