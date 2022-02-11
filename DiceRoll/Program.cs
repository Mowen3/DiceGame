using System;

namespace DiceRoll
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int playerRandomNum;
            int playerRandomNum2;

            Random random = new Random();

            while (true)
            {

                Console.WriteLine("Hello! Welcome to the table. I seggest you get out now before you develope a gambling problem. However, if you would like to continue, read on.");
                Console.WriteLine("Please enter the number of sides for your pair of dice");
                var sides = (Console.ReadLine());
                Console.WriteLine("Now go ahead and roll your dice by typing 'Roll'");
                var roll = (Console.ReadLine());
                playerRandomNum = random.Next(1, 7);
                playerRandomNum2 = random.Next(1, 7);

                int total = (playerRandomNum + playerRandomNum2);

                Console.WriteLine("You rolled a " + (playerRandomNum) + " and a " + (playerRandomNum2) + " for a total of " + (total));

                if (playerRandomNum == 1 && playerRandomNum2 == 1)
                        {
                    Console.WriteLine("Snake Eyes!");
                }

                else if (total == 7 || total ==11)
                {
                    Console.WriteLine("Nice Roll! You win!");
                }

                else if (playerRandomNum == 6 && playerRandomNum2 == 6)
                {
                    Console.WriteLine("Box Cars!");
                }

                else if (total == 2 || total == 3 || total == 12)
                {
                    Console.WriteLine("Craps!!!");
                }

                Console.WriteLine("Would you like to roll again?");
                var yes = (Console.ReadLine());

                break;
            }

           
            
        }
    }
}
