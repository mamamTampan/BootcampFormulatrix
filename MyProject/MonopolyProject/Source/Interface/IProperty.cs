using System.Collections.Generic;

namespace MonopolyProject.Source.Interface;

public interface IProperty
{
	bool AddProperty(Dictionary<Tile, int> property);
	bool SellProperty(Tile property);
	Dictionary<Tile, int> GetProperty();
}
