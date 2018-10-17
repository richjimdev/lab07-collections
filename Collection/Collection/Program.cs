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

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card newCard = new Card();
                    newCard.Suit = (Suit)i;
                    newCard.Value = (Value)j;
                    myDeck.Add(newCard);
                }
            }

            int cardCount = 0;

            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
                cardCount++;
            }

            Console.WriteLine($"There are {cardCount} cards in this Deck");


        }
    }
}
