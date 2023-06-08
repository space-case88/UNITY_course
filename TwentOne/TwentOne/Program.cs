﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Casey", "Connie", "Brecken" };
            //game.ListPlayers();
            //Console.ReadLine();

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
    }
}
