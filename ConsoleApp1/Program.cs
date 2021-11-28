// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Mainclass
{
    public static void Main(string[] args)
    {
        string MyName = "Dima";
        byte MyAge = 34;
        bool MyPet = true;
        double Leg = 43.5;

        Console.WriteLine("Меня зовут" + MyName);
        Console.WriteLine("Мне" +  MyAge,  "лет");
        Console.WriteLine("У Вас есть питомец?" +   MyPet);
        Console.WriteLine("Мой размер ноги" +   Leg);
        Console.ReadKey();
    }

}

