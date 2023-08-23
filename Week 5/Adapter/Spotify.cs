namespace Adapter;

public interface ISpotify
{
	void Play();
}

public class Spotify : ISpotify
{
	private readonly IRadio _radio;
	private readonly IMusic _music;

	public Spotify(IRadio radio, IMusic music)
	{
		_radio = radio;
		_music = music;
	}

	public void Play()
	{
		_radio.PlayChannel();
		_music.PlayMusic();
	}
}
