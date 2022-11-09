/***
 * Purpose: Demonstrate class level methods using a simple die class
 * Input: Die.cs
 * Output: wins, losses, ties, games played
 * Author: Jen
 * DAte: November 9/2022
 * 
 */





using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace DieGAme
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Die computerDie1 = new Die(20),  /**** YOu can leave these bad boys empty, or fill em using the GReedy constructor******/
                computerDie2 = new Die(20),
                playerDie1 = new Die(20),
                playerDie2 = new Die(20);
                int playerRoll,
                    computerRoll,
                    playerWins = 0,
                    computerWins = 0,
                    ties = 0,
                    gamesPlayed = 0;
                char rollAgain;
                string message;

                ///game loop (do!)
                do
                {   //roll the dice
                    computerDie1.Roll();
                    computerDie2.Roll();
                    playerDie1.Roll();
                    playerDie2.Roll();

                    ///add the dice
                    playerRoll = playerDie1.AddDie(playerDie2);
                    computerRoll = computerDie1.AddDie(playerDie1);


                    //display the dice
                    DisplayDice(playerDie1, playerDie2, "Player");
                    DisplayDice(computerDie1, computerDie2, "Computer");

                    //determine the winner or a tie
                    if (playerRoll > computerRoll)
                    {
                        playerWins++;
                        message = "Player Wins";
                    }
                    else if (playerRoll < computerRoll)
                    {
                        computerWins++;
                        message = "Computer Wins";
                    }
                    else
                    {
                        ties++;
                        message = "Tie";
                    }
                    Console.WriteLine(message);
                    gamesPlayed++;

                    //prompt to roll again
                    Console.WriteLine("Roll again (Y): ");
                    rollAgain = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));

                } while (rollAgain == 'Y'); /****if the red squiggly doesn't go away after you pop stuff in the DO loop, just make char rollAgain = 'N' ***/
                //display game summary
                Console.WriteLine($"{gamesPlayed} games played: Player Wins: {playerWins}, Computer Wins: {computerWins}, and Ties: {ties}");
            }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }//end of Main

        static void DisplayDice(Die die1, Die die2, string player)
        {
            Console.WriteLine($"{player,8}'s roll was: {die1.FaceValue} and {die2.FaceValue}");
        }
    }
}