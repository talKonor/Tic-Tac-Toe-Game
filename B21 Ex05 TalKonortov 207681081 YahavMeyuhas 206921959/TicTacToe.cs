using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class TicTacToe
    {
        public static void StartGame()
        {
            HomePage homePage = new HomePage();
            BoardGUI boardGUI;

            homePage.ShowDialog();
            boardGUI = new BoardGUI(homePage.Engine, homePage.IsAi);
            boardGUI.ShowDialog();
        }
    }
}
