using MonopolyProject.Source.Interface;
namespace MonopolyProject.Source;

public class HumanPlayer : IPlayer
{
	private int _id;
	private string? _name;
	public bool SetName(string name)
	{
		if (name.Length >= 3 )
		{
			_name = name;
			return true;
		}
		else
		{
			return false;
		}
	}
	public string? GetName()
	{
		return _name;
	}
	public bool SetId(int id)
	{
		if (id > 0)
		{
			_id = id;
			return true;
		}
		else
		{
			return false;
		}
	}
	public int GetId()
	{
		return _id;
	}
}
