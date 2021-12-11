using System;

class Mainclass
{
    public static void Main(string[] args)
    {
                (string name, string family, string login, int loginlength, bool pet, double age, string[] color) User;

        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine("Введите имя пользователя : ");
            User.name = Console.ReadLine();

            Console.WriteLine("Введите фамилию пользователя : ");
            User.family = Console.ReadLine();

            Console.WriteLine("Введите логин пользователя : ");
            User.login = Console.ReadLine();
            User.loginlength = User.login.Length;
            Console.WriteLine("Длинна логин пользователя : {0}", User.loginlength);
            Console.WriteLine("Имеется ли у вас питомец Да/Нет : ");
            var result = Console.ReadLine();
            if (result == "да")
            {
                User.pet = true;
            }
            else
            {
                User.pet = false;
            }
            Console.WriteLine("Введите ваш возраст : ");
            User.age = double.Parse(Console.ReadLine());
            User.color = new string[3];
            Console.WriteLine("Введите три любимых цвета :");
            for (int i = 0; i < User.color.Length; i++)
            {
                User.color[i] = Console.ReadLine();
            }
            Console.WriteLine();
        }
                Console.ReadKey();

    }
}

// ----------------------------Анкета  о Питомце ---------------------------

//        (string Name, string Type, double Age, int NameCount) Pet;
//        Console.WriteLine("Введите имя питомца :");
//        Pet.Name = Console.ReadLine();
//        Console.WriteLine("Введите тип питомца :");
//        Pet.Type = Console.ReadLine();
//        Console.WriteLine("Введите возраст питомца :");
//        Pet.Age = Double.Parse( Console.ReadLine());
//        Pet.NameCount = Pet.Name.Length;
//        Console.WriteLine("Длина имени питомца : {0} ", Pet.NameCount);
//------------------------------------------------------------------------------------------------
//var (name, age) = ("Dima", 33);
//Console.WriteLine("You name :{0}", name);
//Console.WriteLine("You age : {0}", age);

//Console.Write("Insert you name:");
//name = Console.ReadLine();
//Console.Write("Insert you age :");
//age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("You name: {0} and  age :{1}", name, age);



//(string name, int age) anketa;
//Console.WriteLine("Ваше имя :");
//anketa.name = Console.ReadLine();
//Console.WriteLine("Введите ваш возраст цифрами :");
//anketa.age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ваше имя :{0} ", anketa.name);
//Console.WriteLine("Ваш возраст :{0} ", anketa.age);