using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Project___Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What grade do you expect to get in ISM4300?");
            try
            {
                string input = null;
                input = Console.ReadLine();
                int inputvalue = int.Parse(input);
                {
                    if (inputvalue >= 0 && inputvalue < 60)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an F");
                    }
                    else if (inputvalue >= 60 && inputvalue <= 62)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an D-");
                    }
                    else if (inputvalue >= 62 && inputvalue <= 67)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an D");
                    }
                    else if (inputvalue >= 68 && inputvalue <= 69)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an D+");
                    }
                    else if (inputvalue >= 70 && inputvalue <= 71)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an C-");
                    }
                    else if (inputvalue >= 72 && inputvalue <= 77)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an C");
                    }
                    else if (inputvalue >= 78 && inputvalue <= 79)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an C+");
                    }
                    else if (inputvalue >= 80 && inputvalue <= 81)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an B-");
                    }
                    else if (inputvalue >= 82 && inputvalue <= 87)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an B");
                    }
                    else if (inputvalue >= 88 && inputvalue <= 89)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an B+");
                    }
                    else if (inputvalue >= 90 && inputvalue <= 91)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an A-");
                    }
                    else if (inputvalue >= 92 && inputvalue <= 97)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an A");
                    }
                    else if (inputvalue >= 98 && inputvalue < 100)
                    {
                        Console.WriteLine("Your grade in ISM4300 will be an A+");
                    }

                }
            }

            catch
            {
                Console.WriteLine("Please enter a interger value between 0-100");
            }

        
            
        }
    }
}
