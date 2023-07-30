namespace MonopolyProject.Source.Tiles;

public class BonusTile : Tile
{
	private int _amountBonus;

	public BonusTile(string name, int location, string description)
	{
		this._type = TileType.BONUS;
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
	public int GetAmount()
	{
		return _amountBonus;
	}
}
