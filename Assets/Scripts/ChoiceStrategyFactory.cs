using UnityEngine;

// ChoiceStrategyFactory.cs
public static class ChoiceStrategyFactory
{
    public static IChoiceStrategy Create(RPSChoice choice)
    {
        return choice switch
        {
            RPSChoice.Rock => new RockStrategy(),
            RPSChoice.Paper => new PaperStrategy(),
            RPSChoice.Scissors => new ScissorsStrategy(),
            _ => null,
        };
    }
}

