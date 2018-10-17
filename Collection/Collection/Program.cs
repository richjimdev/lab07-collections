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

            myDeck.Remove(4);

            Console.WriteLine(DisplayAndCount(myDeck));
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
                else break;
            }

            return $"There are {cardCount} cards in this Deck";
        }
    }
}
