using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPuzzle
{
    class LoadControlButtonInfo
    {
        string[] options = { "n - new game", "r - reset game", "up arow - move up", "down arow - move down", "left arow - move left", "right arow - move right", "i - info", "q - quit" };
        public void LoadInfo()
        {
            

            for (int i = 0; i < options.Length; i++)
            {
                int infoForButton = options[i].IndexOf("-");
                int origWidth = (Console.WindowWidth / 2) - infoForButton;

                SetCursorAndPrint printer = new SetCursorAndPrint();
                printer.WriteAt(options[i], origWidth, 5 + i);
            }
        }
    }
}
