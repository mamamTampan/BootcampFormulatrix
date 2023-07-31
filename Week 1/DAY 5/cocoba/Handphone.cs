namespace Handphone;
public class Handphone<T>
{
    private readonly T hp;

	public Handphone(T a)
	{
		hp = a;
	}

	public T HandphoneMethod(T tipe)
	{
		Console.WriteLine($"Handphone : {hp}");
		Console.WriteLine($"Tipe : {tipe}");

		return tipe;
	}
}