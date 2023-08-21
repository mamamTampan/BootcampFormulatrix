namespace Adapter;

public interface ISpotify
{
    void PlayChannel();
}

public class RadioAdapter : ISpotify
{
    private readonly IRadio _radio;

    public RadioAdapter(IRadio radio)
    {
        _radio = radio;
    }

    public void PlayChannel()
    {
        _radio.Play();
    }
}
