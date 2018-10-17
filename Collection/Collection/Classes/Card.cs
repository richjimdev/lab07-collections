using System;
using System.Collections.Generic;
using System.Text;

namespace Collection.Classes
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }
    }

    public enum Suit
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }

    public enum Value
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
