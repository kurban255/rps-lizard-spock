using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    bool isMute;

    void Start()
    {
        if(AudioListener.volume == 0)
        {
            GetComponent<Toggle>().isOn = true;
        }
    }

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }
}
