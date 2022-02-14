using System;
using System.Collections.Generic;
using System.Text;

namespace RockpaperSkissorsCore
{
    public abstract class GamePlay
    {
        protected string FirstPlayer;
        protected string SecondPlayer;
        protected string FirstFigure;
        protected string SecondFigure;

        Player player1 = new Player();
        Player player2 = new Player();
        Figure figure1 = new Figure();
        Figure figure2 = new Figure();
        Game game = new Game();

        public GamePlay(string name1, string name2, string figname1, string figname2)
        {
            name1 = FirstPlayer;
            name2 = SecondPlayer;
            figname1 = FirstFigure;
            figname2 = SecondFigure;
        }

        public static void Battle(string name1, string name2, string figname1, string figname2)
        {

        }

        //public static void Battle(Player player1, Player player2, Figure figure1, Figure figure2)
        //{
            
        //}
    }
}
