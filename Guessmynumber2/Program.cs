using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessmynumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 and 10");
            Guesser();
            Console.WriteLine("Try again? y/n");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.WriteLine("Enter a number between 0 and 10");
                Guesser();
            }
            
            else
            {
                Console.WriteLine("Bye!");

            }

        }
        public static void Guesser()
        {
           
            Random rand = new Random();
            int guess = rand.Next(0, 10);
            int playernumber = 0;
            

            
               
                for (int i = 1; i < 5; i++)
                {

                    
                    playernumber = Convert.ToInt32(Console.ReadLine());

                    if (guess != playernumber)
                    {
                        Console.WriteLine("try again");
                    }

                    else
                    {

                        Console.WriteLine("Congratulations! Number was.... {0}  !!", guess);
                        i = 5;
                    }
                    
                    if (i == 4)
                    {

                        Console.WriteLine("You lose.You have reached the maximum number of attempts (4) ");

                    i = 5;
                        


                    }



                }

          


                
                //ConsoleKeyInfo cki;
                //while (true)
                //{
                //    cki = Console.ReadKey();
                //    if (cki.Key == ConsoleKey.Spacebar)
                //        break;

                //}
            
            
        }
         
            
        }

        
    }

