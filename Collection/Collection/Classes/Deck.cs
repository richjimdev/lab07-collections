﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection.Classes
{
    class Deck<T> : IEnumerable
    {
        T[] cards = new T[52];
        int count = 0;

        public void Add(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }

            cards[count++] = card;
        }

        //public Deck<T> Remove(string title)
        //{

        //}

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