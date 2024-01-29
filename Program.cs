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
            int[] playerPositions = { 0, 0 }; // Store positions for two players
            int currentPlayer = 0; // 0 for Player 1, 1 for Player 2
            int count = 0;

            Console.WriteLine("Welcome to Snake and Ladder Game!");

            while (playerPositions[currentPlayer] < 100)
            {
                int diceRoll = random.Next(1, 7);
                count++;
                Console.WriteLine($"Player {currentPlayer + 1}, the dice roll value is {diceRoll}");

                int scenarioResult = random.Next(0, 3);

                switch (scenarioResult)
                {
                    case 0:
                        Console.WriteLine($"No Play, Player {currentPlayer + 1} is at position {playerPositions[currentPlayer]}");
                        break;
                    case 1:
                        int newPosition = playerPositions[currentPlayer] + diceRoll;
                        Console.WriteLine($"Player {currentPlayer + 1} is at position {playerPositions[currentPlayer]}");
                        if (newPosition > 100)
                        {
                            continue;
                        }
                        else
                        {
                            playerPositions[currentPlayer] = newPosition;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Player {currentPlayer + 1} is at position {playerPositions[currentPlayer]}");
                        if (playerPositions[currentPlayer] < 0)
                        {
                            playerPositions[currentPlayer] = 0;
                        }
                        playerPositions[currentPlayer] -= diceRoll;
                        break;
                }

                Console.WriteLine($"Player 1 is at position {playerPositions[0]} and Player 2 is at position {playerPositions[1]}");
                currentPlayer = 1 - currentPlayer; // Switch to the other player
            }

            Console.WriteLine($"{count} number of times the dice was rolled");
            Console.WriteLine($"Player {currentPlayer + 1} wins! They have reached the position 100!");
            Console.ReadLine();
        }
    }
}

