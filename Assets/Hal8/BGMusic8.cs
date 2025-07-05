using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BGMusic8 : MonoBehaviour
{
    public static BGMusic8 instance;
 
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