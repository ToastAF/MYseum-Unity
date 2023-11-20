using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaleri : MonoBehaviour
{
    //Dette script er ret langt, fordi det er hardcoded, men jeg ved ikke hvordan jeg skulle forkorte det
    //Et GameObject for hvert maleri og dets tekst
    public GameObject MonaLisa, Babel, MonetBridge, Sunset, Wanderer, PearlEarring, Umbrella, AlmondBlossoms, Restaurant, StarryNight;
    public GameObject MLText, BText, MBText, SText, WText, PEText, UText, ABText, RText, RestText, SNText;
    //En redigerbar vektor, som kan skiftes i inspektoren. Vektoren styrer, hvor malerierne spawner
    public Vector3 spawnLocation;
    //Virkelig lang linje, som bare er variabler, der tjekker, om maleriet er spawnet.
    bool isMonaLisaSpawned, isBabelSpawned, isMonetBridgeSpawned, isSunsetSpawned, isWandererSpawned, isPearlEarringSpawned, isUmbrellaSpawned, isAlmondBlossomsSpawned, isRestaurantSpawned, isStarryNightSpawned;

    public bool editMode;

    public int number;

    private void Start()
    {
        editMode = false;
    }

    //Der er en funktion til hvert maleri. Disse funktioner bliver kaldt med buttons i UI. Selve SpawnMaleri.cs sidder på det GameObject, der hedder Scripthandler
    public void spawnMonaLisa()
    {
        //Der bliver tjekket, om maleriet er spawnet i forvejen
        if(isMonaLisaSpawned == false)
        {
            //Hvis den ikke er, så spawner vi det
            GameObject temp = Instantiate(MonaLisa, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = MLText; //Vi skal tilgå tekst objektet i et andet script PaintingScript
            isMonaLisaSpawned = true; //Og så sættes den her til true, så der kUN KAN VÆRE ET MALERI!
        }
    }
    //Alle de andre funktioner er det samme, bare med de andre maleriers navne :)
    public void spawnBabel()
    {
        if (isBabelSpawned == false)
        {
            GameObject temp = Instantiate(Babel, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = BText;
            isBabelSpawned = true;
        }
    }

    public void spawnMonetBridge()
    {
        if (isMonetBridgeSpawned == false)
        {
            GameObject temp = Instantiate(MonetBridge, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = MBText;
            isMonetBridgeSpawned = true;
        }
    }

    public void spawnSunset()
    {
        if (isSunsetSpawned == false)
        {
            GameObject temp = Instantiate(Sunset, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = SText;
            isSunsetSpawned = true;
        }
    }

    public void spawnWanderer()
    {
        if (isWandererSpawned == false)
        {
            GameObject temp = Instantiate(Wanderer, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = WText;
            isWandererSpawned = true;
        }
    }

    public void spawnPearlEarring()
    {
        if (isPearlEarringSpawned == false)
        {
            GameObject temp = Instantiate(PearlEarring, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = PEText;
            isPearlEarringSpawned = true;
        }
    }

    public void spawnUmbrella()
    {
        if (isUmbrellaSpawned == false)
        {
            GameObject temp = Instantiate(Umbrella, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = UText;
            isUmbrellaSpawned = true;
        }
    }

    public void spawnAlmondBlossoms()
    {
        if (isAlmondBlossomsSpawned == false)
        {
            GameObject temp = Instantiate(AlmondBlossoms, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = ABText;
            isAlmondBlossomsSpawned = true;
        }
    }

    public void spawnRestaurant()
    {
        if (isRestaurantSpawned == false)
        {
            GameObject temp = Instantiate(Restaurant, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = RestText;
            isRestaurantSpawned = true;
        }
    }

    public void spawnStarryNight()
    {
        if (isStarryNightSpawned == false)
        {
            GameObject temp = Instantiate(StarryNight, spawnLocation, Quaternion.identity);
            temp.GetComponent<PaintingScript>().infoText = SNText;
            isStarryNightSpawned = true;
        }
    }

    public void spawnNumberedPainting(int receivedData)
    {
        if(receivedData == 0)
        {
            spawnAlmondBlossoms();
            print("I WOrk!");
        }
        else if(receivedData == 1)
        {
            spawnBabel();
        }
        else if(receivedData == 2)
        {
            spawnRestaurant();
        }
        else if (receivedData == 3)
        {

            spawnMonaLisa();
        }
        else if (receivedData == 4)
        {
            spawnMonetBridge();
        }
        else if (receivedData == 5)
        {
            spawnPearlEarring();
        }
        else if (receivedData == 6)
        {

            spawnStarryNight();
        }
        else if (receivedData == 7)
        {
            spawnSunset();
        }
        else if (receivedData == 8)
        {
            spawnUmbrella();
        }
        else if (receivedData == 9)
        {
            spawnWanderer();
        }
        else
        {
            print("Poop! It didn't work...");
        }
    }
}
