using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int StartPlayer = 0;
            int count = 0;
            Console.WriteLine("Welcome to Snake and Ladder Game!");






            while (StartPlayer < 100)
            {



                int DiceRoll = random.Next(1, 7);
                count++;
                Console.WriteLine($"The DiceRoll value is {DiceRoll}");



                int ScenarioResult = random.Next(0, 3);

                switch (ScenarioResult)
                {
                    case 0:
                        Console.WriteLine($"No Play, You are at the position {StartPlayer}");
                        break;
                    case 1:
                        int newposition = StartPlayer + DiceRoll;
                        Console.WriteLine($"You are at the position {StartPlayer}");
                        if (newposition > 100)
                        {
                            continue;
                        }
                        else
                        {
                            StartPlayer = newposition;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"You are at the position {StartPlayer}");
                        if (StartPlayer < 0)
                        {
                            StartPlayer = 0;
                        }
                        StartPlayer -= DiceRoll;
                        break;

                }



            }
            Console.WriteLine($"{count} number of times the dice was rolled");
            Console.WriteLine("Congratulations, you have reached the position 100!");
            Console.ReadLine();
        }
    }
}
