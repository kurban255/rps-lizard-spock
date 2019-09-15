using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    void Awake()
    {
        int numberOfThings = FindObjectsOfType<Singleton>().Length;
        if (numberOfThings > 1)
        {
            gameObject.SetActive(true);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
