using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_0
{
    class Player
    {
        /// <summary>
        /// The name of the player.
        /// </summary>
        public string _name = "";

        /// <summary>
        /// An array of Card objects forming the Player's hand.
        /// </summary>
        public List<Card> _hand;


        /// <summary>
        /// Gets and sets the current hand of cards for the given player.
        /// </summary>
        //public Card[] Hand
        //{
        //    get
        //    {
        //        return _hand;
        //    }
        //    set
        //    {
        //        _hand = value;
        //    }
        //}

        /// <summary>
        /// Constructs a new player.
        /// </summary>
        public Player()
        {
            _hand = new List<Card>();
        }

        /// <summary>
        /// Constructs a new player with a name.
        /// </summary>
        /// <param name="name"></param>
        public Player(string name)
        {
            _name = name;
            _hand = new List<Card>();
        }

        /// <summary>
        /// Converts the Card object list into a string list, and joins that into one string for output.
        /// </summary>
        /// <returns>returns the string representing the cards in the given player's hand.</returns>
        public string HandToString()
        {
            List<string> stringHandList = new List<string>();
            for (int i = 0; i < _hand.Count; i++)
            {
                stringHandList.Add(_hand[i].ToString());
            }
            return string.Join(" ", stringHandList.ToArray());
        }

        /// <summary>
        /// Shuffles the player's hand.
        /// </summary>
        public void Shuffle()
        {
            new Random().Shuffle(_hand);
        }

        /// <summary>
        /// Discards all extra duplicates in a player's hand.
        /// </summary>
        public void DiscardDupes()
        {
            for (int j = 0; j < _hand.Count; j++)
            {
                for (int i = 0; i < _hand.Count; i++)
                {
                    if (_hand[j] != _hand[i])
                    {
                        if (_hand[j].CardValue == _hand[i].CardValue)
                        {
                            _hand.Remove(_hand[i]);
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Discards all pairs in a player's hand. Returns false if the player has no cards left.
        /// </summary>
        /// <returns>returns false if the player has no cards left. Otherwise, returns true.</returns>
        public bool DiscardPairs()
        {
            for (int j = 0; j < _hand.Count; j++)
            {
                for (int i = 0; i < _hand.Count; i++)
                {
                    if (_hand[j] != _hand[i])
                    {
                        if (_hand[j].CardValue == _hand[i].CardValue)
                        {
                            _hand.Remove(_hand[i]);
                            _hand.Remove(_hand[j]);
                            break;
                        }
                    }
                }
            }
            
            if (_hand.Count <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Removes a card at the given index.
        /// </summary>
        /// <param name="index">The index of the card to remove.</param>
        /// <returns>A Card value of the card removed.</returns>
        public Card Remove(int index)
        {
            Card toReturn = _hand[index];
            _hand.RemoveAt(index);
            return toReturn;
        }
    }
}
