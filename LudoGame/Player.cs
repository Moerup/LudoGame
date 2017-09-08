using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public class Player
    {
        private readonly string name;

        public Player(string playerName) //constructor new player
        {
            // Set playername in class field name
            this.name = playerName;
        }
        // returns name
        public string GetName
        {
            get{
                return this.name;
            }
        }
    }
}
