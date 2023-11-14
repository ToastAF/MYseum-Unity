using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaleri : MonoBehaviour
{
    //Et GameObject for hvert maleri
    public GameObject MonaLisa, Babel, MonetBridge, Sunset, Wanderer, PearlEarring, Umbrella, AlmondBlossoms, Restaurant, StarryNight;
    //En redigerbar vektor, som kan skiftes i inspektoren. Vektoren styrer, hvor malerierne spawner
    public Vector3 spawnLocation;
    //Virkelig lang linje, som bare er variabler, der tjekker, om maleriet er spawnet.
    bool isMonaLisaSpawned, isBabelSpawned, isMonetBridgeSpawned, isSunsetSpawned, isWandererSpawned, isPearlEarringSpawned, isUmbrellaSpawned, isAlmondBlossomsSpawned, isRestaurantSpawned, isStarryNightSpawned;

    //Der er en funktion til hvert maleri. Disse funktioner bliver kaldt med buttons i UI. Selve SpawnMaleri.cs sidder på det GameObject, der hedder Scripthandler
    public void spawnMonaLisa()
    {
        //Der bliver tjekket, om maleriet er spawnet i forvejen
        if(isMonaLisaSpawned == false)
        {
            //Hvis den ikke er, så spawner vi det
            Instantiate(MonaLisa, spawnLocation, Quaternion.identity);
            isMonaLisaSpawned = true; //Og så sættes den her til true, så der kUN KAN VÆRE ET MALERI!
        }
    }
    //Alle de andre funktioner er det samme, bare med de andre maleriers navne :)
    public void spawnBabel()
    {
        if (isBabelSpawned == false)
        {
            Instantiate(Babel, spawnLocation, Quaternion.identity);
            isBabelSpawned = true;
        }
    }

    public void spawnMonetBridge()
    {
        if (isMonetBridgeSpawned == false)
        {
            Instantiate(MonetBridge, spawnLocation, Quaternion.identity);
            isMonetBridgeSpawned = true;
        }
    }

    public void spawnSunset()
    {
        if (isSunsetSpawned == false)
        {
            Instantiate(Sunset, spawnLocation, Quaternion.identity);
            isSunsetSpawned = true;
        }
    }

    public void spawnWanderer()
    {
        if (isWandererSpawned == false)
        {
            Instantiate(Wanderer, spawnLocation, Quaternion.identity);
            isWandererSpawned = true;
        }
    }

    public void spawnPearlEarring()
    {
        if (isPearlEarringSpawned == false)
        {
            Instantiate(PearlEarring, spawnLocation, Quaternion.identity);
            isPearlEarringSpawned = true;
        }
    }

    public void spawnUmbrella()
    {
        if (isUmbrellaSpawned == false)
        {
            Instantiate(Umbrella, spawnLocation, Quaternion.identity);
            isUmbrellaSpawned = true;
        }
    }

    public void spawnAlmondBlossoms()
    {
        if (isAlmondBlossomsSpawned == false)
        {
            Instantiate(AlmondBlossoms, spawnLocation, Quaternion.identity);
            isAlmondBlossomsSpawned = true;
        }
    }

    public void spawnRestaurant()
    {
        if (isRestaurantSpawned == false)
        {
            Instantiate(Restaurant, spawnLocation, Quaternion.identity);
            isRestaurantSpawned = true;
        }
    }

    public void spawnStarryNight()
    {
        if (isStarryNightSpawned == false)
        {
            Instantiate(StarryNight, spawnLocation, Quaternion.identity);
            isStarryNightSpawned = true;
        }
    }
}
