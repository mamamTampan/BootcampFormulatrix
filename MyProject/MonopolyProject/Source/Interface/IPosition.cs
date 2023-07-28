namespace MonopolyProject.Source.Interface;

public interface IPosition
{
    bool SetPositionToNew(int newPosition);
    bool SetPositionFromDice(int diceValue);
    int? GetPosition();
}
