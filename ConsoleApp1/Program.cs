using System;
class MainClass
{
    //--------------------------------------- Модуль 5.5.4 ФАКТОРИАЛ -------------------------------
    public static void Main(string[] args)
    {
        //decimal res;
        //Console.WriteLine("Напишите  число  :");
        //int num = int.Parse(Console.ReadLine());   
        //res = Factorial(num);
        //Console.WriteLine("факториал числа {0} = {1}", num, res);
        // Console.ReadKey();  

        Console.WriteLine("введите число");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("введите степень :");
        byte pow = byte.Parse(Console.ReadLine());
        PowerUp(N, pow);
        Console.WriteLine(N + ",");


    }

    private static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N = N * PowerUp(N, --pow);
            }

        }


    }
}
// static decimal Factorial(int x)
/*  {
      if (x == 0)
      {
          return 1;
      }
      else
      {
             return x * Factorial(x - 1);
      }

  }
*/
//---------------------------------- КОНЕЦ -----------------------------------


////--------------------------------------- Модуль 5.5.4 РЕКУРСИЯ -------------------------------
//public static void Main(string[] args)
//{
//    Console.WriteLine("Напишите что-то");

//    var str = Console.ReadLine();

//    Console.WriteLine("Укажите глубину эха");

//    var deep = int.Parse(Console.ReadLine());

//    Echo(str, deep);

//    Console.ReadKey();

//}

//static void Echo(string said, int deep)
//{
//    //Console.WriteLine(phrase + "Наша фраза");

//    var modif = said;

//    if (modif.Length > 2)
//    {
//        modif = modif.Remove(0, 2);

//    }
//    Console.BackgroundColor = (ConsoleColor)deep;
//    Console.WriteLine("...." + modif);


//    if (deep > 1)
//    {
//        Echo(modif, deep - 1);
//    }


//}
////---------------------------------- КОНЕЦ -----------------------------------


////--------------------------- НАЧАЛО 5.3.13 ---------------------------------------
//public static void Main(string[] args)
//{
//    int[] Array = GetArrayFromConsole();

//    SortArray(Array);


//}
//static int[] GetArrayFromConsole(int num = 10)
//{
//    var result = new int[num];

//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//        result[i] = int.Parse(Console.ReadLine());

//    }


//    return result;
//}
//static void SortArray(in int[] Array, out int[] sorteddesc, out int[] sortedasc)
//{
//    sorteddesc = SortArrayDesc(Array);
//    sortedasc = SortArrayAsc(Array);

//}
//static int[] SortArrayDesc(int[] result)
//{

//    int tmp = 0;
//    for (int i = 0; i < result.Length; i++)
//        for (int j = i + 1; j < result.Length; j++)
//            if (result[i] < result[j])
//            {
//                tmp = result[i];
//                result[i] = result[j];
//                result[j] = tmp;
//            }

//    return result;
//}

//static int[] SortArrayAsc(int[] result)
//{

//    int tmp = 0;
//    for (int i = 0; i < result.Length; i++)
//        for (int j = i + 1; j < result.Length; j++)
//            if (result[i] > result[j])
//            {
//                tmp = result[i];
//                result[i] = result[j];
//                result[j] = tmp;
//            }

//    return result;
//}
//-------------------------------------- КОНЕЦ -----------------------------------------


//---------------------------- НАЧАЛО ( не понмню номер задания 5.2....) ---------------------------------------------





//static int[] GetArrayFromConsole(int num = 10)
//{
//    var result = new int[num];

//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//        result[i] = int.Parse(Console.ReadLine());

//    }


//    return result;
//}

//static void ShowArray(int[] Number, bool Sort = false)
//{

//    var tmp = Number;
//    if (Sort)
//    {
//        tmp = SortArray(Number);
//    }
//    foreach (var item in tmp)
//    {
//        Console.Write(item + ",");
//    }
//}

//static int[] SortArray(int[] result)
//{

//    int tmp = 0;
//    for (int i = 0; i < result.Length; i++)
//        for (int j = i + 1; j < result.Length; j++)
//            if (result[i] > result[j])
//            {
//                tmp = result[i];
//                result[i] = result[j];
//                result[j] = tmp;
//            }

//    return result;
//}






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

//------------------------ НАЧАЛО 5.3 ------------------------------------
//public static void Main(string[] args)
//{

//    var SoName = "Дмитрий";
//    Console.WriteLine(SoName);
//    int Age = 34;
//    Console.WriteLine(Age);

//    GetName(ref SoName);//Передаем переменную SoName в метод для ввода в неё новых данных

//    Console.WriteLine(SoName);

//    ChangeAge(Age);//Передаем переменную Age в метод для ввода в неё новых данных

//    Console.WriteLine(Age);


//    //---------------------------
//    var arr = new int[] { 1, 2, 3 };
//    var data = 5;
//    BigDataOperation(in arr, ref data);
//    Console.WriteLine(data);
//    Console.WriteLine(arr[0]);
//    //------------------------------

//    Console.ReadKey();
//}
//static void BigDataOperation(in int[] arr, ref int data)
//{
//    data = 8;
//    arr[0] = 4;
//}

//static void Test(ref int num)
//{

//}

//static void GetName(out string name)//метод для ввода нового имени
//{
//    Console.WriteLine("Введите имя :");
//    name = Console.ReadLine();
//}
//static void ChangeAge(int age)//метод для ввода нового возраста
//{
//    Console.WriteLine("Введите новый возраст :");
//    age = Convert.ToInt32(Console.ReadLine());
//}
//---------------------------- КОНЕЦ 5.3.7 -------------------------------------




//----------------------------- НАЧАЛО 5.3.8--------------------------------------
//public static void Main(string[] args)
//{
//    var num = 0;
//    var Array = GetArrayFromConsole(ref num);

//}
//static int[] GetArrayFromConsole(ref int num = 6)
//{
//    var result = new int[num];

//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
//        result[i] = int.Parse(Console.ReadLine());

//    }


//    return result;
//}

//------------------------------ КОНЕЦ ------------------------------------------

