using UnityEngine;
using System.Collections;

public class AnimControllerPlayer : MonoBehaviour {

    public Animator anim;
	
	void Start ()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("walk", false);
	}
	
	
	void Update ()
    {
	    
           if (Input.GetButton("upWalk"))
        {
            
            anim.SetBool("Walk", true);
            anim.SetBool("Idle", false);
            //Debug.Log("button is pressed");

        }
        else
        {
            anim.SetBool("Idle", true);
            anim.SetBool("Walk", false);

        }

        if (Input.GetButton("Fire1"))
        {
           
            anim.SetBool("Chop", true);
            anim.SetBool("Idle", false);

        }
        else
        {
            
            anim.SetBool("Chop", false);

        }






    }
}
