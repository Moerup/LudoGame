using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    // Colors used for Ludo game
    public enum GameColor {Blue, Red, Yellow, Green }
    public class Game
    {
        private int numberOfPlayers;
        private Player[] players;

        // Constructor method of Game class
        public Game()
        {
            MainMenu();
        }
        //Creating MainMenu
        private void MainMenu()
        {
            Console.WriteLine("Welcome to Ludo!");
            SetNumberOfPlayers();
            CreatePlayers();
            ShowPlayers();
            Console.ReadKey();
        }
        private void SetNumberOfPlayers()
        {
            Console.Write("How many players?: ");
            while (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                if (!int.TryParse(Console.ReadLine(), out this.numberOfPlayers))
                {
                    Console.WriteLine();
                    Console.WriteLine("Out of scope, choose between 2 and 4");
                }
                    
            }
                
        }
        private void CreatePlayers()
        {
            this.players = new Player[this.numberOfPlayers];

            for (int i = 0; i < this.numberOfPlayers; i++)
            {
                Console.WriteLine();
                Console.Write("Name of player {0}: ", (i + 1));
                string name = Console.ReadLine();
                players[i] = new Player(name);
            }
        }
        private void ShowPlayers()
        {
            Console.WriteLine();
            Console.WriteLine("Players in game:");
            foreach(Player pl in this.players)
            {
                Console.WriteLine(pl.GetName);
            }
        }
    }
}
