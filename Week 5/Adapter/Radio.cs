namespace Adapter;

public interface IRadio
{
    void Play();
}

public class Piano : IRadio
{
    public void Play()
    {
        Console.WriteLine("Playing the piano...");
    }
}

public class Guitar : IRadio
{
    public void Play()
    {
        Console.WriteLine("Playing the violin...");
    }
}

public class Drum : IRadio
{
    public void Play()
    {
        Console.WriteLine("Playing the flute...");
    }
}
