using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

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
                
               
                int condition = Action();
                Console.WriteLine("Action value: " + condition);
                switch (condition)
                {
                    case 0: //No Play
                         break;
                    case 1: // 1 = ladder
                        int val = score + dicevalue;
                        if (val <= 100)
                        {
                            score = val;
                        }
                        break;
                        case 2: // 2 = Snake
                        int val2 = score - dicevalue;
                        score = val2 >= 0 ? val2 : 0;
                        break;

                }
            }
            Console.WriteLine("Dice Role: " + count);
            Console.WriteLine("Score: " + score);
            }
           int Action()
        {
            Random random = new Random();
            int action = random.Next(0,3);
            return action;
            
        }
            int RollDice()
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("Random value: " + dice);
                return dice;
            }
       
    }
}
