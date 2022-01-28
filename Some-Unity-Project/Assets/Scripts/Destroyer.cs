﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ground"))
        {
            Destroy(other.gameObject);
            Debug.Log("EXTERMINATE");
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("EXTERMINATE");
    }
    */
}
