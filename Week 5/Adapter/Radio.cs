namespace Adapter;

public interface IRadio
{
    void Play();
}

public class Prambors : IRadio
{
    public void Play()
    {
        Console.WriteLine("Playing Prambors Channel ...");
    }
}

public class HardRock : IRadio
{
    public void Play()
    {
        Console.WriteLine("Playing HardRock Channel ...");
    }
}

public class Rri : IRadio
{
    public void Play()
    {
        Console.WriteLine("Playing RRI Channel ...");
    }
}
