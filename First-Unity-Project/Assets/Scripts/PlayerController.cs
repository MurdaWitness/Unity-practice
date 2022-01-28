using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    public float speed = 8.0f;
    public float rotateSpeed = 90.0f;

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed * horizontalInput);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Door")
        {
            Debug.Log("New Level!");
            SceneManager.LoadScene("Level 2");
        }
    }
}
