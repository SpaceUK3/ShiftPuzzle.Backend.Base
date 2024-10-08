using System;

namespace sfg
{
    class Game
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 15);
            System.Console.WriteLine("Я загадал число от 1 до 15, попробуй его угадать :)");
            int NumOfUser = Convert.ToInt32(Console.ReadLine());
            while (NumOfUser != random) 
            {
                if (NumOfUser > random)
                {
                    System.Console.WriteLine("Возьми меньше)");
                    NumOfUser = Convert.ToInt32(Console.ReadLine());
                }
                else{
                    System.Console.WriteLine("Возьми больше)");
                    NumOfUser = Convert.ToInt32(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Красава");
        }
    }
}
