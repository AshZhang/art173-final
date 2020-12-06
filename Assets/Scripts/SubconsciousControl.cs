using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubconsciousControl : MonoBehaviour
{
    public Animator anim;
    public AudioSource sound;
    // Use this for initialization
    void Start()
    {
        sound.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (!sound.isPlaying)
        {
            anim.SetFloat("isS10", 1);
        }
    }

    void playSound()
    {
        sound.Play();
        anim.SetFloat("isS10", 0);
    }

}
