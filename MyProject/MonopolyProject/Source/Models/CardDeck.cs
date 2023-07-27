namespace MonopolyProject.Source.Models;

public class CardDeck
{
	private Stack<ChanceCard> chanceDeck = new Stack<ChanceCard>();
	private Stack<CommunityCard> commDeck = new Stack<CommunityCard>();
	
	public ShuffleCard(Stack<ChanceCard> chanceDeck, Stack<CommunityCard> commDeck)
	{
		
	}
}
