using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BGMusic26 : MonoBehaviour
{
    public static BGMusic26 instance;
 
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