using System;
using System.Collections.Generic;

namespace Yahtzee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Console.Clear();
            Console.WriteLine("Spela!");

            Dice one = new (Dice.Position.One);
            Dice two = new(Dice.Position.Two);
            Dice three = new(Dice.Position.Three);
            Dice four = new(Dice.Position.Four);
            Dice five = new(Dice.Position.Five);

            List<Dice> active = new() { one, two, three, four, five  };
            List<Dice> saved = new();
            
            ActiveDices ActiveDices = new(active);
            SavedDices SavedDices = new(saved, ActiveDices);

            while (counter < 3)
            {

                Console.Clear();

                if (SavedDices.Dices.Count > 0)
                {
                    Console.WriteLine("Dina sparade tärningar: ");
                    SavedDices.TypeSavedDices();
                }

                Console.ReadLine();
                counter++;
                
                Console.WriteLine($"Kast nr {counter}");
                
                foreach (Dice dice in ActiveDices.Dices)
                {
                    Dice.HitDices(dice);
                }

                ActiveDices.TypeActiveDices();

                if (counter < 3)
                {
                    Console.WriteLine("1. Spara tärningar");
                    Console.WriteLine("2. Avsluta och välj resultat");
                    Console.Write("Ditt val: ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "1")
                    {
                        while (true)
                        {
                            Console.Clear();

                            ActiveDices.TypeActiveDices();

                            Console.WriteLine("Vilken tärning vill du spara?");
                            string diceChoice = Console.ReadLine();

                            int.TryParse(diceChoice, out int diceToBeSaved);

                            SavedDices.Dices.Add(ActiveDices.Dices.Find(x => (int)x.position == diceToBeSaved));
                            ActiveDices.Dices.Remove(ActiveDices.Dices.Find(x => (int)x.position == diceToBeSaved));

                            Console.WriteLine("Sparade tärningar:");
                            SavedDices.TypeSavedDices();

                            Console.WriteLine("Vill du spara fler?");
                            Console.WriteLine("1. Ja");
                            Console.WriteLine("2. Nej");
                            Console.Write("Ditt val: ");
                            string a = Console.ReadLine().ToLower();

                            if (a == "2")
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Välj var du vill lägga ditt resultat");
                }
            }
        }
    }
}
