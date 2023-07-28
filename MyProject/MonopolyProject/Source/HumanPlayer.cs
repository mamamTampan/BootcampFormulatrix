namespace MonopolyProject.Source;

public class HumanPlayer : Interface.IPlayer
{
	private int _id;
	private string? _name;
	public bool SetName(string name)
	{
		if (name.Length >= 3 )
		{
			return false;
		}
		_name = name;
		return true;
	}
	public string GetName()
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
