using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetFollow;
    public Transform targetLook;
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        Follow();
        transform.LookAt(targetLook);
        if (Input.GetKey(KeyCode.F)) Debug.Log("s");
    }

    public void Follow()
    {
        transform.position = Vector3.Lerp(transform.position, targetFollow.position, speed);
    }
}
