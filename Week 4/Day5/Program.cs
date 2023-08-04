using System.Runtime.Serialization.DataContracts;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System;


namespace MonopolyProject
{
	[DataContract]
	public class Tile
	{
		[DataMember]
		private int loc {get;set;}
		[DataMember]
		private string name{get;set;}
		[DataMember]
		private string desc{get;set;}
	}
	
		
	
	class Program
	{
		static void Main()
		{
			private List<Tile> tile = new List<Tile>
			{
			new Tile {loc = 1, name = "Start", desc = "$50"},
			new Tile {loc = 2, name = "Malaysia", desc = "$60"},
			new Tile {loc = 3, name = "Community Chest", desc = "Take a Community Card"},
			new Tile {loc = 4, name = "Singapore", desc = "$100"},
			new Tile {loc = 5, name = "Income Tax", desc = "Pay $200"},
			new Tile {loc = 6, name = "Terminal", desc = "$200"},
			new Tile {loc = 7, name = "Taiwan", desc = "$100"},
			new Tile {loc = 8, name = "Chance", desc = "Take a Chance Card"},
			new Tile {loc = 9, name = "Hongkong", desc = "$100"},
			new Tile {loc = 10, name = "China", desc = "$120"},
			new Tile {loc = 11, name = "Jail", desc = "Just Visited"},
			new Tile {loc = 12, name = "Vietnam", desc = "$140"},
			new Tile {loc = 13, name = "Electric Company", desc = "$150"},
			new Tile {loc = 14, name = "Camboja", desc = "$140"},
			new Tile {loc = 15, name = "Thailand", desc = "$160"},
			new Tile {loc = 16, name = "Station", desc = "$200"},
			new Tile {loc = 17, name = "England", desc = "$180"},
			new Tile {loc = 18, name = "Community Chest", desc = "Take a Community Card"},
			new Tile {loc = 19, name = "Finland", desc = "$180"},
			new Tile {loc = 20, name = "Scotland", desc = "$200"},
			new Tile {loc = 21, name = "Free Parking", desc = "Enjoy Here"},
			new Tile {loc = 22, name = "France", desc = "$220"},
			new Tile {loc = 23, name = "Chance", desc = "$Take a Chance Card"},
			new Tile {loc = 24, name = "Italy", desc = "$220"},
			new Tile {loc = 25, name = "Netherland", desc = "$240"},
			new Tile {loc = 26, name = "Port", desc = "$200"},
			new Tile {loc = 27, name = "Australia", desc = "$260"},
			new Tile {loc = 28, name = "New Zealand", desc = "$260"},
			new Tile {loc = 29, name = "Water Works", desc = "$150"},
			new Tile {loc = 30, name = "Swiss", desc = "$280"},
			new Tile {loc = 31, name = "Go to Jail", desc = "Stay in Jail Now"},
			new Tile {loc = 32, name = "Brazil", desc = "$300"},
			new Tile {loc = 33, name = "Argentina", desc = "$300"},
			new Tile {loc = 34, name = "Community Chest", desc = "Take a Community Card"},
			new Tile {loc = 35, name = "USA", desc = "$320"},
			new Tile {loc = 36, name = "Airport", desc = "$200"},
			new Tile {loc = 37, name = "Chance", desc = "$Take a Chance Card"},
			new Tile {loc = 38, name = "Africa", desc = "$350"},
			new Tile {loc = 39, name = "Luxury Tax", desc = "Pay $100"},
			new Tile {loc = 40, name = "Indonesia", desc = "$400"}
			};
		
			var ser = new DataContractSerializer(typeof(List<Tile>));		
			using (FileStream stream = new FileStream("Tile.xml",FileMode.OpenOrCreate))
			{
				
			}
			List<Tile> import = (List<Tile>)serializer.Deserialize(reader);
			foreach (var Tile in import)
				{
					Console.WriteLine($"Tile : {Tile.loc}\t| {Tile.name}, {Tile.desc}");
				}
			}
		}
	}
}