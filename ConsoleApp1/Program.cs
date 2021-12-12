using System;

class MainClass
{/*
    static string GetDataFromConsole()
    {
        return Console.ReadLine();
    }
    static string ShowColor()
    {
        var favcolors = new string[3]; //объявляем массив из трех элементов
        //Console.WriteLine("Напишите цвета :");
        
        for (int i = 0; i < favcolors.Length; i++)
        {
            
           favcolors[i] = ShowColor();

        }
        Console.WriteLine("Ваши любимые цвета :");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;

            }
           // return color;
        }
        
        Console.ReadKey();
    }
    public static void Main(string[] args)
    {

        var (name, age) = ("Евгения", 27);

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        ShowColor();


    }
*/

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        int tmp = 0;
        for (int j = 0;j < result.Length; j++)
        {
            for (int k =0 + 1; k < result.Length; k++)
            {
                if (result[j] > result[k])
                {
                    tmp = result[j];
                    result[j] = result[k];
                    result[k] = tmp;

                }
                Console.WriteLine();
            }
            
        }
        foreach (var res in result)
        {
            Console.Write(res);
        }
        return result;
    }

}
