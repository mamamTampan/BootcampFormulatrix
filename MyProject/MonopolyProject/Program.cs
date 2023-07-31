using System;

namespace MonopolyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi permainan
            Source.MonopolyGame game = new Source.MonopolyGame();
            game.SetInitialState();
            game.SetTurnsOrder();

            // Mulai permainan
            Console.WriteLine("Welcome to Monopoly Game!");

            while (game.CheckGameStatus() != Source.GameStatus.ONGOING)
            {
                Source.Interface.IPlayer currentPlayer = game.GetCurrentTurn();

                // Tampilkan informasi tentang player yang sedang bermain
                Console.WriteLine("Current Player: " + currentPlayer.GetName());
                Console.WriteLine("Position: " + game.CheckPlayerPosition(currentPlayer));
                Console.WriteLine("Balance: " + game.CheckPlayerBalance(currentPlayer));
                Console.WriteLine();

                // Implementasikan interaksi dengan pemain, misalnya:
                // - Lepaskan dadu dan pindahkan pemain berdasarkan hasil lemparan dadu
                // - Lakukan tindakan berdasarkan kotak tempat pemain mendarat
                // - Lakukan pembelian properti, membayar sewa, dan lain-lain
                // - ...

                // Pindahkan giliran ke pemain selanjutnya
                game.SetNextTurn();
            }

            // Permainan berakhir, cari pemenang
            Source.Interface.IPlayer winner = game.CheckWinner();
            Console.WriteLine("Game Over!");
            Console.WriteLine("Pemenang: " + winner.GetName());

            Console.ReadLine();
        }
    }
}
