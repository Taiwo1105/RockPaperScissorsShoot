// IChoiceStrategy.cs
public interface IChoiceStrategy
{
    bool Beats(IChoiceStrategy other);
    RPSChoice GetChoice();
}
// RockStrategy.cs
public class RockStrategy : IChoiceStrategy
{
    public bool Beats(IChoiceStrategy other) => other.GetChoice() == RPSChoice.Scissors;
    public RPSChoice GetChoice() => RPSChoice.Rock;
}

// PaperStrategy.cs
public class PaperStrategy : IChoiceStrategy
{
    public bool Beats(IChoiceStrategy other) => other.GetChoice() == RPSChoice.Rock;
    public RPSChoice GetChoice() => RPSChoice.Paper;
}

// ScissorsStrategy.cs
public class ScissorsStrategy : IChoiceStrategy
{
    public bool Beats(IChoiceStrategy other) => other.GetChoice() == RPSChoice.Paper;
    public RPSChoice GetChoice() => RPSChoice.Scissors;
}

