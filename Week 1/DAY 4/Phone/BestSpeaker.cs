namespace Phone;

public class BestSpeaker : ISpeaker
{
	public string speaker;
	public BestSpeaker(string speaker)
	{
		this.speaker = speaker;
	}
	public void	SpeakerOn()
	{
		Console.WriteLine("Speaker On");
	}
}
