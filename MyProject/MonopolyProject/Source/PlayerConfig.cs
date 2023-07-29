namespace MonopolyProject.Source;

public class PlayerConfig : Interface.IPlayerConfig
{
	private PieceType _pieceColor;
	private int _position;
	private int _balance;
	private bool _isInJail;
	private Interface.ICard _keptCard;
	private Dictionary<Tile,KeyValuePair<string,int>> _propertyMap = new Dictionary<Tile,KeyValuePair<string,int>>();

	public bool SetKeptCard(ICard card)
	{
		if (_keptCard == card)
		{
			_keptCard = card;
			return true; 
		}
	}
	public bool UseCard(ICard card)
	{
		return card;
	}
	

}
