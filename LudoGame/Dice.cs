using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public class Dice
    {
        // Field dice value
        private int diceValue;

        // Constructor 
        public Dice()
        {
            this.ThrowDice();
        }

        // Method throw dice
        public int ThrowDice()
        {
            Random rnd = new Random();

            this.diceValue = rnd.Next(1, 7);
            return this.diceValue;
        }

        // Look at the dice value
        public int GetValue()
        {
            return this.diceValue;
        }
    }

}
