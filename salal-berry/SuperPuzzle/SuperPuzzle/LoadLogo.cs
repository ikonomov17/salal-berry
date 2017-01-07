using System;
using System.IO;

namespace SuperPuzzle
{
    class LoadLogo
    {

        public void LoadLogoNow()
        {
            string[] lines = File.ReadAllLines("Logo.txt");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    SetCursorAndPrint printer = new SetCursorAndPrint();
                    printer.WriteAt(lines[i * 10 + j], 20, 5 + j);
                    //WriteAt(lines[i * 10 + j], 20, 5 + j);
                }

                if (i == 4)
                {
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                }
                Console.Clear();
            }
        }
    }
}
