using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables


        public Setup setup;

        public Player playerOne;
        public Player playerTwo;

        public int roundNumber;


        //constructor spawner
        public Game()
        {
            setup = new Setup();
            roundNumber = 1;
        }
        //member methods
        public void StartGame()
        {
            DisplayRules();
            setup.SetupGame();
            WinCondition(setup.BestOf);
            Console.WriteLine(WinCondition(setup.BestOf));
            CreatePlayers(setup.Pvp);
            Console.WriteLine("Time to name the players");
            Console.WriteLine("Player One: " + playerOne.ChooseName());
            Console.WriteLine("Player Two: " + playerTwo.ChooseName());


            
        }

        public void RunRound()
        {

        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine("This game is a variant of the popular game Rock Paper Scissors");
            Console.WriteLine("This game can be played Player vs. Player, Player vs. AI or can be simulated AI vs. AI.");
            Console.WriteLine("User chooses how many rounds the game is best of");
            Console.WriteLine("User also chooses whether gesture is made on scissors or on shoot.");
            Console.WriteLine("Rock beats Scissors and Lizard, Scissors beats Paper and Lizard, Paper Beats Rock and Spock,");
            Console.WriteLine("Lizard beats Paper and Spock and Spock beats Rock and Scissors.");
            Console.WriteLine("The first player to win enough rounds wins. Good luck!");
            Console.WriteLine(" ");
        }

        

        public int WinCondition(int bestOf)
        {
            int winRound = (((bestOf - 1) / 2) + 1);
            return winRound;
        }

        
        public void CreatePlayers(int players)
        {
            if (players == 0)
            {
                playerOne = new Computer();
                playerTwo = new Computer();
            }
            if (players == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            if (players == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }

        }
        
    }
}
