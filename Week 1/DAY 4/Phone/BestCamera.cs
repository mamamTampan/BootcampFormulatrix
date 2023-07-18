namespace Phone;

public class BestCamera : ICamera
{
	public string camera;
	public BestCamera(string camera)
	{
		this.camera = camera;
	}
	public void	CameraOn()
	{
		Console.WriteLine("Camera On");
	}
}
