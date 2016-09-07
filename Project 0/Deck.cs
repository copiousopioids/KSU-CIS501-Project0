using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_0
{
    class Deck
    {
        private Card[] _deck;

        private int _cardsUsed;


        public Deck()
        {
            _deck = new Card[53];
            int count = 0;
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int num = 0; num <= 13; num++)
                {
                    _deck[count] = new Card(num, suit);
                    count++;
                }
            }
            _deck[52] = new Card(1, Card.OLDMAID);
            _cardsUsed = 0;
        }

        public void Shuffle()
        {
            new Random().Shuffle(_deck);
            _cardsUsed = 0;
        }

        public int CardsLeft()
        {
            return _deck.Length - _cardsUsed;
        }

        public Card DealCard()
        {
            if (_cardsUsed == _deck.Length)
            {
                throw new IndexOutOfRangeException("No cards are left in the deck.");
            }
            _cardsUsed++;
            return _deck[_cardsUsed - 1];
        }
    }
}
