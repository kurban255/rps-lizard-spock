using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    // Config params
    [SerializeField] public int scoreIncrement;
    [SerializeField] public int startingLives;
    [SerializeField] public Text result;
    [SerializeField] public Text resultDescription;
    [SerializeField] public Text myPick;
    [SerializeField] public Text enemyPick;
    [SerializeField] public Text livesText;
    [SerializeField] public Text scoreText;
    [SerializeField] public Sprite[] pickImages;
    [SerializeField] public Image myPickImage;
    [SerializeField] public Image enemyPickImage;

    // State
    int draw;
    string[] pick = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
    int lives;
    int score;

    // Cached component references
    

    public void Start()
    {
        lives = startingLives;
        score = 0;

        livesText.text = lives.ToString();
        scoreText.text = score.ToString();
    }

    public void OnPressRock()
    {
        PlayGame(0, 2, 3, 1, 4, "Rock crushes Scissors", "Rock crushes Lizard", "Paper covers Rock", "Spock vaporizes Rock");
    }

    public void OnPressPaper()
    {
        PlayGame(1, 0, 4, 2, 3, "Paper covers Rock", "Paper disproves Spock", "Scissors cuts Paper", "Lizard eats Paper");
    }

    public void OnPressScissors()
    {
        PlayGame(2, 1, 3, 0, 4, "Scissors cuts Paper", "Scissors decapitates Lizard", "Rock crushes Scissors", "Spock smashes Scissors");
    }

    public void OnPressLizard()
    {
        PlayGame(3, 1, 4, 0, 2, "Lizard eats Paper", "Lizard poisons Spock", "Rock crushes Lizard", "Scissors decapitates Lizard");
    }

    public void OnPressSpock()
    {
        PlayGame(4, 0, 2, 1, 3, "Spock vaporizes Rock", "Spock smashes Scissors", "Paper disproves Spock", "Lizard poisons Spock");
    }

    public void PlayGame(int whatPicked, int winOne, int winTwo, int loseOne, int loseTwo, string winDescOne, string winDescTwo, string loseDescOne, string loseDescTwo)
    {
        myPick.text = pick[whatPicked];
        myPickImage.sprite = pickImages[whatPicked];
        draw = Random.Range(0, pick.Length);
        enemyPick.text = pick[draw];
        enemyPickImage.sprite = pickImages[draw];

        if (enemyPick.text == pick[winOne])
        {
            YouWin(winDescOne);
        }
        else if (enemyPick.text == pick[winTwo])
        {
            YouWin(winDescTwo);
        }
        else if (enemyPick.text == pick[loseOne])
        {
            YouLose(loseDescOne);
        }
        else if (enemyPick.text == pick[loseTwo])
        {
            YouLose(loseDescTwo);
        }
        else
        {
            result.text = "Tie!";
            resultDescription.text = "Play again";
        }
    }

    public void YouWin(string descriptionText)
    {
        result.text = "You win!";
        resultDescription.text = descriptionText;
        score = score + scoreIncrement;
        scoreText.text = score.ToString();
    }

    public void YouLose(string descriptionText)
    {
        result.text = "You lose!";
        resultDescription.text = descriptionText;
        lives--;
        livesText.text = lives.ToString();
    }
}
