using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalIndex;  // iki yerde de animalindex tanimlamisiz.
    //private float spawnRangeX = 15;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    [SerializeField] private float spawnInterval = 0.5f;
    // Start is called before the first frame update

  

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);  
    }

   
    void SpawnRandomAnimal()
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length); 

            Vector3 spawnPos = new Vector3(Random.Range(-15, 15), 0, spawnPosZ);
            GameObject animal = Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            animal.transform.eulerAngles = Vector3.down * 180;
        }

    }

