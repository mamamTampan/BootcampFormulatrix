using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace MonopolyProject
{
	[DataContract]
	public class Tile
	{
		[DataMember]
		internal int Location { get; private set; }

		[DataMember]
		public string Names { get; private set; }

		[DataMember]
		public string Description { get; private set; }
		
		public Tile(int location, string names, string description)
		{
			Location = location;
			Names = names;
			Description = description;
		}
	}

	class Program
	{
		static void Main()
		{
			List<Tile> tiles = new List<Tile>
			{
				new Tile (1,"Start","$50"),
				new Tile (2,"Malaysia","$60"),
				new Tile (3,"Community Chest","Take a Community Card"),
				new Tile (4,"Singapore","$100"),
				new Tile (5,"Income Tax","Pay $200"),
				new Tile (6,"Terminal","$200"),
				new Tile (7,"Taiwan","$100"),
				new Tile (8,"Chance","Take a Chance Card"),
				new Tile (9,"Hongkong","$100"),
				new Tile (10,"China","$120"),
				new Tile (11,"Jail","Just Visited"),
				new Tile (12,"Vietnam","$140"),
				new Tile (13,"Electric Company","$150"),
				new Tile (14,"Camboja","$140"),
				new Tile (15,"Thailand","$160"),
				new Tile (16,"Station","$200"),
				new Tile (17,"England","$180"),
				new Tile (18,"Community Chest","Take a Community Card"),
				new Tile (19,"Finland","$180"),
				new Tile (20,"Scotland","$200"),
				new Tile (21,"Free Parking","Enjoy Here"),
				new Tile (22,"France","$220"),
				new Tile (23,"Chance","$Take a Chance Card"),
				new Tile (24,"Italy","$220"),
				new Tile (25,"Netherland","$240"),
				new Tile (26,"Port","$200"),
				new Tile (27,"Australia","$260"),
				new Tile (28,"New Zealand","$260"),
				new Tile (29,"Water Works","$150"),
				new Tile (30,"Swiss","$280"),
				new Tile (31,"Go to Jail","Stay in Jail Now"),
				new Tile (32,"Brazil","$300"),
				new Tile (33,"Argentina","$300"),
				new Tile (34,"Community Chest","Take a Community Card"),
				new Tile (35,"USA","$320"),
				new Tile (36,"Airport","$200"),
				new Tile (37,"Chance","$Take a Chance Card"),
				new Tile (38,"Africa","$350"),
				new Tile (39,"Luxury Tax","Pay $100"),
				new Tile (40,"Indonesia","$400")
			};

			using (FileStream stream = new FileStream("Tile.xml", FileMode.Create))
			{
				DataContractSerializer serializer = new DataContractSerializer(typeof(List<Tile>));
				serializer.WriteObject(stream, tiles);
			}
			List<Tile> importedTiles;
			using (FileStream stream = new FileStream("Tile.xml", FileMode.Open))
			{
				DataContractSerializer serializer = new DataContractSerializer(typeof(List<Tile>));
				importedTiles = (List<Tile>)serializer.ReadObject(stream);
			}
			Console.WriteLine("Tiles:");
			foreach (var tile in importedTiles)
			{
				Console.WriteLine($"Tile: {tile.Location},\nName: {tile.Names},    Description: {tile.Description}");
			}
		}
	}
}
