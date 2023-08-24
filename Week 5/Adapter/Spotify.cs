namespace Adapter;

public interface ISpotify
{
	void Play();
}

public class AdapterRadio : ISpotify
{
	private readonly IRadio _radio;

	public AdapterRadio(IRadio radio)
	{
		_radio = radio;
	}

	public void Play()
	{
		_radio.PlayChannel();
	}
}

public class AdapterMusic : ISpotify
{
	private readonly IMusic _music;

	public AdapterMusic(IMusic music)
	{
		_music = music;
	}

	public void Play()
	{
		_music.PlayMusic();
	}
}
