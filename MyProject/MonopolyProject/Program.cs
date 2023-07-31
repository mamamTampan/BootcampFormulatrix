using System;

namespace MonopolyProject
{
    class Program
    {
        static void Main()
        {
            Source.MonopolyGame game = new Source.MonopolyGame();
            game.SetInitialState();
            game.SetTurnsOrder();

            Console.WriteLine("Welcome to Monopoly Game!");

            while (game.CheckGameStatus() != Source.GameStatus.ONGOING)
            {
                Source.Interface.IPlayer currentPlayer = game.GetCurrentTurn();

                Console.WriteLine("Current Player: " + currentPlayer.GetName());
                Console.WriteLine("Position: " + game.CheckPlayerPosition(currentPlayer));
                Console.WriteLine("Balance: " + game.CheckPlayerBalance(currentPlayer));
                Console.WriteLine();
                game.SetNextTurn();
            }
            Source.Interface.IPlayer winner = game.CheckWinner();
            Console.WriteLine("Game Over!");
            Console.WriteLine("Winner: " + winner.GetName());
            Console.ReadLine();
        }
    }
}
