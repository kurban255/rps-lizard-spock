using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Gameplay gameplay;

    public void UpdateGUI()
    {
        gameplay.livesText.text = gameplay.currentLives.ToString();
        gameplay.scoreText.text = gameplay.currentScore.ToString();
    }
}
