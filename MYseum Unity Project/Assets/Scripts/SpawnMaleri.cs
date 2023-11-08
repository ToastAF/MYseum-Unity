using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaleri : MonoBehaviour
{
    public GameObject MonaLisa, Babel, MonetBridge, Sunset, Wanderer, PearlEarring, Umbrella, AlmondBlossoms, Restaurant, StarryNight;
    public Vector3 spawnLocation;
    bool isMonaLisaSpawned, isBabelSpawned, isMonetBridgeSpawned, isSunsetSpawned, isWandererSpawned, isPearlEarringSpawned, isUmbrellaSpawned, isAlmondBlossomsSpawned, isRestaurantSpawned, isStarryNightSpawned;

    public void spawnMonaLisa()
    {
        if(isMonaLisaSpawned == false)
            {
                GameObject monaLisaClone = Instantiate(MonaLisa, spawnLocation, Quaternion.identity);
                monaLisaClone.transform.Rotate(new Vector3(0, 0, 40));
                isMonaLisaSpawned = true;
            }
    }

    public void spawnBabel()
    {
        if (isBabelSpawned == false)
        {
            GameObject babelClone = Instantiate(Babel, spawnLocation, Quaternion.identity);
            babelClone.transform.Rotate(new Vector3(0, 0, 40));
            isBabelSpawned = true;
        }
    }

    public void spawnMonetBridge()
    {
        if (isMonetBridgeSpawned == false)
        {
            GameObject monetBridgeClone = Instantiate(MonetBridge, spawnLocation, Quaternion.identity);
            monetBridgeClone.transform.Rotate(new Vector3(0, 0, 40));
            isMonetBridgeSpawned = true;
        }
    }

    public void spawnSunset()
    {
        if (isSunsetSpawned == false)
        {
            GameObject sunsetClone = Instantiate(Sunset, spawnLocation, Quaternion.identity);
            sunsetClone.transform.Rotate(new Vector3(0, 0, 40));
            isSunsetSpawned = true;
        }
    }

    public void spawnWanderer()
    {
        if (isWandererSpawned == false)
        {
            GameObject wandererClone = Instantiate(Wanderer, spawnLocation, Quaternion.identity);
            wandererClone.transform.Rotate(new Vector3(0, 0, 40));
            isWandererSpawned = true;
        }
    }

    public void spawnPearlEarring()
    {
        if (isPearlEarringSpawned == false)
        {
            GameObject PearlEarringClone = Instantiate(PearlEarring, spawnLocation, Quaternion.identity);
            PearlEarringClone.transform.Rotate(new Vector3(0, 0, 40));
            isPearlEarringSpawned = true;
        }
    }

    public void spawnUmbrella()
    {
        if (isUmbrellaSpawned == false)
        {
            GameObject clone = Instantiate(Umbrella, spawnLocation, Quaternion.identity);
            clone.transform.Rotate(new Vector3(0, 0, 40));
            isUmbrellaSpawned = true;
        }
    }

    public void spawnAlmondBlossoms()
    {
        if (isAlmondBlossomsSpawned == false)
        {
            GameObject clone = Instantiate(AlmondBlossoms, spawnLocation, Quaternion.identity);
            clone.transform.Rotate(new Vector3(0, 0, 40));
            isAlmondBlossomsSpawned = true;
        }
    }

    public void spawnRestaurant()
    {
        if (isRestaurantSpawned == false)
        {
            GameObject clone = Instantiate(Restaurant, spawnLocation, Quaternion.identity);
            clone.transform.Rotate(new Vector3(0, 0, 40));
            isRestaurantSpawned = true;
        }
    }

    public void spawnStarryNight()
    {
        if (isStarryNightSpawned == false)
        {
            GameObject clone = Instantiate(StarryNight, spawnLocation, Quaternion.identity);
            clone.transform.Rotate(new Vector3(0, 0, 40));
            isStarryNightSpawned = true;
        }
    }
}
