namespace Adapter;

public interface IRadio
{
    void PlayChannel();
}

public class Prambors : IRadio
{
    public void PlayChannel()
    {
        Console.WriteLine("Playing Prambors Channel...");
    }
}

public class HardRock : IRadio
{
    public void PlayChannel()
    {
        Console.WriteLine("Playing HardRock Channel ...");
    }
}

public class Rri : IRadio
{
    public void PlayChannel()
    {
        Console.WriteLine("Playing RRI Channel ...");
    }
}
