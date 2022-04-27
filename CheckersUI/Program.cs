using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckersUI
{
    class Program
    {
        public static void Main()
        {
            GameUI gameUI = new GameUI();
            while (!gameUI.IsGameOver)
            {
                gameUI.PlayRound();
            }

            gameUI.PrintGoodByeMassage();
        }
    }
}
