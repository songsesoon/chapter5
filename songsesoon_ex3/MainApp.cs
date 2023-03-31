using System;

namespace songsesoon_ex3
{
    class MainApp
    {
        static void Main()
        {
            int external_loop = 1;
            int? internal_loop = null;

            while (external_loop <= 5)
            {
                internal_loop = 0;

                while (true)
                {
                    if (internal_loop == external_loop)
                    {
                        break;
                    }
                    Console.WriteLine("*");
                    internal_loop++;
                }
                Console.WriteLine();
                external_loop++;
            }
        }
    }
}