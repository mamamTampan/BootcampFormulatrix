namespace MonopolyProject.Source;

public abstract class Tile
{
	protected TileType _type;
	protected string _name;
	protected int _location;
	protected string _description;
	
	public abstract TileType GetType();
	public abstract string GetName();
	public abstract int GetLocation();
	public abstract string GetDescription();
}