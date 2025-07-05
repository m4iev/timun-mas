using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SwapScenes8 : MonoBehaviour
{
    void Awake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
 
        if (SceneManager.GetActiveScene().name == "Hal8")
            BGMusic4.instance.GetComponent<AudioSource>().Stop();
            //BGmusic.instance.GetComponent<AudioSource>().Play();
 
    }
}