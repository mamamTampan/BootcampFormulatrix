namespace MonopolyProject.Source.Interface;

public interface IBalance
{
    int GetBalance();
    bool SetBalance(int balance);
    bool IncreaseBalance(int amount);
    bool DecreaseBalance(int amount);
}

