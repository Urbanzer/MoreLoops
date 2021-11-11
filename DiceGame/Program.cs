using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mangus kaks mangijat - cpu ja user
            //molemad viskavad taringut
            //programm kontrollib, kumb mangija viskas rohkem
            //taringuid visatakse 3 korda
            //programm kuulutab voitja

            Random rnd = new Random();

            //arvuti vise
            
            //kasutaja vise
            

            int cpuScore = 0;
            int userScore = 0;
            



            for (int i = 0; i < 3; i++)
            {
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine("Sisesta VISKA veeretamiseks:");
                string userInput = Console.ReadLine();
                if (userInput == "VISKA")
                {
                    if (cpuRandom < userRandom)
                    {
                        Console.WriteLine("Sina voitsid vooru");
                        userScore += userRandom;
                    }
                    else if (cpuRandom > userRandom)
                    {
                        Console.WriteLine("Arvuti voitis vooru");
                        cpuScore += cpuRandom;
                    }
                    else if (cpuRandom == userRandom)
                    {
                        Console.WriteLine("Jaite arvutiga viiki selles voorus");
                        cpuScore += cpuRandom;
                        userScore += userRandom;
                    }

                    Console.WriteLine($"Arvuti skoor: {cpuScore}");
                    Console.WriteLine($"Sinu skoor: {userScore}");
                }
                else if (userInput != "VISKA")
                {
                    Console.WriteLine("Vale kask. Sisesta VISKA veeretamiseks:");
                }
            }   if (userScore > cpuScore)
            {
                Console.WriteLine("Sina voitsid!");
            }
            else if (userScore < cpuScore)
            {
                Console.WriteLine("Arvuti voitis!");
            }
            else if (userScore == cpuScore)
            {
                Console.WriteLine("Jaite arvutiga viiki");
            }
            Console.WriteLine("Kena paeva!");
        }
    
    } 
}

