using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Game
    {
        // Constructor to initialize the game
        public Game()
        {
            // Game Initialization
            Console.WriteLine("\n\n\n############### + + + + + ############### + + + + + ###############\n\n\n" +
                "Welcome to the Adventure Game!");
        }

        // Main method to start the game
        public static void Main(string[] args)
        {
            // Create an instance of the Game class
            Game game = new Game();

            // Game Loop
            game.Run();
        }

        private void Run()
        {
            // Game Logic
            Console.WriteLine("The game is running...");
            // Add your game logic here
        }
    }
}
