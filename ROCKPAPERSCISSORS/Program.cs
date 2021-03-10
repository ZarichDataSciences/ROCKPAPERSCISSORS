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


            Player myObj = new Player();
            myObj.Name = Console.ReadLine();
            //Console.WriteLine(myObj.Name);

            //Console.ReadLine();
            //Player = Console.ReadLine();



            Random rnd = new Random();

            Player player1 = new Player();
            randomInt = rnd.Next(1, 4);

            int scorePlayer = 0;
            int scoreCPU = 0;


            while (scorePlayer <= 3 || scoreCPU <= 3) { 
                


            Console.WriteLine("Choose between ROCK, PAPER and SCISSORS! " + myObj.Name);
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

                switch (randomInt)
                {


                    case 1:
                        //inputCPU = "ROCK";
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
                        //inputCPU = "PAPER";
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
                        //inputCPU = "SCISSORS";
                        Console.WriteLine("cThe computer chose SCISSORS");
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
                        //Console.ReadKey();
                }


            }  //(scoreCPU > 5);



            if (scoreCPU == 3)
            {
                Console.WriteLine("Congrats! You LOST" + myObj.Name + "The CPU beat U!");
                Console.ReadKey();
            }
            else if (scorePlayer == 3)
            {
                Console.WriteLine("poop");
                Console.ReadKey();
            }

            Console.ReadLine();
        }

    }
}

