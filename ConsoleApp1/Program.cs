using System;

class MainClass
   {
    static void Main(string[] args);
    {
     GetArrayFromConsole();
    }


       static int[] GetArrayFromConsole();
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        int tmp = 0;
        for (int j = 0;j < result.Length; j++)
        {
            for (int k =0 + 1; k < result.Length; k++)
            {
                if (result[j] > result[k])
                {
                    tmp = result[j];
                    result[j] = result[k];
                    result[k] = tmp;

                }
                Console.WriteLine();
            }
            
        }
        foreach (var res in result)
        {
            Console.Write(res);
        }
        
    }
}
}