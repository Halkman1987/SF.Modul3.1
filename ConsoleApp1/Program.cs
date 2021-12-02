
using System;

class Mainclass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("как вас зовут? ");
        string Imya = Console.ReadLine();
        Console.WriteLine("Сколько вам лет? ");
        var age = int.Parse(Console.ReadLine());
        bool pet = true;
        Console.WriteLine("У вас есть питомец? "+ pet);
        double leg = 44.5;
        Console.WriteLine("У вас размер ноги " + leg);
        Console.WriteLine("Вас зовут {0} вам {1} лет , также у вас {2} питомец и у вас размер ноги {3}", Imya, age, pet, leg);
        Console.ReadKey();
    }
}
    
    /*const string MyName = "Dima\n";
    Console.WriteLine(MyName);
         Console.WriteLine("\t\u0023");
         Console.WriteLine("Ну вот \t\tкак-то так");
         Console.ReadKey();

        // Способ узнать вилку значений  числового типа данных
        Console.WriteLine("Минимум {0} ", float.MinValue);
        Console.WriteLine("Максимум {0} ", float.MaxValue);
        Console.ReadKey();
    





    // Обозначение перечисления через оператор enum
   
    {
        DaysOfWeeks MyFavoritedDay;
    MyFavoritedDay = DaysOfWeeks.Sunday;
        Console.WriteLine(MyFavoritedDay);
    }
}
    enum DaysOfWeeks : byte
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}


// const byte Monday = 1;
//const byte Tuesday = 2;
//const byte Wednesday = 3;
//const byte Thursday = 4;
//const byte Friday = 5;
//const byte Saturday = 6;
//const byte Sunday = 7;

enum ProgramData
{
    Programld = 123,
    Authorld = 567
}

enum Semaphore
{
    Reg = 100,
    Yellow = 200,
    Green = 300
}*/