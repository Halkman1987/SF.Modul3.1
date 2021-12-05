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
        {
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
                        continue;
     
                }
                
            }   
            




        }



    }
}