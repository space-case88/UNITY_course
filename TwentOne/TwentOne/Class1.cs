using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TwentOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        //suit of the card
        public string Suit { get; set; }
        //face of the card
        public string Face { get; set; }

    }
}
