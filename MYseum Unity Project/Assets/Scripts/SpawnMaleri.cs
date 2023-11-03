using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaleri : MonoBehaviour
{
    public GameObject MonaLisa;
    public Vector3 spawnLocation;
    bool isMonaLisaSpawned;

    void Start()
    {
        isMonaLisaSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnMaleri()
    {
        if(isMonaLisaSpawned == false)
            {
                GameObject monaLisaClone = Instantiate(MonaLisa, spawnLocation, Quaternion.identity);
                monaLisaClone.transform.Rotate(new Vector3(0, 0, 40));
                isMonaLisaSpawned = true;
            }
    }
}
