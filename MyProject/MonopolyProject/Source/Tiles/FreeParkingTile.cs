namespace MonopolyProject.Source.Tiles;

public class FreeParkingTile : Tile
{
	public FreeParkingTile(string name, int location, string description)
	{
		this._type = TileType.FREE_PARKING;
		this._name = name;
		this._location = location;
		this._description = description;
	}
	public override TileType GetType()
    {
        return _type;
    }
    public override string GetName()
    {
        return _name;
    }
    public override int GetLocation()
    {
        return _location;
    }
    public override string GetDescription()
    {
        return _description;
    }
}