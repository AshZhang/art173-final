using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupControl : MonoBehaviour
{
    // Use this for initialization
    public AudioSource sound;
    void Start()
    {
        sound.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown ()
	{
		Destroy(gameObject);
	}

}
