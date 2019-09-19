using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    //public AudioListener al;
    public bool isMute;

    // Start is called before the first frame update
    void Start()
    {
        //al = FindObjectOfType<AudioListener>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.pause = isMute;
    }

    public void Mute2()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }

}
