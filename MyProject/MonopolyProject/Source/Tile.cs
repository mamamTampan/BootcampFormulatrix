namespace MonopolyProject.Source;

public abstract Tile
{
	protected TileType _type;
	protected string _name;
	protected int _location;
	protected string _description;
	
	public GetType()
	{
		TileType
	}
	public string GetName()
	{
		return _name;
	}
	public int GetLocation()
	{
		return _location;
	}
	public string GetDescription()
	{
		return _description;
	}	
}
