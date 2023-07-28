using System.Collections.Generic;

namespace MonopolyProject.Source.Interface;

public interface IProperty
{
	bool AddProperty(); // AddProperty(Dictionary<Tile,KeyValuePair<string,int>>);		
	bool SellProperty(); // SellProperty(Tile property);
	void GetProperty(); // : Dictionary<Tile,KeyValuePair<string,int>>
}