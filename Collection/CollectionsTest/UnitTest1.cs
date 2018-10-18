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

        /// <summary>
        /// Tests if return suit will return cards only belonging to that suit
        /// </summary>
        /// <param name="input">Enum index of suit</param>
        /// <param name="expected">count of cards of that suit</param>
        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        [InlineData(2, 2)]
        [InlineData(3, 1)]
        public void ReturnOfSuitReturnsCardsOfSameSuit(int input, int expected)
        {
            //Arrange
            Deck<Card> myDeck = new Deck<Card>();
            Card spade = new Card { Suit = Suit.Spades, Value = Value.Ace };
            Card heart = new Card { Suit = Suit.Hearts, Value = Value.Ace };
            Card diamond = new Card { Suit = Suit.Diamonds, Value = Value.Ace };
            Card club = new Card { Suit = Suit.Clubs, Value = Value.Ace };


            myDeck.Add(spade);
            myDeck.Add(spade);
            myDeck.Add(club);
            myDeck.Add(club);
            myDeck.Add(club);
            myDeck.Add(diamond);
            myDeck.Add(diamond);
            myDeck.Add(heart);

            //Assert
            Assert.Equal(expected, myDeck.ReturnOfSuit((Suit)input).count);
        }

        /// <summary>
        /// Testing that no cards return if there are none of that suit
        /// </summary>
        [Fact]
        public void ReturnOfSuitReturnsZeroIfNoneFound()
        {
            //Arrange
            Deck<Card> myDeck = new Deck<Card>();
            Card myCard = new Card { Suit = Suit.Spades, Value = Value.Ace };
            myDeck.Add(myCard);

            //Assert
            Assert.Equal(0, myDeck.ReturnOfSuit((Suit)2).count);
        }
    }
}
