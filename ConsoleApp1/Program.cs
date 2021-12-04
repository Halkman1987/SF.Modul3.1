using System;

class Mainclass
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {

        {
            /*const string MyName = "Dima\n";
        Console.WriteLine(MyName);
        Console.WriteLine("\t\u0023");
        Console.WriteLine("Ну вот \t\t как-то так");
        Console.ReadKey();*/

            /* Console.Write("Напиши возраст:");
             int age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ваш возраст {0}", age);
             Console.ReadKey();*/

        }



    


        /*string MyName = "Dima";
        byte MyAge = 34;
        bool MyPet = true;
        double Leg = 43.5;

        Console.WriteLine("Меня зовут" + MyName);
        Console.WriteLine("Мне" + MyAge, "лет");
        Console.WriteLine("У Вас есть питомец?" + MyPet);
        Console.WriteLine("Мой размер ноги" + Leg);
        Console.ReadKey();*/
    }
    

    
        

        //Финальное задание по модулю

        
            Console.Write("Введите свое имя:");
            var name = Console.ReadLine();
            Console.Write("Введите свой возраст:");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Ваше имя {0} и возраст {1}", name, age);
            Console.Write("Введите дату рождения:");
            var god = double.Parse(Console.ReadLine());
            Console.WriteLine("Ваш год рождения {0} ", god);
            Console.ReadKey();
        
    
    
}