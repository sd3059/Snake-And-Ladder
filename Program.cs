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

            }
        }
    }
}
