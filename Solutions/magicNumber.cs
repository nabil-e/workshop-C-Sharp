﻿using System;

namespace Workshop {
    class Program {
        private static Random random = new Random();

        static void Main(string[] args) {
            //variables
            bool play = true, victory = false;
            int magicNbr, nbrOfTry, choice;

            Console.WriteLine("Welcome to this game of the magic number.");
            //game
            do {
                Console.WriteLine("I choosed a number between 1 and 100.");
                Console.WriteLine("Let's see if you can find it.");
                magicNbr = random.Next(1, 101);
                nbrOfTry = 0;

                //prevent error if the user is trying to enter a string instead of a number
                try {
                    //while the user is still trying to find the number
                    do {
                        choice = Convert.ToInt32(Console.ReadLine());
                        nbrOfTry++;

                        if (choice < magicNbr) {
                            Console.WriteLine("My number is greater than yours.");
                        }
                        else if (choice > magicNbr) {
                            Console.WriteLine("My number is lower than yours.");
                        }
                    } while (choice != magicNbr);
                    //user found the magic number
                    victory = true;
                }
                //user tried to enter a string instead of numbers
                catch (Exception ex) {
                    Console.WriteLine("Not a valid number\nYou tried something different, the game will restart.");
                }
                if (victory) {
                    Console.WriteLine("Congratulations! You found the number in {0} rounds.", nbrOfTry);
                    Console.WriteLine("Do you want to continue playing? Y/N.");
                    String endChoice = Console.ReadLine();

                    while (endChoice != "Y" && endChoice != "y" && endChoice == "N" && endChoice == "n") {
                        Console.WriteLine("Not a valid choice. Press Y or N");
                        Console.WriteLine("Do you want to continue playing? Y/N.");
                        endChoice = Console.ReadLine();
                    }
                    if (endChoice == "N" || endChoice == "n") {
                        play = false;
                    }
                }
            } while (play); //end of game
            Console.WriteLine("Goodbye, thanks for playing.");
        }

    }
}