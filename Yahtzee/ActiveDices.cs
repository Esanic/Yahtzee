using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    internal class ActiveDices
    {
        public List<Dice> Dices;
        //public Dice[] Dices = new Dice[5];

        public ActiveDices(List<Dice> diceList)
        {
            Dices = diceList;
        }

        public void TypeActiveDices()
        {

            foreach (Dice dice in Dices)
            {
                //int positionInArray = Array.IndexOf(Dices, dice);
                Console.WriteLine($"T{(int)dice.position}. {dice.sides}");
            }
        }
    }
}
