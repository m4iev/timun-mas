using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SwapScenesStart : MonoBehaviour
{
    void Awake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
 
        if (SceneManager.GetActiveScene().name == "Cover")
            BGMusicEnd.instance.GetComponent<AudioSource>().Stop();
            //BGmusic.instance.GetComponent<AudioSource>().Play();
 
    }
}