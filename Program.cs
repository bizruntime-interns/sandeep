using System;

namespace switch_statements
{
    class MyApplication
    {
        static void Main(string[] args)
        {
            int day =0;
            switch(day)
            {
                case 0:
                    Console.WriteLine("non of the above");
                break;

            case 1:
                  Console.WriteLine("monday");
            break;

                  case 2:
                       Console.WriteLine("tuesday");
                  break;

             case 3:
                  Console.WriteLine("wednesday");
             break;

                  case 4:
                       Console.WriteLine("thursday");
                  break;

            case 5:
                 Console.WriteLine("friday");
            break;

                  case 6:
                        Console.WriteLine("saturday");
                  break;

             case 7:
                    Console.WriteLine("sunday");
             break;

            }
        }
    }
}
