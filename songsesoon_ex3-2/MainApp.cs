using System;

namespace songsesoon_ex3
{
    class MainApp
    {
        static void Main()
        {
            int external_loop = 1;
            int? internal_loop = null;

            do 
            {
                internal_loop = 0;

                do 
                {
                    if (internal_loop == 6 - external_loop)
                    {
                        break;
                    }
                    Console.WriteLine("*");
                    internal_loop++;
                } while (true) ;
                Console.WriteLine();
                external_loop++;
            } while (external_loop <= 5) ;
        }
    }
}