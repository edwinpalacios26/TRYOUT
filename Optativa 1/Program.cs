using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum = 0;
            bool tocontinue = true;

            do
            {
                Console.Write("Ingrese el rango: ");
                int range = int.Parse(Console.ReadLine());

                for(int i = 0; i < range; i++)
                {
                    Console.Write("Ingrese el numero:");
                    int number = Int32.Parse(Console.ReadLine());
                    sum += number;
                }

                Console.WriteLine("Promedio: " + sum/range);

                Console.WriteLine("Desea continuar? s/n");
                char opc = char.Parse(Console.ReadLine());
                if(opc == 'n')
                tocontinue = false;

            }while(tocontinue);



        }
    }
}
