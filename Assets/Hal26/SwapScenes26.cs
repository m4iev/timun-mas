using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SwapScenes26 : MonoBehaviour
{
    void Awake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
 
        if (SceneManager.GetActiveScene().name == "Hal26")
            BGMusic8.instance.GetComponent<AudioSource>().Stop();
            //BGmusic.instance.GetComponent<AudioSource>().Play();
 
    }
}