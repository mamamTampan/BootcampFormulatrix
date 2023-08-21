namespace Adapter;
class Program
{
	static void Main(string[] args)
	{
		List<ISpotify> channel = new List<ISpotify>
		{
			new RadioAdapter(new Prambors()),
			new RadioAdapter(new HardRock()),
			new RadioAdapter(new Rri())
		};

		foreach (var ch in channel)
		{
			ch.PlayChannel();
		}
	}
}
