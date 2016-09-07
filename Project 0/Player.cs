using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_0
{
    class Player
    {
        private string[] _hand;


        /// <summary>
        /// Gets and sets the current hand of cards for the given player.
        /// </summary>
        public string[] Hand
        {
            get
            {
                return _hand;
            }
            set
            {
                _hand = value;
            }

        }
    }
}
