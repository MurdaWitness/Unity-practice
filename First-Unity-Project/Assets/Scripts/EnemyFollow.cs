using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;

    void Update()
    {

        if (Vector3.Distance(transform.position, player.position) >= 2f)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, 2f * Time.deltaTime);
            transform.LookAt(player);
        }
        if (Vector3.Distance(transform.position, player.position) < 2f)
        {
            Debug.LogError("Вы проиграли(((");
            Application.Quit();
        }
    }
}
