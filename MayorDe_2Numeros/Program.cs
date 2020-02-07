using System;

namespace MayorDe_2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1} ",num1 ,num2);
            }
            else
            {
                if(num1 == num2)
                {
                    Console.WriteLine("{0} es igual que {1} ",num1 ,num2);
                }
                else 
                {
                    Console.WriteLine("{0} es menor que {1} ",num1 ,num2);  
                }
            }
            

            //otra forma de resolverlo

            string result;

            if(num1 > num2)
            {
                result = "Mayor";
            }else if (num1 == num2)
            {
                result = "Igula";
            }
            else
            {
                result = "Menor";
            }

               Console.WriteLine("{0} es {1} que {2} ",num1 ,result ,num2); 

            Console.ReadKey();
        }
    }
}
