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
            //Console.WriteLine("number on die : " + rollDie);

            while (nextPosition < EndPosition)
            {

                nextPosition += random.Next(1, 7);
                if (nextPosition > 100)
                {
                    nextPosition -= rollDie;
                    Console.WriteLine(" player stayed on same position : " + nextPosition);
                }
                else if (nextPosition == EndPosition)
                {
                    Console.WriteLine("Next position is : " + nextPosition);
                    Console.WriteLine("player position : " + nextPosition + " Player Won");
                    break;
                }
                else
                {
                    int checkOpt = random.Next(0, 2);
                    switch (checkOpt)
                    {
                        case 1:
                            Console.WriteLine("Ladder");
                            nextPosition += rollDie;
                            if (nextPosition > 100)
                            {
                                nextPosition -= rollDie;
                                Console.WriteLine(" player stayed on same position : " + nextPosition);
                            }
                            break;
                        case 0:
                            Console.WriteLine("Snake");
                            nextPosition -= rollDie;
                            break;
                        default:
                            Console.WriteLine("No Play");
                            break;


                    }

                }

                Console.WriteLine("Next position is : " + nextPosition);
            }
        }
    }
}