using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SwapScenes4 : MonoBehaviour
{
    void Awake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
 
        if (SceneManager.GetActiveScene().name == "Hal4")
            BGMusic2.instance.GetComponent<AudioSource>().Stop();
            //BGmusic.instance.GetComponent<AudioSource>().Play();
 
    }
}