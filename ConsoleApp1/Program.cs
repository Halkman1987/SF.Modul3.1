
using System;


class MainClass
{
    //--------------------------- НАЧАЛО 5.3.13 ---------------------------------------
    public static void Main(string[] args)
    {

        int Mass = SortArray(int Array);

    }
    static void SortArray(int[] Array, out int[] sorteddesc, out int[] sortedasc)
    {
        sorteddesc = SortArrayDesc(Array);
        sortedasc = SortArrayAsc(Array);
    }
    static int[] SortArrayDesc(int[] result)
    {

        int tmp = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
                if (result[i] < result[j])
                {
                    tmp = result[i];
                    result[i] = result[j];
                    result[j] = tmp;
                }

        return result;
    }

    static int[] SortArrayAsc(int[] result)
    {

        int tmp = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
                if (result[i] > result[j])
                {
                    tmp = result[i];
                    result[i] = result[j];
                    result[j] = tmp;
                }

        return result;
    }



    //---------------------------- КОНЕЦ ---------------------------------------------


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


//------------------------------------Разбивка метода на два - ввод с консоли и сортировка -----------------------------
//public static void Main(string[] args)
//{

//    var arra = GetArrayFromConsole();// в arra  записываем значения полученные из консоли 
//    foreach (var t in arra)
//    {
//        Console.Write(t);
//    }
//    Console.WriteLine(" Вывод сортированного массива :");


//    //var rar = 
//    SortArray(arra);

//    foreach (var t in arra)
//    {
//        Console.Write(t + " , ");
//    }
//    Console.ReadKey();
//}


////Вводим элементы массива положительные и отрицательные --------------------
//static int[] GetArrayFromConsole()
//{
//    var result = new int[5];

//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//        result[i] = int.Parse(Console.ReadLine());
//    }
//    return result;
//}

////Сортируем массив который ввели ------------------------------------------
//static void SortArray(int[] results)
//{
//    int tmp = 0;
//    for (int i = 0; i < results.Length; i++)
//        for (int j = i + 1; j < results.Length; j++)
//            if (results[i] > results[j])
//            {
//                Console.WriteLine($"{results[i]} = {results[j]}");
//                tmp = results[i];
//                results[i] = results[j];
//                results[j] = tmp;
//            }

//}


//------------------------5.2.18 ------------------------------------
public static void Main(string[] args)
{
    var Array = GetArrayFromConsole(); //объявляем переменную куда будеи передаваться значение из метода
    ShowArray(Array, false);


    Console.ReadKey();
}

static int[] GetArrayFromConsole(int num = 10)
{
    var result = new int[num];

    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        result[i] = int.Parse(Console.ReadLine());

    }


    return result;
}

static void ShowArray(int[] Number, bool Sort = false)
{

    var tmp = Number;
    if (Sort)
    {
        tmp = SortArray(Number);
    }
    foreach (var item in tmp)
    {
        Console.Write(item + ",");
    }
}

static int[] SortArray(int[] result)
{

    int tmp = 0;
    for (int i = 0; i < result.Length; i++)
        for (int j = i + 1; j < result.Length; j++)
            if (result[i] > result[j])
            {
                tmp = result[i];
                result[i] = result[j];
                result[j] = tmp;
            }

    return result;
}
}

//------------------------------------------Рабочий метод с сортировкой массива вводимого в консоли (5.2.14) -----------------------------------------

//    public static void Main(string[] args)
//    {
//        var Array = GetArrayFromConsole(); //объявляем переменную куда будеи передаваться значение из метода

//        foreach (var item in Array) //смотрим что ввели
//        {
//            Console.Write(item + ",");
//        }

//        Console.WriteLine("Вывод массива после сортировки :");

//        Console.WriteLine();//отступ чтоб не путатся

//        SortArray(Array);// принимаем массив из первого метода GetArrayFromConsole
//        foreach (var item in Array)
//        {
//            Console.Write(item + ",");
//        }
//        Console.ReadKey();

//        var sotrdearray = SortArray(Array);
//        Console.WriteLine($"Выводим значение переменной : {sotrdearray}");
//        Console.ReadKey();
//    }



//    static int[] GetArrayFromConsole(int num = 5)
//    {
//        var result = new int[num];

//        for (int i = 0; i < result.Length; i++)
//        {
//            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//            result[i] = int.Parse(Console.ReadLine());

//        }


//        return result;
//    }

//    static int[] SortArray(int[] result)
//    {

//        int tmp = 0;
//        for (int i = 0; i < result.Length; i++)
//            for (int j = i + 1; j < result.Length; j++)
//                if (result[i] > result[j])
//                {
//                    tmp = result[i];
//                    result[i] = result[j];
//                    result[j] = tmp;
//                }

//        return result;
//    }






//}
