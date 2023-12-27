using System;
using System.Collections.Generic;
using System.Linq;

namespace Uaine.Objects.Game.Card
{
    public class Deck
    {
        protected List<Card> cardDeck;
        public Card[] returnDeckArray { get => cardDeck.ToArray(); }
        protected List<Card> discardPile;
        public Card[] returnDiscardArray { get => discardPile.ToArray(); }
        public int RemainingCards { get => cardDeck.Count; }
        public int NumberDiscardCards { get => discardPile.Count; }

        public Deck(Card[] list)
        {
            //int size = numValues * numClasses;
            cardDeck = list.ToList();
            discardPile = new List<Card>();
            ShuffleDeck();
        }
        public Deck(int numValues, int numClasses)
        {
            //int size = numValues * numClasses;
            cardDeck = new List<Card>();
            discardPile = new List<Card>();
            int k = 0;
            for (int i = 0; i < numValues; i++)
            {
                for (int c = 0; c < numClasses; c++)
                {
                    cardDeck.Add(new Card(i, c));
                    k += 1;
                }
            }
            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            System.Random random = new System.Random();
            cardDeck = new List<Card>(cardDeck.OrderBy(x => random.Next()).ToArray());
        }

        public Card DrawCard()
        {
            return DrawAtIndex(RemainingCards - 1);
        }
        public Card[] DrawCards(int number)
        {
            if (number > RemainingCards)
            {
                throw new Exception("Not enough cards remaining in deck to draw");
            }
            Card[] drawn = new Card[number];
            for (int i = 0; i < number; i++)
            {
                drawn[i] = DrawCard();
            }
            return drawn;
        }
        public Card DrawRandomCard()
        {
            System.Random random = new System.Random();
            int i = random.Next(RemainingCards);
            return DrawAtIndex(i);
        }
        public Card DrawAtIndex(int i)
        {
            if (RemainingCards == 0)
            {
                throw new Exception("Not enough cards remaining in deck to draw");
            }
            Card drawn = cardDeck[i];
            cardDeck.RemoveAt(i);
            return drawn;
        }

        public void addToDiscardPile(Card thisCard)
        {
            discardPile.Add(thisCard);
        }

        public void AddToDeck(Card thisCard)
        {
            cardDeck.Add(thisCard);
        }

        public void ReturnDiscardPileToDeck()
        {
            cardDeck.AddRange(discardPile);
            discardPile.Clear();
        }
    }
}
