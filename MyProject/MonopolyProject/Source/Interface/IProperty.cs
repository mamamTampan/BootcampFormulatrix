namespace MonopolyProject.Source.Interface;

using System.Collections.Generic;

public interface IProperty
{
    bool AddProperty(Dictionary<Tile, int> property);
    bool SellProperty(Tile property);
    Dictionary<Tile, int> GetProperty();
}
