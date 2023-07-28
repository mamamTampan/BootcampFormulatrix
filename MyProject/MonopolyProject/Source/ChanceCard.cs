namespace MonopolyProject.Source;

public class ChanceCard : Interface.ICard
{
	private ChanceCardType _type;
	private string _description;
	
	public string OpenCard()
	{
		_description = CommunityCardType(_type);
		return _description;
	}
}
