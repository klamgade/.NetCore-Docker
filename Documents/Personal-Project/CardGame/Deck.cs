using System;
using System.Linq;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards { get; set; }
        private int currentCard { get; set; }
        private const int NUMBER_OF_CARDS = 52;
        private Random randomNum;

        public Deck()
        {
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            cards = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            randomNum = new Random();
            for (int count = 0; count < cards.Length; count++)
            {
                cards[count] = new Card(faces[count % 11], suits[count / 13]);
            }
        }

        public Card[] Shuffle()
        {
            return cards.OrderBy(x => randomNum.Next()).ToArray();
        }

        public Card DealCard()
        {
            if (currentCard < cards.Length)
                return cards[currentCard++];
            else
                return null;
        }

    }
}
