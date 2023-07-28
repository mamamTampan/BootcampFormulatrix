namespace MonopolyProject.Source.Interface;

public interface IBalance
{
    int GetBalance();
    bool SetBalance(int setBalance);
    bool IncreaseBalance(int incBalance);
    bool DecreaseBalance(int decBalance);
}

