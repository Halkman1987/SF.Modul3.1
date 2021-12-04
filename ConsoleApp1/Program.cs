using System;

class Mainclass
{
    
    public static void Main(string[] args)
    {
        // Очередное задание в модуле
        {
            const string MyName = "Dima\n"; к
            Console.WriteLine(MyName);
            Console.WriteLine("\t\u0023");
            Console.WriteLine("Ну вот \t\t как-то так");
            Console.ReadKey();

            Console.Write("Напиши возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш возраст {0}", age);
            Console.ReadKey();

        }
        //  Небольшая анкетка
        {
            string MyName = "Dima";
            byte MyAge = 34;
            bool MyPet = true;
            double Leg = 43.5;

            Console.WriteLine("Меня зовут" + MyName);
            Console.WriteLine("Мне" + MyAge, "лет");
            Console.WriteLine("У Вас есть питомец?" + MyPet);
            Console.WriteLine("Мой размер ноги" + Leg);
            Console.ReadKey();
        }

        //   Финальное задание по модулю (но хотелось бы разобраться как посчитать не только сколько лет но и месяцев и дней)
        {
            Console.Write("Введите свое имя:");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя {0}", name);
            Console.Write("Введите дату рождения:");
            var god = Console.ReadLine();
            Console.WriteLine("Ваш год рождения {0} ", god);
            
            Console.Write(" Введите текущий год :\n");
            int gggg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год вашего рождения:");
            int ggg = Convert.ToInt32(Console.ReadLine());
            int gg = gggg - ggg;
            Console.WriteLine("Теперь давайте посчитаем сколько вам лет ");
            Console.Write("Вам {0} лет", gg);
            Console.ReadKey();
        }

       
    }
    
        

        

        
            
        
    
    
}