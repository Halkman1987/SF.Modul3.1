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
>>>>>>> Stashed changes

        /* Console.WriteLine("Введите свое имя");
         var name = Console.ReadLine();
         Console.WriteLine("Введите свой возраст");
         var age = checked((byte)int.Parse(Console.ReadLine()));
         Console.WriteLine("Your name is {0} and age is {1} ", name, age);

         Console.Write("What is your favorite day of week? ");

         var day = (DayOfWeek)int.Parse(Console.ReadLine());
         Console.WriteLine("Your favorite day is {0}", day);
         Console.ReadKey();*/



        // Инкремент и декремент 
        {
            /* int counter = 10;
             Console.WriteLine("Value:{0} decrement:{1}", counter, --counter);
             Console.ReadKey();*/
        }



        //конвертирование строки в числовое значение
        {
            /*Console.Write("Укажите свой возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш Возраст {0}", age);
            Console.ReadKey();*/
        }

        //Конвертирование через Parse и TryParse 
        {
            /*Console.Write("Укажите свой возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш Возраст {0}", age);
            Console.ReadKey();*/

        }

        //Через TryParse и bool значение
        {
           /* Console.Write("Укажите свой возраст:");
            int age;
            bool iscorrect = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Ваш Возраст {0}", age);
            Console.ReadKey();*/
        }

        //Продолжаем развлекаться...вводим возраст больше byte. Но если указать
        //   int intage = age;
        //   Console.WriteLine("Your name is {0} and age is {1} ", name, intage); произойдет процесс расширения переменной age в intage
        {
           /* Console.Write("Ваше имя ");
            string name = Console.ReadLine();
            Console.Write("Ваш возраст : ");
            byte age = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Ваше имя {0} и ваш возраст {1} ", name, age);
            Console.ReadKey();*/

        }
        // Проверка конвертации посредством checked
        {
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("какой твой любимый день недели?: ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Твой любимый день {0} ", day);
            Console.ReadKey();*/
        }

        //Объявление неявной типизации через переменную var, она сама определяет тип по присвоенному значению переменной
        {
            Console.Write("Введите свое имя:");
            var name = Console.ReadLine();
            Console.Write("Введите свой возраст:");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Ваше имя {0} и возраст {1}", name, age);
            Console.WriteLine("Ваш любимый день недели?");
            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Твой любимый день {0} ", day);
            Console.Write("Введите свой день рождения:");
            var d = double.Parse(Console.ReadLine());
            Console.WriteLine("Ваш день рождения {0}", d);
            Console.ReadKey();
        }
        /*

                //Семафор перечисления
                enum Semaphore
                {
                Red = 100,
                Yellow = 200,
                Green = 300
                }*/

    }

}