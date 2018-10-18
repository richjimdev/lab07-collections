using Collection.Classes;
using System;
using Xunit;

namespace CollectionsTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing if a card can be added
        /// </summary>
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

        /// <summary>
        /// Testing whether a card can be removed
        /// </summary>
        [Fact]
        public void RemoveRemovesACard()
        {
            //Arrange
            Deck<Card> myDeck = new Deck<Card>();
            Card myCard = new Card { Suit = Suit.Spades, Value = Value.Ace };
            myDeck.Add(myCard);

            myDeck.Remove(0);

            //Assert
            Assert.Equal(0, myDeck.count);
        }
        
    }
}
