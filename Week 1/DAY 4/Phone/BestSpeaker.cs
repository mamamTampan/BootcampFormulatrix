using IPhone;
namespace Phone;

public class BestSpeaker : ISpeaker
{
	public string _speaker;
	public BestSpeaker(string speaker)
	{
		this._speaker = speaker;
	}
	public void	SpeakerOn()
	{
		Console.WriteLine("Speaker On");
	}
}
