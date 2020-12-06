using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruneTree : MonoBehaviour
{
    public Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = RoomControl.roomAnimator;
        transform.Translate(Vector3.down * 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 0){
            anim.SetBool("transitioning", true);
        }
    }

}
