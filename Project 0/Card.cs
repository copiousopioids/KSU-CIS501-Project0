using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_0
{
    public class Card
    {
        /// <summary>
        /// This card's suit.
        /// </summary>
        private int _suit;

        /// <summary>
        /// This card's value.
        /// </summary>
        private int _value;

        /// <summary>
        /// Constant int values enumerating the non-numeric cards.
        /// </summary>
        public const int ACE = 1, JACK = 11, QUEEN = 12, KING = 13;

        /// <summary>
        /// Enumerating the suits.
        /// </summary>
        public enum Suit {SPADES, HEARTS, DIAMONDS, CLUBS, OLDMAID};

        /// <summary>
        /// Default card constructor. Default card is Ace of Spades.
        /// </summary>
        public Card()
        {
            _suit = (int)Suit.SPADES;
            _value = ACE;
        }

        public Card(int thisVal, Suit thisSuit)
        {
            if ((int)thisSuit < 0 || (int)thisSuit > 4)
            {
                throw new IndexOutOfRangeException("The suit is not valid.");
            }
            if (thisSuit != Suit.OLDMAID && (thisVal < 0 || thisVal > 13))
            {
                throw new IndexOutOfRangeException("The value is not valid.");
            }
        }

    }
}
