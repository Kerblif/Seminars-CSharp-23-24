using System;

namespace Self03
{
    public class LatinChar
    {
        private char _char;

        public char Char { get => _char; set { _char = value; } }
    
        public LatinChar() : this('a') { }
        public LatinChar(char value) 
        {
            _char = value;
        }

        public void Next()
        {
            _char++;
        }
    }
}
