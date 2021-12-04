using System;

class Mainclass
{

    public static void Main(string[] args)
    {
        // Очередное задание в модуле
       /* {
            var myapples = 5;
            var hisapples = 6;
            var hispeach = 5;

            var results = (myapples != hispeach) & (myapples < hisapples);
            Console.WriteLine(results);
            Console.ReadKey();
        }

        // переменные 
        {
            int a;
            int b;
            double x;
            double y;
            bool c = (a < b) | (x > y);
        }

        {
            var a = 6;
            var b = 7;
            var c = (a > b) ^ (a != b);
        }
        {
            var inv = true;
            var result = !inv;
            Console.WriteLine(result);
            Console.ReadKey();
        }
*/

        // Условия If to else... погнали
        {
            var a = 6;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else if(b<10)
            {
                Console.WriteLine("Значение b = {0} меньше 10",b);

            }
            else
            {
                Console.WriteLine("Значение b= {0} больше 10", b);
            }

            //Заменяем if\else 

            {
                Console.WriteLine("Напишите свой любимый цвет на англ яз с маленькой буквы");

                var color = Console.ReadLine();

                if (color == "red")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш цвет red");
                }

                else if (color == "green")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш цвет green");
                }
                    else
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш цвет cyan");
                }
                
            }
        }
    }

}