using System.Collections.Generic;
using MonopolyProject.Source.Tiles;

namespace MonopolyProject.Source
{
	public class Board
	{
		private List<Tile> tiles = new List<Tile>();
		public List<Tile> CreatingBoard()
		{
			tiles.Add(new StartTile("GO !!!", 1,"Collect $200 for salary"));
			tiles.Add(new LandmarkTile("", 2,""));
			tiles.Add(new CommunityTile("Community Chest", 3,"Take a Community Card"));
			tiles.Add(new LandmarkTile("", 4,""));
			tiles.Add(new TaxTile("Income Tax", 5,""));
			tiles.Add(new PublicPlaceTile("Terminal", 6,""));
			tiles.Add(new LandmarkTile("", 7,""));
			tiles.Add(new ChanceTile("Chance", 8,"Take a Chance Card"));
			tiles.Add(new LandmarkTile("", 9,""));
			tiles.Add(new LandmarkTile("", 10,""));
			tiles.Add(new InJailTile("Jail", 11,""));
			tiles.Add(new LandmarkTile("", 12,""));
			tiles.Add(new PublicPlaceTile("Electric Company", 13,""));
			tiles.Add(new LandmarkTile("", 14,""));
			tiles.Add(new LandmarkTile("", 15,""));
			tiles.Add(new PublicPlaceTile("Station", 16,""));
			tiles.Add(new LandmarkTile("", 17,""));
			tiles.Add(new CommunityTile("Community Chest", 18,"Take a Community Card"));
			tiles.Add(new LandmarkTile("", 19,""));
			tiles.Add(new LandmarkTile("", 20,""));
			tiles.Add(new FreeParkingTile("Free Parking", 21,"U can enjoy until ur turn"));
			tiles.Add(new LandmarkTile("", 22,""));
			tiles.Add(new ChanceTile("Chance", 23,"Take a Chance Card"));
			tiles.Add(new LandmarkTile("", 24,""));
			tiles.Add(new LandmarkTile("", 25,""));
			tiles.Add(new PublicPlaceTile("Port", 26,""));
			tiles.Add(new LandmarkTile("", 27,""));
			tiles.Add(new LandmarkTile("", 28,""));
			tiles.Add(new PublicPlaceTile("Water Works", 29,""));
			tiles.Add(new LandmarkTile("", 30,""));
			tiles.Add(new GoToJailTile("Go To Jail", 31,""));
			tiles.Add(new LandmarkTile("", 32,""));
			tiles.Add(new LandmarkTile("", 33,""));
			tiles.Add(new CommunityTile("Community Chest", 34,"Take a Community Card"));
			tiles.Add(new LandmarkTile("", 35,""));
			tiles.Add(new PublicPlaceTile("Airport", 36,""));
			tiles.Add(new ChanceTile("Chance", 37,"Take a Chance Card"));
			tiles.Add(new LandmarkTile("", 38,""));
			tiles.Add(new TaxTile("Luxury Tax", 39,""));
			tiles.Add(new LandmarkTile("", 40,""));
			return tiles;
		}
	}
}