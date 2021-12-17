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