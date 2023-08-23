namespace Adapter;

public interface IMusic
{
	void PlayMusic();
}

public class Dangdut : IMusic

{
	public void PlayMusic()
	{
		Console.WriteLine("Playing Dangdut Music ...");
	}
}

public class Hardcore : IMusic
{
	public void PlayMusic()
	{
		Console.WriteLine("Playing Hardcore Music ...");
	}
}

public class Jazz : IMusic
{
	public void PlayMusic()
	{
		Console.WriteLine("Playing Jazz Music ...");
	}
}
