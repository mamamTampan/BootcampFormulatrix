namespace MonopolyProject.Source.Interface;

public interface IPlayerCard : ICard
{
    bool SetKeptCard(ICard card);
    bool UseCard(ICard card);
}
