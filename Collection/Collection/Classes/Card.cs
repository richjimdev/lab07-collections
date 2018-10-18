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

    /// <summary>
    /// Enum for all 4 suits
    /// </summary>
    public enum Suit
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }

    /// <summary>
    /// Enum for all cards, really helpful to create a whole deck with a loop
    /// </summary>
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
