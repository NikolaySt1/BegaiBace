using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAni : MonoBehaviour
{

   

    void Start()
    {
       GetComponent<Animator>().Play("Anim_Run");
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            GetComponent<Animator>().Play("Anim_Jump");
        }
      
    }
}
