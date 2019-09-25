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
        int round;
        int player1Score;
        int player2Score;
        int bestOf;
        bool pvpSelect;
        string pvp;


        //constructor spawner
        public Game()
        {
            round = 1;
            bestOf = 0;

        }
        //member methods
        public void StartGame()
        {
            pvpSelect = PvPSelector();
            Console.WriteLine(pvpSelect);
            bestOf = BestOf();
            Console.ReadLine();
;
        }
        public bool PvPSelector()
        {
            Console.WriteLine("Is this PvP or PvE?");
            pvp = Console.ReadLine();
            if(pvp == "pvp")
            {
                return true;
            }
            if(pvp == "pve")
            {
                return false;
            }
            else
            {
                return PvPSelector();
            }
        }

        public int BestOf()
        {
            Console.WriteLine("Best of how many rounds?");
            int input = Console.Read();
            
                return input;
            
            
        }
        
    }
}
