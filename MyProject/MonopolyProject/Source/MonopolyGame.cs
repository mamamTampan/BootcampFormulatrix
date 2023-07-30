using System;
using System.Collections.Generic;
using MonopolyProject.Source.Interface;

namespace MonopolyProject.Source;

	public class MonopolyGame
	{
		private Board board;
		private GameStatus gameStatus;
		private List<IDice> dices;
		private CardDeck cardDeck;
		private IPlayer currentPlayer;
		private Dictionary<IPlayer, PlayerConfig> playerSet;
		private List<IPlayer> TurnsOrder;
		private int diceSide;
		private int diceDoubleCount;

		public GameStatus CheckGameStatus()
		{
			return gameStatus;
		}

		public bool AddPlayer(IPlayer player)
		{
			return true;
		}

		public List<IPlayer> GetPlayers()
		{
			return new List<IPlayer>();
		}

		public bool SetInitialState()
		{
			return true;
		}

		public void SetTurnsOrder()
		{
		}

		public IPlayer GetCurrentTurn()
		{
			return currentPlayer;
		}

		public int ThrowDices()
		{
			return 0;
		}

		public int ThrowDices(int index)
		{
			return 0;
		}

		public bool Move(IPlayer player, int step)
		{
			return true;
		}

		public int CheckPlayerPosition(IPlayer player)
		{
			return 0;
		}

		public int CheckPlayerBalance(IPlayer player)
		{
			return 0;
		}

		public Dictionary<Tile, KeyValuePair<string, int>> CheckPlayerProperties(IPlayer player)
		{
			return new Dictionary<Tile, KeyValuePair<string, int>>();
		}

		public bool SetToJail(IPlayer player)
		{
			return true;
		}

		public bool GrantRegular(IPlayer player)
		{
			return true;
		}

		public bool GrantBonus(IPlayer player)
		{
			return true;
		}

		public ICard TakeChanceCard()
		{
			return new ChanceCard();
		}

		public ICard TakeCommCard()
		{
			return new CommunityCard();
		}

		public bool ExecuteCard(ICard card)
		{
			return true;
		}

		public bool SetCardToPlayer(ICard card, IPlayer player)
		{
			return true;
		}

		public TransactionStatus TakeTax(IPlayer player, Tile tile)
		{
			return TransactionStatus.Success;
		}

		public TransactionStatus PlayerBuyLandmark(IPlayer player, Tile tile)
		{
			return TransactionStatus.Success;
		}

		public TransactionStatus PlayerPayRent(IPlayer playerRent, Tile tile)
		{
			return TransactionStatus.Success;
		}

		public TransactionStatus PlayerPayResource(IPlayer player, Tile tile)
		{
			return TransactionStatus.Success;
		}

		public TransactionStatus PlayerBuyHouse(IPlayer player, Tile tile)
		{
			return TransactionStatus.Success;
		}

		public TransactionStatus PlayerBuyHotel(IPlayer player, Tile tile)
		{
			return TransactionStatus.Success;
		}

		public TransactionStatus PlayerSellLandmark(IPlayer player, Tile tile)
		{
			return TransactionStatus.Success;
		}

		public bool SetNextTurn()
		{
			return true;
		}

		public IPlayer CheckRichest()
		{
			return new Player();
		}

		public IPlayer CheckWinner()
		{
			return new Player();
		}
   
	}