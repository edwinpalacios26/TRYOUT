using System;

namespace Structs
{
    class Program
    {
        //struct nodes
        struct Birthday
        {
            public int day;
            public int month;
            public int year;


        }
        static void Main(string[] args)
        {
            //birthday is 31/5/1999
            Birthday FirstBirthday;

            Console.Write("Enter day: ");
            FirstBirthday.day = int.Parse(Console.ReadLine());

            Console.Write("Enter month: ");
            FirstBirthday.month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            FirstBirthday.year = int.Parse(Console.ReadLine());

            //validation of data
            if(FirstBirthday.day == 31 && FirstBirthday.month == 5 && FirstBirthday.year == 1999)
            
                    Console.WriteLine("Happy Birthday!");
            else
                Console.WriteLine("Sorry it is not your birthday");
        }
    }
}
