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

        // Календарь 
        {
           
        }
       
    }
    
        

        

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
            Console.ReadKey();
        }
        

                //Семафор перечисления
                enum Semaphore
                {
                Red = 100,
                Yellow = 200,
                Green = 300
                }

    }

}