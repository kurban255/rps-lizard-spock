using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public AudioListener myAudioListener;
    public Sprite[] newIcon;
    public Image currentIcon;

    public void Start()
    {
        myAudioListener = FindObjectOfType<AudioListener>();

        if (myAudioListener.enabled == false)
        {
            currentIcon.sprite = newIcon[0];
        }
    }

    public void ToggleSound()
    {
        if (myAudioListener.enabled)
        {
            myAudioListener.enabled = false;
            currentIcon.sprite = newIcon[0];
        }
        else
        {
            myAudioListener.enabled = true;
            currentIcon.sprite = newIcon[1];
        }
    }
}
