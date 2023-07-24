public interface Ikicau
{
	void kicau();
}
public interface Isayap
{
	void sayap();
}
public interface Icorak
{
	void corak();
}
public class Burung : Ikicau , Isayap, Icorak
{
	public Burung()
	{
		Console.WriteLine("Burung");
	}
	public void kicau()
	{
		Console.WriteLine("Berkicau");
	}
	public virtual void sayap()
	{
		Console.WriteLine("Bersayap");
	}
	public void corak()
	{
		Console.WriteLine("Bercorak");
	}
	
}
public class BurungMahal : Burung, Ikicau, Isayap, Icorak
{
	public BurungMahal()
	{
		Console.WriteLine("Burung Mahal");
	}
	public new void kicau()
	{
		Console.WriteLine("Berkicau Indah");
	}
	public override void sayap()
	{
		Console.WriteLine("Bersayap Indah");
	}
	public new void corak()
	{
		Console.WriteLine("Bercorak Indah");
	}
public string Panjang { get; set; }
public string panjang;

public string name;
private string _name;
public bool setJenis(string name) 
{
	if (name != null) 
	{
		_name = name;
		return true;
	}
	return false;
}
}
