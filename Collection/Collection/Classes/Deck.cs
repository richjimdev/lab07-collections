using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[15];
        int count = 0;

        public void Add(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }

            cards[count++] = card;
        }

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
            cards = newArr;
            return cards;
        }

        //Book book = (Book) Conert.ChangeType(books[int], typeof(book));

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
