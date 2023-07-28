namespace MonopolyProject.Source;

public class CommunityCard : Interface.ICard
{
	private CommunityCardType _type;
	private string _description;
	
	public string OpenCard()
	{
		_description = CommunityCardType(_type);
		return _description;
	}
}