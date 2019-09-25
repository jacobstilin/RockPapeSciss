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
        
        int player1Score;
        int player2Score;
        int bestOf;
        Setup setup;


        //constructor spawner
        public Game()
        {
            setup = new Setup();

        }
        //member methods
        public void StartGame()
        {
            setup.StartGame();
        }
        
        
    }
}
