﻿
using System;

class MainClass
{
      //---------------------------МОдуль 5----------------------
    static string ShowColor(string username, int userage)
    {
        
        Console.WriteLine("{0} которуму {1} лет,\nНапишите свой любимый цвет на английском с маленькой буквы ",username, userage);
        var color = Console.ReadLine();

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
        return color;
    }

    public static void Main(string[] args)
    {
        var (name,name1, age) = ("Евгения", "Анавасий" ,27); //Довавляю новую переменную name1("Анавасий") и вписываю обращение к ней четез метод ShowColor( всё получилось )
        
       

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0} и ваш возраст {1}", name,age);
        //Console.WriteLine("Ваш возраст: {0}", age);

        // ShowColor();
        var favcolor = new string[3];
        for (int i =0; i < favcolor.Length; i++)
        {
            favcolor[i] = ShowColor(name1,age);
        }
        Console.WriteLine("ваши любимые цвета");
        foreach(var color in favcolor)
        {
            Console.WriteLine(color);
        }
        Console.ReadKey();
    } 
}

static string ShowColor(string username, int userage)
{

    Console.WriteLine("{0} которуму {1} лет,\nНапишите свой любимый цвет на английском с маленькой буквы ", username, userage);
    var color = Console.ReadLine();

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
    return color;
}

public static void Main(string[] args)
{
    var (name, name1, age) = ("Евгения", "Анавасий", 27); //Довавляю новую переменную name1("Анавасий") и вписываю обращение к ней четез метод ShowColor( всё получилось )



    Console.WriteLine("Мое имя: {0}", name);
    Console.WriteLine("Мой возраст: {0}", age);

    Console.Write("Введите имя: ");
    name = Console.ReadLine();
    Console.Write("Введите возрас с цифрами:");
    age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ваше имя: {0} и ваш возраст {1}", name, age);
    //Console.WriteLine("Ваш возраст: {0}", age);

    // ShowColor();
    var favcolor = new string[3];
    for (int i = 0; i < favcolor.Length; i++)
    {
        favcolor[i] = ShowColor(name1, age);
    }
    Console.WriteLine("ваши любимые цвета");
    foreach (var color in favcolor)
    {
        Console.WriteLine(color);
    }
    Console.ReadKey();
}