using MonopolyProject.Source.Interface;
namespace MonopolyProject.Source;

public class MonopolyGame : IPlayer, IDice
{
	Board board;
	GameStatus gameStatus;
	List<IDice> dices;
	CardDeck cardDeck;
	IPlayer currentPlayer;
	Dictionary<IPlayer,PlayerConfig> playerSet;
	List<IPlayer> TurnsOrder;
	public int diceSide;
	public int diceDoubleCount;
	
	public void CheckGameStatus()
	{
		return GameStatus;
	}
}
