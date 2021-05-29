using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class TileManager : MonoBehaviour
{

    public GameObject[] TilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLenght = 127.5f;
    private int amnTilesOnScreen = 7;


    
    private void Start()
    {
        playerTransform = GameObject.FindWithTag("Character").transform;

      for(int i = 0;i < amnTilesOnScreen;i++)
        {
            SpawnTile();
        }

    }


    private void Update()
    {

    }
    
    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(TilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLenght;
    }
}
*/