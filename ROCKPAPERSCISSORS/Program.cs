using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCPU;
            string inputPlayer;
            int randomInt;

            Console.WriteLine("Ready to play Rock, Paper, Scissors?");
            Console.WriteLine("Enter your name...");


            Player playerName = new Player();
            playerName.Name = Console.ReadLine();

            if (string.IsNullOrEmpty(playerName.Name))
            {
                Console.WriteLine("Name can't be empty! Input your name once more...");
                playerName.Name = Console.ReadLine();
            }


            var seed = (int)DateTime.Now.Ticks;
            var random = new Random(seed);


            //Player player1 = new Player();
            //Now that we have the player's name the game begins withing a WHILE loop

            int scorePlayer = 0;
            int scoreCPU = 0;


            while (scorePlayer < 3 && scoreCPU < 3)
            {

                randomInt = random.Next(1, 4);

                Console.WriteLine("Type ROCK, PAPER or SCISSORS " + playerName.Name + "!");

                inputPlayer = Console.ReadLine();

                inputPlayer = inputPlayer.ToUpper();

                if (string.IsNullOrEmpty(inputPlayer))
                {
                    Console.WriteLine("You can't just press Enter. Type Rock, paper or scissors...");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                }
               
                /*else if (inputPlayer != "ROCK")
                {
                    Console.WriteLine("You must type rock, paper or scissors. Try again!");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                }
                else if (inputPlayer != "PAPER")
                {
                    Console.WriteLine("You must type rock, paper or scissors. Try again!");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                }
                else if (inputPlayer != "SCISSORS")
                {
                    Console.WriteLine("You must type rock, paper or scissors. Try again!");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                }
                */
                switch (randomInt)
                {


                    case 1:

                        Console.WriteLine("The computer chose ROCK");

                        if (inputPlayer == "ROCK")
                        {

                            Console.WriteLine("DRAW! \n\n");
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("PLAYER WINS!!\n\n");

                            scorePlayer++;
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("CPU WINS! \n\n");

                            scoreCPU++;
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }                        
                                                
                        break;

                    case 2:

                        Console.WriteLine("The computer chose PAPER");
                        if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("DRAW! \n\n");
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlayer++;
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("CPU WINS! \n\n");
                            scoreCPU++;
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }
                        break;

                    case 3:

                        Console.WriteLine("The computer chose SCISSORS");
                        if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("DRAW! \n\n");
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }
                        else if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("PLAYER WINS!!\n\n");
                            scorePlayer++;
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("CPU WINS! \n\n");
                            scoreCPU++;
                            Console.WriteLine("Player Score " + scorePlayer);
                            Console.WriteLine("Computer Score " + scoreCPU);
                        }
                        break;

                    default:
                        Console.WriteLine("Misspelled entry? Please type rock, paper or scissors again.");
                        break;
                        Console.ReadKey();

                }


            }



            if (scoreCPU == 3)
            {
                Console.WriteLine("Congrats! You LOST " + playerName.Name + ", The CPU beat U!");

            }
            else if (scorePlayer == 3)
            {
                Console.WriteLine("Congrats " + playerName.Name + ", you beat the Computer!");

            }

            Console.WriteLine("Thanks for playing! Press any key to quit");
            Console.ReadKey();

        }


    }
}

