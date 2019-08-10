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
    readonly int rock = 0;
    readonly int paper = 1;
    readonly int scissors = 2;
    readonly int lizard = 3;
    readonly int spock = 4;
    readonly string scissorsCutsPaper = "Scissors cuts Paper";
    readonly string paperCoversRock = "Paper covers Rock";
    readonly string rockCrushesLizard = "Rock crushes Lizard";
    readonly string lizardPoisonsSpock = "Lizard poisons Spock";
    readonly string spockSmashesScissors = "Spock smashes Scissors";
    readonly string scissorsDecapitatesLizard = "Scissors decapitates Lizard";
    readonly string lizardEatsPaper = "Lizard eats Paper";
    readonly string paperDisprovesSpock = "Paper disproves Spock";
    readonly string spockVaporizesRock = "Spock vaporizes Rock";
    readonly string rockCrushesScissors = "Rock crushes Scissors";

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
        PlayGame(rock, scissors, lizard, paper, spock, rockCrushesScissors, rockCrushesLizard, paperCoversRock, spockVaporizesRock);
    }

    public void OnPressPaper()
    {
        PlayGame(paper, rock, spock, scissors, lizard, paperCoversRock, paperDisprovesSpock, scissorsCutsPaper, lizardEatsPaper);
    }

    public void OnPressScissors()
    {
        PlayGame(scissors, paper, lizard, rock, spock, scissorsCutsPaper, scissorsDecapitatesLizard, rockCrushesScissors, spockSmashesScissors);
    }

    public void OnPressLizard()
    {
        PlayGame(lizard, paper, spock, rock, scissors, lizardEatsPaper, lizardPoisonsSpock, rockCrushesLizard, scissorsDecapitatesLizard);
    }

    public void OnPressSpock()
    {
        PlayGame(spock, rock, scissors, paper, lizard, spockVaporizesRock, spockSmashesScissors, paperDisprovesSpock, lizardPoisonsSpock);
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
            resultDescription.text = "Try again";
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
