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
        //public Dice[] Dices = new Dice[5];
        ActiveDices active;

        public SavedDices(List<Dice> diceList, ActiveDices activeDices)
        {
            Dices = diceList;
            active = activeDices;
        }

        public void TypeSavedDices()
        {
            foreach (Dice dice in Dices)
            {
                //int positionInArray = Array.IndexOf(Dices, dice);
                Console.WriteLine($"T{(int)dice.position}. {dice.sides}");
            }
        }

        //public void SaveDices()
        //{
        //    foreach (Dice dice in active.Dices)
        //    {
        //        int positionInArray = Array.IndexOf(active.Dices, dice);
        //        Console.WriteLine($"T{positionInArray + 1}. {dice.sides}");
        //    }

        //    Console.WriteLine("Vilken tärning vill du spara?");
        //    string diceChoice = Console.ReadLine();

        //    int.TryParse(diceChoice, out int diceToBeSaved);

        //    Dices[diceToBeSaved - 1] = active.Dices[diceToBeSaved - 1];
        //    active.Dices.removeAt
        //}
    }
}
