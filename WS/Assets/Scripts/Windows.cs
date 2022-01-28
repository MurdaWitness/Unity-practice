using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windows : MonoBehaviour
{

    public List<Transform> windows = new List<Transform>();
    static public int counter;
    static public int score;
    public GameObject firePrefab;
    public float interval;

    void Start()
    {
        counter = 0;
        score = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartTimer();
        }

    }

    IEnumerator Timer()
    {
        while (true)
        {
            SpawnFire();
            yield return new WaitForSeconds(5);
        }
    }

    IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(5);
        if (counter > 5)
        {
            print("Вы проиграли!");
        }
    }

    public void SpawnFire()
    {
        var x = Random.Range(0, windows.Count);
        Instantiate(firePrefab, windows[x].position, Quaternion.identity);
        counter++;
        if (counter > 5)
        {
            StartCoroutine(DeathTimer());
        }
    }

    public void StartTimer()
    {
        StartCoroutine(Timer());
    }
}
