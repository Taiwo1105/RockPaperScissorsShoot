using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum RPSChoice { None, Rock, Paper, Scissors }

public class RPSGameController : MonoBehaviour
{
    [Header("UI")]
    public Image playerChoiceImage;
    public Image computerChoiceImage;
    public TextMeshProUGUI resultText;
    public Button shootButton, replayButton;

    [Header("Buttons")]
    public Button rockButton;
    public Button paperButton;
    public Button scissorsButton;

    [Header("Sprites")]
    public SpriteManager spriteManager;

    private RPSChoice playerChoice = RPSChoice.None;
    private RPSChoice computerChoice = RPSChoice.None;
    private bool hasPlayed = false;

    void Start()
    {
        shootButton.interactable = false;
        replayButton.gameObject.SetActive(false);
        ClearImages();
    }

    public void OnPlayerSelect(int index)
    {
        if (hasPlayed) return;

        playerChoice = (RPSChoice)index;
        playerChoiceImage.sprite = spriteManager.GetSprite(playerChoice);
        shootButton.interactable = true;
    }

    public void OnShoot()
    {
        if (playerChoice == RPSChoice.None || hasPlayed) return;

        // Generate computer choice
        computerChoice = (RPSChoice)Random.Range(1, 4);
        computerChoiceImage.sprite = spriteManager.GetSprite(computerChoice);
        Debug.Log($"Computer choice generated: {computerChoice}");


        resultText.text = $"Result: {GetResult()}";
        hasPlayed = true;

        DisableChoiceButtons();
        replayButton.gameObject.SetActive(true);
        shootButton.interactable = false;
    }

    public void OnReplay()
    {
        playerChoice = RPSChoice.None;
        computerChoice = RPSChoice.None;
        hasPlayed = false;
        resultText.text = "";
        ClearImages();
        EnableChoiceButtons();
        replayButton.gameObject.SetActive(false);
    }

    string GetResult()
    {
        if (playerChoice == computerChoice) return "Draw!";

        IChoiceStrategy playerStrategy = ChoiceStrategyFactory.Create(playerChoice);
        IChoiceStrategy computerStrategy = ChoiceStrategyFactory.Create(computerChoice);

        if (playerStrategy.Beats(computerStrategy))
            return "You Win!";
        else
            return "You Lose!";
    }


    void DisableChoiceButtons()
    {
        rockButton.interactable = false;
        paperButton.interactable = false;
        scissorsButton.interactable = false;
    }

    void EnableChoiceButtons()
    {
        rockButton.interactable = true;
        paperButton.interactable = true;
        scissorsButton.interactable = true;
    }

    void ClearImages()
    {
        playerChoiceImage.sprite = null;
        computerChoiceImage.sprite = null;
    }
}
