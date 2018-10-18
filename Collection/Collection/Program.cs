using Collection.Classes;
using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> myDeck = new Deck<Card>();
            PopulateDefaultDeck(myDeck);

            Console.WriteLine(DisplayAndCount(myDeck));

            Console.WriteLine("Let's try to remove. Type a number to remove that card.");
            string choice = Console.ReadLine();
            myDeck.Remove(Int32.Parse(choice) - 1);

            Console.WriteLine(DisplayAndCount(myDeck));

            Console.WriteLine("Now select a suit to show cards of that suit from your deck. 1. Spades, 2. Clubs, 3. Diamonds, 4. Hearts");

            choice = Console.ReadLine();
            int choiceInt = Int32.Parse(choice) - 1;

            Console.WriteLine(DisplayAndCount(myDeck.ReturnOfSuit((Suit)choiceInt)));
        }

        public static void PopulateDefaultDeck(Deck<Card> deck)
        {
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Card newCard = new Card();
                    newCard.Suit = (Suit)i;
                    newCard.Value = (Value)counter++;
                    deck.Add(newCard);
                }
            }
        }
        
        public static string DisplayAndCount(Deck<Card> cards)
        {
            int cardCount = 0;

            foreach (Card card in cards)
            {
                if (card != null)
                {
                    cardCount++;
                    Console.WriteLine($"{cardCount}: {card.Value} of {card.Suit}");
                }
            }

            return $"There are {cardCount} cards in this Deck";
        }
    }
}
