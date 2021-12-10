using System;

class Mainclass
{

    public static void Main(string[] args)
    {
        /*  // Очередное задание в модуле
          {
              var myapples = 5;
              var hisapples = 6;
              var hispeach = 5;

              var results = (myapples != hispeach) & (myapples < hisapples);
              Console.WriteLine(results);
              Console.ReadKey();
          }

          // переменные логические или |  

          {
              int a;
              int b;
              double x;
              double y;
              bool c = (a < b) | (x > y);
          }

          {
              var a = 6;
              var b = 7;
              var c = (a > b) ^ (a != b);
          }
          {
              var inv = true;
              var result = !inv;
              Console.WriteLine(result);
              Console.ReadKey();
          }


          // Условия If to else... погнали
          {
              var a = 6;
              var b = 7;

              if (a == b)
              {
                  Console.WriteLine("Условие истинно");
              }
              else if (b < 10)
              {
                  Console.WriteLine("Значение b = {0} меньше 10", b);

              }
              else
              {
                  Console.WriteLine("Значение b= {0} больше 10", b);
              }

              //Заменяем if\else 

              {
                  Console.WriteLine("Напишите свой любимый цвет на англ яз с маленькой буквы");

                  var color = Console.ReadLine();

                  if (color == "red")
                  {
                      Console.BackgroundColor = ConsoleColor.Red;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Ваш цвет red");
                  }

                  else if (color == "green")
                  {
                      Console.BackgroundColor = ConsoleColor.Green;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Ваш цвет green");
                  }
                  else
                  {
                      Console.BackgroundColor = ConsoleColor.Cyan;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Ваш цвет cyan");
                  }


              }


          }


          //   Switch.........в действии )

          {
              Console.WriteLine("Напишите свой любимый цвет на англ яз с маленькой буквы");

              var color = Console.ReadLine();

              switch (color)
              {
                  case "red":
                      Console.BackgroundColor = ConsoleColor.Red;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Ваш цвет red ");
                      break;

                  case "cyan":
                      Console.BackgroundColor = ConsoleColor.Cyan;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Ваш цвет cyan");
                      break;

                  case "green":
                      Console.BackgroundColor = ConsoleColor.Green;
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.WriteLine("Ваш цвет green ");
                      break;

                  default:
                      Console.BackgroundColor = ConsoleColor.Yellow;
                      Console.ForegroundColor = ConsoleColor.Red;

                      Console.WriteLine("Ваш цвет yellow");
                      break;



              }
          }



          //Цветовые перечисления

          {
              for (int i = 1; i < 5; i++)
              {
                  Console.WriteLine("Iteration {0}", i);
                  switch (Console.ReadLine())
                  {
                      case "red":
                          Console.BackgroundColor = ConsoleColor.Red;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет красный");
                          break;

                      case "green":
                          Console.BackgroundColor = ConsoleColor.Green;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет зеленый");
                          break;

                      case "cyan":
                          Console.BackgroundColor = ConsoleColor.Cyan;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет синий");
                          break;

                      default:
                          Console.BackgroundColor = ConsoleColor.Yellow;

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет желтый");
                          break;


                  }
              }
          }
        */



        //Бесконечный цикл

        /*  {
              Console.WriteLine("Цикл While");
              int k = 0;

              while (k < 3)
              {
                  Console.WriteLine("Напишите любой цвет");
                  Console.WriteLine(k);

                  var text = Console.ReadLine();


                  //перенесли вариацию if после switch 

                  *//* if (text == "stop")
                  {
                      Console.WriteLine("Цикл остановлен");
                      break;
                  }*//*
                  switch (Console.ReadLine())
                  {
                      case "red":
                          Console.BackgroundColor = ConsoleColor.Red;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет красный");
                          break;

                      case "green":
                          Console.BackgroundColor = ConsoleColor.Green;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет зеленый");
                          break;

                      case "cyan":
                          Console.BackgroundColor = ConsoleColor.Cyan;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет синий");
                          break;

                      default:
                          Console.BackgroundColor = ConsoleColor.Yellow;

                          Console.ForegroundColor = ConsoleColor.Red;

                          Console.WriteLine("Ваш цвет желтый");
                          break;

                  }
                  if (text == "stop")
                  {
                      Console.WriteLine("Цикл остановлен");
                      break;
                  }
                  k++;
              }
          }*/


        // самостоятельный цикл do while
        /*  {
              Console.WriteLine("Цикл do while");
              int t = 0;

              do
              {
                  Console.WriteLine(t);

                  Console.WriteLine("Напишите цвет");
                  switch (Console.ReadLine())
                  {
                      case "red":
                          Console.BackgroundColor = ConsoleColor.Red;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет красный");
                          break;

                      case "green":
                          Console.BackgroundColor = ConsoleColor.Green;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет зеленый");
                          break;

                      case "cyan":
                          Console.BackgroundColor = ConsoleColor.Cyan;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет синий");
                          break;

                      default:
                          Console.BackgroundColor = ConsoleColor.Yellow;

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет желтый");
                          break;
                  }
                  t++;
              } while (t < 0);



          }
  */
        // Вносим режим continue
        /*  {
              Console.WriteLine("Цикл While");
              int k = 0;

              while (k < 5)
              {
                  Console.WriteLine("Напишите любой цвет");
                  Console.WriteLine(k);
                  k++;

                  switch (Console.ReadLine())
                  {
                      case "red":
                          Console.BackgroundColor = ConsoleColor.Red;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет красный");
                          break;

                      case "green":
                          Console.BackgroundColor = ConsoleColor.Green;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет зеленый");
                          break;

                      case "cyan":
                          Console.BackgroundColor = ConsoleColor.Cyan;
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет синий");
                          break;

                      default:
                          Console.BackgroundColor = ConsoleColor.Yellow;

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.WriteLine("Ваш цвет желтый");
                          break;
                         // continue;

                  }

              }   





          }*/
        /* 
         string[] favcolors = new string[3];

         for (int i = 0; i < favcolors.Length; i++)
         {
             Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
             favcolors[i] = Console.ReadLine();
         }

         foreach (var color in favcolors)
         {
             switch (color)
             {
                 case "red":
                     Console.BackgroundColor = ConsoleColor.Red;
                     Console.ForegroundColor = ConsoleColor.Black;

                     Console.WriteLine("Ваш цвет красный");
                     break;

                 case "green":
                     Console.BackgroundColor = ConsoleColor.Green;
                     Console.ForegroundColor = ConsoleColor.Black;

                     Console.WriteLine("Ваш цвет зеленый");
                     break;

                 case "cyan":
                     Console.BackgroundColor = ConsoleColor.Cyan;
                     Console.ForegroundColor = ConsoleColor.Black;

                     Console.WriteLine("Ваш цвет синий");
                     break;

                 default:
                     Console.BackgroundColor = ConsoleColor.Yellow;

                     Console.ForegroundColor = ConsoleColor.Black;

                     Console.WriteLine("Ваш цвет желтый");
                     break;
             }


         }
 */
        /* {
             Console.WriteLine("Напишите свое имя:");
             var name = Console.ReadLine();

             Console.Write("Выведем ваши имя по буквам в обратном порядке:");

             for (var i = name.Length - 1; i >= 0; i--)
             {
                 Console.Write(name[i] + " ");
             }
             Console.ReadKey();
         }*/
        /*var arr = new int[] { 5, 4, 1, 9, 2, 8 };
        var l = arr.Length-1;
        //for (var i = 0; i <=l ; i++)
        Console.WriteLine(arr[0]);
        //arr[1]
        Console.ReadKey();*/


        // Выводим колличество строк и колонок массива
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                Console.Write(array[i, k] + " ");

            Console.WriteLine();
        }


        // Перебор начинается по столбцам
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };



        for (int i = 0; i < array.GetUpperBound(1) + 1; i++)

        {
            for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                Console.Write(array[k, i] + " ");
            Console.WriteLine();
        }

















        // Сортировка массива по возрастанию

        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int min;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    min = arr[i];
                    arr[i] = arr[j];
                    arr[j] = min;
                }
            }
        }
        foreach (var i in arr)
        {
            Console.Write(i);
        }



        // Задание найти сумму всех элементов

        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int su = 0;
        foreach (var s in arr)
        {
            su += s ;
        }
        Console.WriteLine(su);


       










        //Console.Write("Количество строк: ");
        //Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

        //Console.Write("Количество колонок: ");
        //Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

        /*foreach (int i in array)
        {
            Console.Write(i + "");
        }*/



    }
}