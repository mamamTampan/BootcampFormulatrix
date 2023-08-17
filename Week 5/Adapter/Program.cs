namespace Adapter;
class Program
{
	static void Main(string[] args)
	{
		List<ISpotify> musicPlayers = new List<ISpotify>
		{
			new RadioAdapter(new Piano()),
			new RadioAdapter(new Guitar()),
			new RadioAdapter(new Drum())
		};

		foreach (var musicPlayer in musicPlayers)
		{
			musicPlayer.PlayMusic();
		}
	}
}
