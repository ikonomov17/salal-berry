using System;

namespace SuperPuzzle
{
    class SetCursorAndPrint
    {
        public void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
