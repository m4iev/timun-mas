using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BGMusic4 : MonoBehaviour
{
    public static BGMusic4 instance;
 
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