using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottleCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 5, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Character")
        {
            TileManagement0.totalBottles += 1;
            Debug.Log(TileManagement0.totalBottles);
            Destroy(gameObject);
        }
    }
   
}
