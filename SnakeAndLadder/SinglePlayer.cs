﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SinglePlayer
    {
        public static void SinglePlayerGame()
        {
            Console.WriteLine();
            Console.WriteLine("The Game Begins!");
            Console.WriteLine("Player Position : 0");

            int startPosiion = 0;

            Random random = new Random();
            int dice = random.Next(1, 7);

            Console.WriteLine();
            Console.WriteLine("Dice has been Rolled: " + dice);

        }
    }
}
