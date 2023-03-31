using System;

namespace songsesoon_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("반복 횟수를 입력하세요: ");
                int ioop_input = int.Parse(Console.ReadLine());

                if (ioop_input <= 0)
                {
                    Console.WriteLine("0보다 작거나 같은 수를 입력할 수는 없습니다.\n");
                    continue;
                }
                else
                {
                    for (int i = 0; i < ioop_input; ++i)
                    {
                        for (int j = 0; j <= i; ++j)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}