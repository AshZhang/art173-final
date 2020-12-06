using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRoom : MonoBehaviour
{
    public Animator anim;
	// Use this for initialization
	void Start ()
	{
		anim = RoomControl.roomAnimator;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnMouseDown ()
	{
		anim.SetBool("transitioning", true);
		anim.SetInteger("room", 0);
	}
}
