using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public static void rollDie()
        {
            //variables
            int StartPosition = 0;
            int EndPosition = 100;
            int nextPosition = 0;
            Random random = new Random();
            int rollDie = random.Next(1, 7);
            Console.WriteLine("number on die : " + rollDie);
            nextPosition += rollDie;

            int checkOpt = random.Next(0, 2);
            switch (checkOpt)
            {
                case 1:
                    Console.WriteLine("Ladder");
                    nextPosition += rollDie;
                    break;
                case 0:
                    Console.WriteLine("Snake");
                    nextPosition -= rollDie;
                    break;
                default:
                    Console.WriteLine("No Play");
                    break;

            }
            Console.WriteLine("Next position is : " + nextPosition);
        }
    }
}