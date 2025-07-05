using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySfx : MonoBehaviour
{
    public AudioSource sfx;
    // Start is called before the first frame update
    void Play()
    {
        sfx.Play();
    }
}
