namespace MonopolyProject.Source.Interface;

public interface IDice
{
	bool SetDiceSide(int _diceSide);
	int Roll();
	void IsDouble(); // virtual
}
