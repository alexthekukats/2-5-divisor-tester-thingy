using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_oszthatóság_és_statisztika
{
    class Program
    {
        static int ertek = 1;
        static int kett = 0;
        static int ot = 0;
        static int mindkett = 0;
        static int egyikse = 0;
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Kérem írjon be 10 és 100 közötti számokat!");

            adj();

            
        }
        static void adj()
        {
            try
            {
                ertek = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            if (ertek == 0)
            {
                statistic();
            }
            else
            {

                if (ertek > 100 || ertek < 10)
                {
                    Console.WriteLine("Ön túl nagy vagy túl kicsi számot írt be!");
                    adj();
                }
                else
                {

                    if (ertek % 2 == 0)
                    {
                        kett++;
                        if (ertek % 5 == 0)
                        {
                            kett--;
                            mindkett++;
                        }
                    }
                    else
                    {
                        if (ertek % 5 == 0)
                        {
                            ot++;
                        }
                        else
                        { egyikse++; }
                    }




                    if (ertek % 5 == 0)
                    {
                        ot++;
                        if (ertek % 2 == 0)
                        {
                            ot--;
                            mindkett++;
                        }
                    }
                    else
                    {
                        if (ertek % 2 == 0)
                        {
                            kett++;
                        }
                        else
                        { egyikse++; }
                    }

                }
                adj();

            }
        }
        static void statistic()
        {
            Console.WriteLine(" ");
            Console.WriteLine("{0} darab kettővel, {1} darab öttel, {2} darab mindkettővel és {3} darab egyikkel se osztható számot vizsgáltunk.", kett, ot, mindkett, egyikse);

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}
