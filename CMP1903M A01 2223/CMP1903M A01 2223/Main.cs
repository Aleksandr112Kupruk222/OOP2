using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    sealed class Main:Validation
    {

        // Main method: Entry point of the program, calls the RunGame method
        double UserInput;
        int tries;
        public Main()
        {
            
            RunGame();
        }

        // RunGame method: Runs the game, displays the menu, handles user's input and runs the UserAnswear method
        void RunGame()
        {
            // Declare variables
            int choice;
            double res = 0;
            Pack pack = new Pack();
            Pack pack5 = new Bodmas5();
            Stopwatch stopwatch = new Stopwatch();

            //Code to clear the console
            Console.Clear();
            Console.WriteLine("Welcome");
            // Display menu and get user's choice
            choice = IntValidation("1.Deal 3 cards.\n2.Deal 5 cards.\n3.Instructions.\n4.Quit", 0, 4);

            // Deal 3 or 5 cards and get the result
            if (choice == 1)
            {
                res = pack.GetEquation();
            }
            if (choice == 2)
            {
                res = pack5.GetEquation();
            }

            // Display instructions and get user's choice
            if (choice == 3)
            {

                Console.WriteLine("Welcome to the Math Tutor!\n" +
                                 "At the start of the game, you will be presented with a selection menu offering options such as reading instructions, dealing 3 or 5 cards, or quitting the game.\n" +
                                 "The cards you receive will determine the equation you will be given to solve.\n" +
                                 "Remember, if you think the answer to a calculation will have decimal places, please round it up to 2 decimal places.\n" +
                                 "Your statistics, including the number of attempts and time it took to solve the equation, will be shown to you after you answer correctly.");
                int choice2 = IntValidation("1.Go back.\n2.Quit.", 0, 2);
                if (choice2 == 1)
                {
                    RunGame();
                }
                if (choice2 == 2)
                {
                    Environment.Exit(0);
                }
            }

            // Quit the game
            if (choice == 4)
            {
                Environment.Exit(0);
            }

            // Start stopwatch and call UserAnswear method
            tries = 1;
            stopwatch.Start();
            UserAnswear(res, stopwatch, tries, choice, pack, pack5);
        }

        // UserAnswear method: Handles user's input and checks if the answer is correct, records the result and runs PlayAgain method
        void UserAnswear(double res, Stopwatch stopwatch, int tries, int choice, Pack pack, Pack pack5)
        {
            while (true)
            {
                UserInput = DoubleValidation("Give your answear", -100000000, 1000000000);
                if (UserInput == res)
                {
                    Console.WriteLine("Answear correct");
                    switch (choice)
                    {
                        case 1:
                            pack.Record(stopwatch.Elapsed.ToString(@"ss\.ff"), tries, res); break;
                        case 2:
                            pack5.Record(stopwatch.Elapsed.ToString(@"ss\.ff"), tries, res); break;
                    }
                    PlayAgain();
                    break;
                }
                else
                {
                    tries++;
                    Console.WriteLine("Incorrect");
                }
            }
        }

        // PlayAgain method: Asks the user if they want to play again, restarts the game or exits the program
        void PlayAgain()
        {
            UserInput = IntValidation("Play Again\n1.Yes\n2.No", 0, 2);
            if (UserInput == 1)
            {
                RunGame();
            }
            else if (UserInput == 2)
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
            }
        }


    }
}
