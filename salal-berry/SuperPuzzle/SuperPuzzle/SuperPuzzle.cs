using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SuperPuzzle
{
    
    class SuperPuzzle
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(500);
            LoadLogo loadLogo = new LoadLogo();
            loadLogo.LoadLogoNow();
            LoadControlButtonInfo loadControlButtons = new LoadControlButtonInfo();
            loadControlButtons.LoadInfo();

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                //Console.WriteLine(keyinfo.Key + " was pressed");
                if (keyinfo.Key == ConsoleKey.I)
                {
                    Console.Clear();
                    AboutGame aboutGame = new AboutGame();
                    aboutGame.InfoGame();
                }
                if (keyinfo.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    DifficutlyLevel difficutlyLevel = new DifficutlyLevel();
                    difficutlyLevel.SelectLevel();
                }
            }
            while (keyinfo.Key != ConsoleKey.Q);
            
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
