using SnakeLadderProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the snake and ladder program!");
            int PlayerPosition = 0;
            Console.WriteLine("singleplayer position is now starting as zero");
            int playerNumberOfRolls = 0;
            Random random = new Random();

            int playerDiceRoll = random.Next(1, 7);
            playerNumberOfRolls++;

            Console.WriteLine("the player rolled a dice is   " + playerDiceRoll);
        }
    }
}