using Collection.Classes;
using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
            
        }

        /// <summary>
        /// Creating simple navigation to display Deck and Card class features
        /// </summary>
        public static void MainMenu()
        {
            Deck<Card> myDeck = new Deck<Card>();
            PopulateDefaultDeck(myDeck);
            Console.WriteLine(DisplayAndCount(myDeck));

            while (true)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("Hello. What would you like to do?");
                Console.WriteLine("1. View cards. 2. Delete Cards. 3. Select Card by Suit. 4. Exit");
                string select = Console.ReadLine();
                if (select == "1")
                    Console.WriteLine(DisplayAndCount(myDeck));
                else if (select == "2")
                {
                    Console.WriteLine("Type a number to remove that card.");
                    string choice = Console.ReadLine();
                    myDeck.Remove(Int32.Parse(choice) - 1);

                    Console.WriteLine(DisplayAndCount(myDeck));
                }
                else if (select == "3")
                {
                    Console.WriteLine("Now select a suit to show cards of that suit from your deck. 1. Spades, 2. Clubs, 3. Diamonds, 4. Hearts");

                    string choice = Console.ReadLine();
                    int choiceInt = Int32.Parse(choice) - 1;

                    Console.WriteLine(DisplayAndCount(myDeck.ReturnOfSuit((Suit)choiceInt)));
                }
                else if (select == "4")
                    break;
                else
                    Console.WriteLine("Select 1-4 only.");
            }
        }

        /// <summary>
        /// Populates the standard deck. Creating 12 cards, 3 of each suit
        /// </summary>
        /// <param name="deck">Takes in a deck</param>
        public static void PopulateDefaultDeck(Deck<Card> deck)
        {
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Card newCard = new Card();
                    newCard.Suit = (Suit)i;
                    newCard.Value = (Value)counter++;
                    deck.Add(newCard);
                }
            }
        }
        
        /// <summary>
        /// Method for iterating over the deck and displaying the cards within
        /// </summary>
        /// <param name="cards">Takes in a deck of cards</param>
        /// <returns></returns>
        public static string DisplayAndCount(Deck<Card> cards)
        {
            Console.WriteLine("=======================================");
            int cardCount = 0;

            foreach (Card card in cards)
            {
                if (card != null)
                {
                    cardCount++;
                    Console.WriteLine($"{cardCount}: {card.Value} of {card.Suit}");
                }
            }

            return $"There are {cards.count} cards in this Deck";
        }
    }
}
