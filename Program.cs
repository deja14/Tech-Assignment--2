using System;

namespace Tech_Assignment__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Grade Do You Expect To Receive in ISM4300?");

            try
            {
                string input = Console.ReadLine();
                int Grade = int.Parse(input);

                if (Grade < 60)
                {
                    Console.WriteLine ( "Your grade will be a F");
                }
                else if (Grade < 70)
                {
                    Console.WriteLine ("Your grade will be a D");
                }
                else if (Grade < 80)
                {
                    Console.WriteLine ("Your grade will be a C");
                }
                else if (Grade < 90)
                {
                    Console.WriteLine ("Your grade will be a B");
                }
                else
                {
                    Console.WriteLine ("Your grade will be a A");
                }

            }
            catch
            {
                Console.WriteLine("Press Any Key To Exit !");
            }


        }
    }
}
