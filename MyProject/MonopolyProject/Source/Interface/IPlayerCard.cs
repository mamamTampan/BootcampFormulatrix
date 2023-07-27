namespace MonopolyProject.Source.Interface;

public interface IPlayerCard
{
    bool SetKeptCard(ICard card);
    bool UseCard(ICard card);
}
