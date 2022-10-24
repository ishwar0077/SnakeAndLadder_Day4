using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class UseCase2
    {
        public static void rollDie()
        {
            //variables
            int StartPosition = 0;
            int EndPosition = 100;
            int rollDie;
            Random random = new Random();
            rollDie = random.Next(1, 7);
            Console.WriteLine("number on die : " + rollDie);

        }
    }
}