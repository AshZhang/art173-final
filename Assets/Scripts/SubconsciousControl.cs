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
        anim.speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (sound.isPlaying)
        {
            Debug.Log("Sound playin");
            anim.speed = 0;
        }
        else
        {
            Debug.Log("Sound stopped");
            anim.speed = 1;
        }
    }

    void playSound()
    {
        sound.Play();
    }

}
