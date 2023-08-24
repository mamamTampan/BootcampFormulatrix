namespace Adapter;
class Program
{
	static void Main(string[] args)
	{
		List<ISpotify> play = new List<ISpotify>
		{
			new AdapterRadio(new Prambors()),
			new AdapterRadio(new HardRock()),
			new AdapterRadio(new Rri()),
			new AdapterMusic( new Dangdut()),
			new AdapterMusic( new Hardcore()),
			new AdapterMusic( new Jazz())
		};
		foreach (var p in play)
		{
			p.Play();
		}
	}
}










/*
//Extension Method
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