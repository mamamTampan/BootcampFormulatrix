using IPhone;
namespace Phone;

public class BestCamera : ICamera
{
	public string _camera;
	public BestCamera(string camera)
	{
		this._camera = camera;
	}
	public void	CameraOn()
	{
		Console.WriteLine("Camera On");
	}
}
