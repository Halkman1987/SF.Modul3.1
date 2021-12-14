
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        GetArrayFromConsole();
        SortArray();
    }
    
    
    //Вводим элементы массива положительные и отрицательные --------------------
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }

    //Сортируем массив который ввели ------------------------------------------
    static int[] SortArray(int[] results)
    {
        int tmp = 0;
        for (int i = 0; i < results.Length; i++)
            for (int j = 0 + 1; j < results.Length; j++)
                if (results[i] > results[j])
                {
                    tmp = results[i];
                    results[i] = results[j];
                    results[j] = tmp;
                }
        return results;
    }
}

    