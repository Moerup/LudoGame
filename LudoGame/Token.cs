using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public class Token
    {
        private GameColor color;
        // Constructor
        public Token(GameColor clr)
        {
            this.color = clr;
        }

        public GameColor GetColor()
        {
            return this.color;
        }
    }
}
