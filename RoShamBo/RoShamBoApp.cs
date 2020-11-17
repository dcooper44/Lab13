using System;

namespace RoShamBo
{
    public class RoShamBoApp
    {

        public bool ValidateTeamName(string userInput)
        {
            if(userInput.Equals("jets", StringComparison.OrdinalIgnoreCase) || userInput.Equals("the Jets", StringComparison.OrdinalIgnoreCase) || userInput.Equals("sharks", StringComparison.OrdinalIgnoreCase) || userInput.Equals("the sharks", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                Console.WriteLine("This is not a valid selection, please try again");
                return false;
            }
        }
        public void runRoShamBoApp()
        {
            bool invalidInput = true;
            
            Console.WriteLine("Welcome to the RoShamBo App.\n Enter your name:");
            var userName = Console.ReadLine();           


            while (invalidInput)
            {
                Console.WriteLine("Would you like to play against the Sharks or the Jets?");
                var playingAgainst = Console.ReadLine();
                if (ValidateTeamName(playingAgainst))
                {
                    invalidInput = false;
                    bool invalidPlay = true;
                    while (invalidPlay)
                    {
                        Console.WriteLine("Rock, Paper, or Scissors?");
                        var userSelection = Console.ReadLine();
                        if (validRPSInput(userSelection))
                        {
                            invalidPlay = false;
                            if (playingAgainst.Equals("jets", StringComparison.OrdinalIgnoreCase) || playingAgainst.Equals("the Jets", StringComparison.OrdinalIgnoreCase))
                            {
                                var AISelection = new TheJets();
                                AISelection.playerName = "The Jets";
                                AISelection.roshamboValue = AISelection.GetRoshamBo();


                                Console.WriteLine($"{userName}: {userSelection}");
                                Console.WriteLine($"{AISelection.playerName}: {AISelection.roshamboValue}");
                                if (userSelection.Equals("Scissors", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine($"{AISelection.playerName} Win");
                                }
                                else if (userSelection.Equals("paper", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine($"{userName} Wins");
                                }
                                else
                                {
                                    Console.WriteLine("Draw");
                                }

                            }
                            else if (playingAgainst.Equals("sharks", StringComparison.OrdinalIgnoreCase) || playingAgainst.Equals("the sharks", StringComparison.OrdinalIgnoreCase))
                            {
                                var AISelection = new TheSharks();
                                AISelection.playerName = "The Sharks";
                                AISelection.roshamboValue = AISelection.GetRoshamBo();




                                Console.WriteLine($"{userName}: {userSelection}");
                                Console.WriteLine($"{AISelection.playerName}: {AISelection.roshamboValue}");

                                if (userSelection.Equals("Scissors", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (AISelection.roshamboValue == RoShamBo.Rock)
                                    {
                                        Console.WriteLine($"{AISelection.playerName} Win");
                                    }
                                    else if (AISelection.roshamboValue == RoShamBo.Paper)
                                    {
                                        Console.WriteLine($"{userName} Wins");
                                    }
                                    else if (AISelection.roshamboValue == RoShamBo.Scissors)
                                    {
                                        Console.WriteLine("Draw");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Broke It");
                                    }

                                }
                                else if (userSelection.Equals("Rock", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (AISelection.roshamboValue == RoShamBo.Paper)
                                    {
                                        Console.WriteLine($"{AISelection.playerName} Win");
                                    }
                                    else if (AISelection.roshamboValue == RoShamBo.Scissors)
                                    {
                                        Console.WriteLine($"{userName} Wins");
                                    }
                                    else if (AISelection.roshamboValue == RoShamBo.Rock)
                                    {
                                        Console.WriteLine("Draw");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Broke It");
                                    }
                                }
                                else if (userSelection.Equals("paper", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (AISelection.roshamboValue == RoShamBo.Scissors)
                                    {
                                        Console.WriteLine($"{AISelection.playerName} Win");
                                    }
                                    else if (AISelection.roshamboValue == RoShamBo.Rock)
                                    {
                                        Console.WriteLine($"{userName} Wins");
                                    }
                                    else if (AISelection.roshamboValue == RoShamBo.Paper)
                                    {
                                        Console.WriteLine("Draw");
                                    }
                                    else
                                    {
                                        
                                        Console.WriteLine("You Broke It");
                                    }
                                }

                            }
                        }                                                
                    }
                    
                    
            
                } 
                
            



            }



        }

        private bool validRPSInput(string userSelection)
        {
            if(userSelection.Equals("rock", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("paper", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("scissors", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                Console.WriteLine("That is not a valid selection, please try again");
                return false;
            }
        }
    }
}
