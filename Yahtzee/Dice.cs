using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    internal class Dice
    {
        public enum Position
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5
        }
        public Position position;

        public enum Sides
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6
        }
        public Sides sides;

        public Dice(Position position)
        {
            this.position = position;
        }

        public static Dice HitDices(Dice dice)
        {
            Random rand = new();

            int rndSide= rand.Next(1, 6);

            switch (rndSide)
            {
                case 1:
                    dice.sides = Sides.One; 
                    break;
                case 2:
                    dice.sides = Sides.Two; 
                    break;
                case 3:
                    dice.sides = Sides.Three; 
                    break;
                case 4:
                    dice.sides = Sides.Four; 
                    break;
                case 5:
                    dice.sides = Sides.Five; 
                    break;
                case 6:
                    dice.sides = Sides.Six; 
                    break;
            }
            return dice;
        }
    }
}
