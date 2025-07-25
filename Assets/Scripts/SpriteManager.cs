using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public Sprite rockSprite;
    public Sprite paperSprite;
    public Sprite scissorsSprite;

    public Sprite GetSprite(RPSChoice choice)
    {
        switch (choice)
        {
            case RPSChoice.Rock: return rockSprite;
            case RPSChoice.Paper: return paperSprite;
            case RPSChoice.Scissors: return scissorsSprite;
            default: return null;
        }
    }
}
