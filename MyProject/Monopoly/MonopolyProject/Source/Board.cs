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
			tiles.Add(new LandmarkTile("Malaysia", 2,"Price $50"));
			tiles.Add(new CommunityTile("Community Chest", 3,"Take a Community Card"));
			tiles.Add(new LandmarkTile("Thailand", 4,"Price $60"));
			tiles.Add(new TaxTile("Income Tax", 5,"Pay $200"));
			tiles.Add(new PublicPlaceTile("Terminal", 6,"Price $200"));
			tiles.Add(new LandmarkTile("Singapore", 7,""));
			tiles.Add(new ChanceTile("Chance", 8,"Take a Chance Card"));
			tiles.Add(new LandmarkTile("Hongkong", 9,""));
			tiles.Add(new LandmarkTile("India", 10,""));
			tiles.Add(new InJailTile("Jail", 11,"Just Visited"));
			tiles.Add(new LandmarkTile("Saudi Arabia", 12,""));
			tiles.Add(new PublicPlaceTile("Electric Company", 13,""));
			tiles.Add(new LandmarkTile("Mesir", 14,""));
			tiles.Add(new LandmarkTile("Africa", 15,""));
			tiles.Add(new PublicPlaceTile("Station", 16,""));
			tiles.Add(new LandmarkTile("China", 17,""));
			tiles.Add(new CommunityTile("Community Chest", 18,"Take a Community Card"));
			tiles.Add(new LandmarkTile("Korea", 19,""));
			tiles.Add(new LandmarkTile("Japan", 20,""));
			tiles.Add(new FreeParkingTile("Free Parking", 21,"U can enjoy until ur turn"));
			tiles.Add(new LandmarkTile("Finland", 22,""));
			tiles.Add(new ChanceTile("Chance", 23,"Take a Chance Card"));
			tiles.Add(new LandmarkTile("New Zealand", 24,""));
			tiles.Add(new LandmarkTile("Australia", 25,""));
			tiles.Add(new PublicPlaceTile("Port", 26,""));
			tiles.Add(new LandmarkTile("Italy", 27,""));
			tiles.Add(new LandmarkTile("England", 28,""));
			tiles.Add(new PublicPlaceTile("Water Works", 29,""));
			tiles.Add(new LandmarkTile("France", 30,""));
			tiles.Add(new GoToJailTile("Go To Jail", 31,""));
			tiles.Add(new LandmarkTile("Mexico", 32,""));
			tiles.Add(new LandmarkTile("Brazil", 33,""));
			tiles.Add(new CommunityTile("Community Chest", 34,"Take a Community Card"));
			tiles.Add(new LandmarkTile("America", 35,""));
			tiles.Add(new PublicPlaceTile("Airport", 36,""));
			tiles.Add(new ChanceTile("Chance", 37,"Take a Chance Card"));
			tiles.Add(new LandmarkTile("Dubai", 38,""));
			tiles.Add(new TaxTile("Luxury Tax", 39,""));
			tiles.Add(new LandmarkTile("Indonesia ", 40,""));
			return tiles;
		}
	}
}