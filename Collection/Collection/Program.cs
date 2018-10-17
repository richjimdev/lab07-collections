using Collection.Classes;
using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck<Card> myDeck = new Deck<Card>();

            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Card newCard = new Card();
                    newCard.Suit = (Suit)i;
                    newCard.Value = (Value)counter++;
                    myDeck.Add(newCard);
                }
            }

            Console.WriteLine(DisplayAndCount(myDeck));

            Console.WriteLine("Type to remove");
            string choice = Console.ReadLine();

            myDeck.Remove(Int32.Parse(choice));

            Console.WriteLine(DisplayAndCount(myDeck));

            //Deck<Card> deckOfSuits = new Deck<Card>();

            Console.WriteLine(DisplayAndCount(myDeck.ReturnOfSuit((Suit)1)));

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
