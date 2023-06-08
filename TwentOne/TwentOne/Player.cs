using System;
using System.Collections.Generic;
using System.Text;

namespace TwentOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivePlaying { get; set; }
    }
}
