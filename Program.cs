using System;

namespace Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Elements!");
            Random random = new Random();
            bool goAgain = true;
            String player;
            String computer;
            String answer;

            while (goAgain)
            {
                player = "";
                computer = "";
                while (player != "WATER" && player != "FIRE" && player != "EARTH")
                {
                    Console.WriteLine("Enter WATER, FIRE, or EARTH: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                int randomNum = random.Next(1, 4);
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "WATER";
                        break;
                    case 2:
                        computer = "FIRE";
                        break;
                    case 3:
                        computer = "EARTH";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);


                switch (player)
                {
                    case "WATER":
                        if (computer == "WATER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "FIRE")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "FIRE":
                        if (computer == "WATER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "FIRE")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "EARTH":
                        if (computer == "WATER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "FIRE")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    goAgain = true;
                }
                else
                {
                    goAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}