using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupGenerator : MonoBehaviour
{
    public GameObject popupObj;
    public GameObject curPopup;
    public Animator anim;
    public bool popupsEnabled;
    private int numClicked;

    // Use this for initialization
    void Start()
    {
        popupsEnabled = true;
        anim = RoomControl.roomAnimator;
        numClicked = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnMouseDown()
    {
        if (this.curPopup == null)
        {
            numClicked++;
            if(numClicked >= 173){
                anim.SetBool("transitioning", true);
                anim.SetInteger("room", 1);
            }else{
                popupsEnabled = false;
                this.curPopup = Instantiate(popupObj, new Vector3(0, 0, -1), Quaternion.identity);
            }
        }
    }

}
