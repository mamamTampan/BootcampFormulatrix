using System.Collections.Generic;

namespace MonopolyProject.Source.Interface;

public interface IProperty
{
	bool AddProperty(Dictionary<Tile,KeyValuePair<string,int>>);		
	bool SellProperty(Tile property);
	Dictionary<Source.Tile,KeyValuePair<string,int>> GetProperty();
}