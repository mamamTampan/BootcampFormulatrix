using System.Collections.Generic;

namespace MonopolyProject.Source.Interface;

public interface IProperty
{
	bool AddProperty(Dictionary<Tile,KeyValuePair<string,int>> property);		
	bool SellProperty(Tile property);
	Dictionary<Tile,KeyValuePair<string,int>> GetProperty();
}