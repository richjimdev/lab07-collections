using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[15];
        public int count = 0;

        /// <summary>
        /// Adds a card to the deck
        /// </summary>
        /// <param name="card">Takes in a card object</param>
        public void Add(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }

            cards[count++] = card;
        }

        /// <summary>
        /// Removes a card from the deck
        /// </summary>
        /// <param name="idx"></param>
        /// <returns>A generic array of cards</returns>
        public T[] Remove(int idx)
        {
            T[] newArr = new T[cards.Length - 1];
            int counter = 0;

            for (int i = 0; i < cards.Length; i++)
            {
                if (i == idx)
                {
                    continue;
                } else
                {
                    newArr[counter] = cards[i];
                    counter++;
                }
            }
            count--;
            cards = newArr;
            return cards;
        }

        /// <summary>
        /// Grabs card by a specific suit
        /// </summary>
        /// <param name="suit">Takes in a Suit enum</param>
        /// <returns>Returns a Deck with results</returns>
        public Deck<Card> ReturnOfSuit(Suit suit)
        {
            Deck<Card> deckOfSuit = new Deck<Card>();

            for (int i = 0; i < count; i++)
            {
                Card newCard = (Card)Convert.ChangeType(cards[i], typeof(Card));

                if (newCard != null && newCard.Suit == suit)
                {
                    deckOfSuit.Add(newCard);
                }
            }

            return deckOfSuit;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
