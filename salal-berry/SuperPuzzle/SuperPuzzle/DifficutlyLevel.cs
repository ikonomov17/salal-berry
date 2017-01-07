using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SuperPuzzle
{
    class DifficutlyLevel
    {
        public void SelectLevel()
        {
            string[] lines = File.ReadAllLines("LevelSelect.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                    SetCursorAndPrint printer = new SetCursorAndPrint();
                    printer.WriteAt(lines[i], 30, 2 + i);


            }
            //foreach (string line in File.ReadLines("LevelSelect.txt"))
            //{
            //    Console.WriteLine("-- {0}", line);
            //}
        }
    }
}
