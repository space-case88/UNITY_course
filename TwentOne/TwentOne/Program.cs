using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the High Sierra Hotel and Casino. Give us your name and your money.");
            string playerName = Console.ReadLine();
            Console.WriteLine("Not that it's any of my business but how much money do you have with you?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;
                while (player.isActivePlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("You Died");
            }
            Console.WriteLine("Feel free to give us more money somewhere else.");
            Console.Read();
        }
    }
}
