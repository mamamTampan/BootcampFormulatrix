using System.Reflection.Metadata.Ecma335;

namespace MonopolyProject.Source;

public class CommunityCard : Interface.ICard
{
	private readonly CommunityCardType _type;
	private string _description;
	
	public string OpenCard()
	{
		_description = CommunityCardType(_type);
		return _description;
	}
}
