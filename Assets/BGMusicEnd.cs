using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BGMusicEnd : MonoBehaviour
{
    public static BGMusicEnd instance;
 
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}