#define Release

using System;

namespace MonopolyGame
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Welcome to Monopoli Game !\n");
			#if Debug
				RollDice();	
				DrawChanceCard();
				SellProperty("Canada");
			#elif Release
				int diceValue = RollDice();
				Console.WriteLine($"Throw dice: {diceValue}\n");
				DrawChanceCard();
				SellProperty("Canada");
				Console.WriteLine("U're Bankrupt\n");
			#endif
			Console.WriteLine("Thanks for play Monopoli Game.");
			Console.ReadLine();
		}

		static int RollDice()
		{
			Random random = new Random();
			return random.Next(2, 12);
		}

		static void SellProperty(string propertyName)
		{
			Console.WriteLine($"Player Sell property: {propertyName}\n");
		}

		static void DrawChanceCard()
		{
			Console.WriteLine("Player take a Chance Card");
			Console.WriteLine("U go to in Jail\n");
		}
	}
}
