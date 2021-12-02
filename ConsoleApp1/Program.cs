


using System;

class Mainclass
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {

        /*const string MyName = "Dima\n";
        Console.WriteLine(MyName);
        Console.WriteLine("\t\u0023");
        Console.WriteLine("Ну вот \t\tкак-то так");
        Console.ReadKey();*/

        /* Console.Write("Напиши возраст:");
         int age = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ваш возраст {0}", age);
         Console.ReadKey();*/

        /*Console.Write("Ваше имя ");
        string name = Console.ReadLine();
        Console.Write("Ваш возраст ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Ваше имя {0} и ваш возраст {1} ", name, age);
        Console.ReadKey();
*/ /*
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        Console.Write("какой твой любимый день недели? ");
        DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Твой любимый день {0} ", day);
        Console.ReadKey();

        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Ваше имя {0} и возраст {1}", name, age);
        Console.WriteLine("Ваш любимый день недели?");
        var day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Твой любимый день {0} ", day);
        Console.ReadKey();*/


        Console.WriteLine("Введите свое имя");
        var name = Console.ReadLine();
        Console.WriteLine("Введите свой возраст");
        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);

        Console.Write("What is your favorite day of week? ");

        var day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0}", day);
        Console.ReadKey();

    }

}