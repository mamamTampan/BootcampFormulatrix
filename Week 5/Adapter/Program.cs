namespace Adapter;
class Program
{
	static void Main(string[] args)
	{
		List<ISpotify> play = new List<ISpotify>
		{
			new Spotify(new Prambors(), new Dangdut()),
			new Spotify(new HardRock(), new Hardcore()),
			new Spotify(new Rri(), new Jazz())
		};
		foreach (var p in play)
		{
			p.Play();
		}
	}
}






/*
 public static class CurrencyExtensions
	{
		public static string ToCurrencyString(this int amount)
		{
			return $"${amount:N2}";
		}
		
		int price = 1000;
		string formattedPrice = price.ToCurrencyString();
		Console.WriteLine($"Formatted price: {formattedPrice}");
	}
*/