using Collection.Classes;
using System;
using Xunit;

namespace CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddSuccessfullyAddsCard()
        {
            //Arrange
            Deck<Card> myDeck = new Deck<Card>();
            Card myCard = new Card { Suit = Suit.Spades, Value = Value.Ace };
            myDeck.Add(myCard);

            //Assert
            Assert.Equal(1, myDeck.count);
        }

    }
}
