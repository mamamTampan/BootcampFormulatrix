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

public class Violin : IRadio
{
    public void Play()
    {
        Console.WriteLine("Playing the violin...");
    }
}

public class Flute : IRadio
{
    public void Play()
    {
        Console.WriteLine("Playing the flute...");
    }
}
