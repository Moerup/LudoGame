using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    public enum FieldType { Start, Home, Safe, InPlay, Finish}
    public class Field
    {
        private GameColor color;
        private int fieldId;
        private Token[] tokens = new Token[2];
        public Field(int id, GameColor color)
        {
            this.fieldId = id;
            this.color = color;
        }


    }
}
