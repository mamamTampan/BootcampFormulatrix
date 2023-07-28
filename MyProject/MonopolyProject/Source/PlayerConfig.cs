namespace MonopolyProject.Source;

public class PlayerConfig : Interface.IPlayerConfig
{
	private PieceType _pieceColor = new PieceType;
	private int _position;
	private int _balance;
	private bool _isInJail;
	private Interface.ICard _keptCard;
	private Dictionary<Tile,KeyValuePair<string,int>> _propertyMap = new Dictionary<Tile,KeyValuePair<string,int>>();

}