using System;
using System.Collections.Generic;

namespace Yahtzee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            
            Console.WriteLine("Spela!");

            Dice one = new (Dice.Position.One);
            Dice two = new(Dice.Position.Two);
            Dice three = new(Dice.Position.Three);
            Dice four = new(Dice.Position.Four);
            Dice five = new(Dice.Position.Five);

            //Dice[] activeDices = {one, two, three, four, five};
            //Dice[] savedDices = Array.Empty<Dice>();
            List<Dice> active = new() { one, two, three, four, five  };
            List<Dice> saved = new();

            
            ActiveDices ActiveDices = new(active);
            SavedDices SavedDices = new(saved, ActiveDices);

            while (counter < 3)
            {

                if (SavedDices.Dices.Count > 0)
                {
                    Console.WriteLine("Dina sparade tärningar: ");
                    SavedDices.TypeSavedDices();
                }

                Console.ReadLine();
                Console.WriteLine("Tärningarna kastas...");
                counter++;

                foreach (Dice dice in ActiveDices.Dices)
                {
                    Dice.HitDices(dice);
                }

                ActiveDices.TypeActiveDices();

                Console.WriteLine("Vill du spara tärningar?");
                string answer = Console.ReadLine().ToLower();

                while (answer == "ja" || answer == "j")
                {
                    Console.Clear();

                    ActiveDices.TypeActiveDices();

                    Console.WriteLine("Vilken tärning vill du spara?");
                    string diceChoice = Console.ReadLine();

                    int.TryParse(diceChoice, out int diceToBeSaved);

                    SavedDices.Dices.Add(ActiveDices.Dices.Find(x => (int)x.position == diceToBeSaved - 1));

                    //SavedDices.Dices.Add(ActiveDices.Dices[diceToBeSaved - 1]);
                    //ActiveDices.Dices.Remove(ActiveDices.Dices[diceToBeSaved - 1]);

                    Console.WriteLine("Sparade tärningar:");
                    SavedDices.TypeSavedDices();

                    Console.WriteLine("Vill du spara fler?");
                    answer = Console.ReadLine().ToLower();
                }
            }

        }
    }
}
