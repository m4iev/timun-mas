using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstPage : MonoBehaviour
{
    public void toHome() {
        SceneManager.LoadScene(0);
    }
}
