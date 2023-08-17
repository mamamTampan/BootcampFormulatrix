namespace Adapter;

public interface ISpotify
{
    void PlayMusic();
}

public class RadioAdapter : ISpotify
{
    private readonly IRadio _radio;

    public RadioAdapter(IRadio radio)
    {
        _radio = radio;
    }

    public void PlayMusic()
    {
        _radio.Play();
    }
}
