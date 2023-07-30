using System;
using System.Collections.Generic;

namespace MonopolyProject.Source
{
    public class CardDeck
    {
        private Stack<ChanceCard> chanceDeck;
        private Stack<CommunityCard> commDeck;

        public CardDeck()
        {
            chanceDeck = new Stack<ChanceCard>();
            commDeck = new Stack<CommunityCard>();
        }
        public bool ShuffleCard<T>(Stack<T> deck)
        {
            if (deck == null || deck.Count <= 1)
                return false;

            Random shuffle = new Random();
            List<T> tempDeck = new List<T>(deck);
            deck.Clear();

            while (tempDeck.Count > 0)
            {
                int randomIndex = shuffle.Next(0, tempDeck.Count);
                deck.Push(tempDeck[randomIndex]);
                tempDeck.RemoveAt(randomIndex);
            }
            return true;
        }
    }
}