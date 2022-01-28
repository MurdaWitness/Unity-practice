using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Transform> spawnpoints;
    public List<GameObject> objInScene;
    public GameObject ore;
    public float oreChanceSpawn = 0.7f;
    public float rateSpawn; 

    void Start()
    {
        StartCoroutine(Timer(rateSpawn));
    }

    public void Spawn()
    {
        var random = Random.Range(0.0f, 1.0f);
        if (random >= oreChanceSpawn) 
        {
            objInScene.Add(Instantiate(ore, spawnpoints[Random.Range(0,10)].position, spawnpoints[0].rotation));
        }
    }

    IEnumerator Timer(float rate)
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(rate);
        }
    }
}
