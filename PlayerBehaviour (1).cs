
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBehaviour : MonoBehaviour 
{
    private string LaneChange = "n";
    
    void Start()
    {
        GameObject character = GameObject.FindWithTag("Character");
        character.GetComponent<Rigidbody>().velocity = new Vector3(0,0,53);  
     
    }
    

    void Update()
    {
    if((Input.GetKey("a"))&& (LaneChange=="n") && (transform.position.x>-17.2))
        {
            //   GetComponent<Rigidbody>().velocity = new Vector3(-25, 0, 53);
            // LaneChange = "y";
            //StartCoroutine(stopLaneCh());
            goLeft();
        }

        if((Input.GetKey("d")) && (LaneChange == "n") && (transform.position.x < 17.1))
        {
            // GetComponent<Rigidbody>().velocity = new Vector3(25, 0, 53);
            // LaneChange = "y";
            // StartCoroutine(stopLaneCh());
            goRight();
        }

      
        if (Input.GetKey("space"))
        {

            GetComponent<Rigidbody>().velocity = new Vector3(0, 15, 53);
      
            StartCoroutine(stopJump());
        }
    }

    public void goLeft()
    {
        GameObject.FindWithTag("Character").GetComponent<Rigidbody>().velocity = new Vector3(-25, 0, 53);
        LaneChange = "y";
        StartCoroutine(stopLaneCh());
    } 
    public void goRight()
    {
        GameObject.FindWithTag("Character").GetComponent<Rigidbody>().velocity = new Vector3(25, 0, 53);
        LaneChange = "y";
        StartCoroutine(stopLaneCh());
    }
    

    

    IEnumerator stopJump()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject.FindWithTag("Character").GetComponent<Rigidbody>().velocity = new Vector3(0, -15, 53);
        yield return new WaitForSeconds(0.5f);
        GameObject.FindWithTag("Character").GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 53);
       
        Debug.Log(GetComponent<Transform>().position);
    } 

    IEnumerator stopLaneCh()
    {
        yield return new WaitForSeconds(1);

        GameObject.FindWithTag("Character").GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 53);
        LaneChange = "n";
        Debug.Log(GetComponent<Transform>().position);
    }
}

