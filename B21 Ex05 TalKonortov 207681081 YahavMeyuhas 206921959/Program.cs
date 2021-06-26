using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;

namespace GUI
{
    public class Program
    {
        public static void  Main()
        {
            HomePage homePage = new HomePage();
            homePage.ShowDialog();

            BoardGUI boardGUI = new BoardGUI(homePage.Engine, homePage.IsAi);
            boardGUI.ShowDialog();
        }
    }
}
