using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// enum Rooms {
// 	intro = 0;
// 	left = 1;
// 	right = 2;
// };

public class SwitchRoom : MonoBehaviour
{
    public Animator anim;
	public int nextRoom;
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
		anim.SetInteger("room", nextRoom);
	}
}
