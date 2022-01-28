using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    public float amount;

    private void Start()
    {
        amount = Random.Range(3.0f, 7.0f);
    }

    private void Update()
    {
        if(amount <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null)
        {
            var script = collision.gameObject.GetComponent<Player>();
            script.Mine(this);
        }
    }
    
}
