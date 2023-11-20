using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice..");

                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins");
                }
                else if (enemyRandomNum > enemyPoints)
                {
                    enemyPoints++;
                    Console.WriteLine("AI won");
                }
                else
                {
                    Console.WriteLine("It's a tie:(");
                }
                Console.WriteLine("Score is now - Player: " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }

            if(playerPoints > enemyPoints )
            {
                Console.WriteLine("You won the game lol");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("loser!");
            }
            else
            {
                Console.WriteLine("draw ur both losers");
            }


            Console.ReadKey();
        }
    }
}
