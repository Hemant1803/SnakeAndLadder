using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Game
    {
         public void StartGame()
        {
            Console.WriteLine("Start Snake And Ladders");
            int score = 0;
            int count = 0;
            while (score < 100)
            {
                int dicevalue = RollDice();
                count++;
                int num = score + dicevalue;
                if (num <= 100)
                {
                    score = num;
                }
            }         
                           
              
            Console.WriteLine("Dice Role" + count);
            Console.WriteLine("Score" + score);
            
           

        }
            int RollDice()

            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("Random value :"+dice);

                return dice;
            }
       
    }
}
