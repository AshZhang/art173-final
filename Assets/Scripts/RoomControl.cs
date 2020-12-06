using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomControl : MonoBehaviour
{
    public GameObject itemBin;
    public Animator anim;
    public AudioSource sound;
    public AudioClip errorSound;
    public static Animator roomAnimator;
    // Start is called before the first frame update
    void Start()
    {
        roomAnimator = anim;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void goToBsod(){
        sound.Stop();
        Destroy(this.itemBin);
        sound.clip = errorSound;
        sound.loop = false;
        sound.Play();
    }

    void StartRoomTransition(){
        Destroy(this.itemBin);
        anim.SetBool("transitioning", false);
    }

    void FinishRoomTransition(GameObject itemBin){
        if(itemBin != null){
            this.itemBin = Instantiate(itemBin, new Vector3(0, 0, -1), Quaternion.identity);
        }
    }
}
