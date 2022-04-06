using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    internal class SavedDices
    {
        public List<Dice> Dices;

        public SavedDices(List<Dice> diceList)
        {
            Dices = diceList;
        }

        public void TypeSavedDices()
        {
            foreach (Dice dice in Dices)
            {

                Console.WriteLine($"T{(int)dice.position}. {dice.sides}");
            }
        }
    }
}
