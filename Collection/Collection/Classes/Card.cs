using System;
using System.Collections.Generic;
using System.Text;

namespace Collection.Classes
{
    public class Card
    {
        public Suit Suit { get; set; }
        public string Value { get; set; }
    }

    public enum Suit
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }
}
