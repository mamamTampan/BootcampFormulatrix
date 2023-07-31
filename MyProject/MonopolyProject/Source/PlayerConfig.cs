using MonopolyProject.Source.Interface;
namespace MonopolyProject.Source;

	public interface IPlayerConfig : IPlayerCard, IProperty, IJail, IBalance, IPosition, IPiece{}

	public class PlayerConfig : IPlayerConfig
	{
		private PieceType _pieceColor;
		private int _position;
		private int _balance;
		private bool _isInJail;
		private ICard _keptCard;
		private Dictionary<Tile, KeyValuePair<string, int>> _property;
		public bool SetPiece(PieceType pieceType)
		{
			_pieceColor = pieceType;
			return true;
		}
		public PieceType GetPiece()
		{
			return _pieceColor;
		}
		public bool SetPositionToNew(int newPosition)
		{
			_position = newPosition;
			return true;
		}
		public bool SetPositionFromDice(int diceValue)
		{
			_position += diceValue;
			return true;
		}
		public int GetPosition()
		{
			return _position;
		}
		public bool SetBalance(int balance)
		{
			_balance = balance;
			return true;
		}
		public int GetBalance()
		{
			return _balance;
		}
		public bool IncreaseBalance(int incBalance)
		{
			_balance += incBalance;
			return true;
		}
		public bool DecreaseBalance(int decBalance)
		{
			_balance -= decBalance;
			return true;
		}
		public bool GoToJail()
		{
			_isInJail = true;
			return true;
		}
		public bool IsInJail()
		{
			return _isInJail;
		}
		public bool SetKeptCard(ICard card)
		{
			_keptCard = card;
			return true;
		}
		public bool UseCard(ICard card)
		{
			return true;
		}
		public bool AddProperty(Dictionary<Tile, KeyValuePair<string, int>> properties)
		{
			_property = properties;
			return true;
		}
		public bool SellProperty(Tile property)
		{
			return true;
		}
		public Dictionary<Tile, KeyValuePair<string, int>> GetProperty()
		{
			return _property;
		}
		public string OpenCard()
		{
			return "??????";
		}
	}