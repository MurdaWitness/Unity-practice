using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            anim.SetBool("IsRunning", true);
        if (Input.GetKeyUp(KeyCode.W))
            anim.SetBool("IsRunning", false);
        if (Input.GetKeyDown(KeyCode.S))
            anim.SetBool("IsReturning", true);
        if (Input.GetKeyUp(KeyCode.S))
            anim.SetBool("IsReturning", false);
        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetTrigger("TriggerJump");
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 100 * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down, 100 * Time.deltaTime);
    }
}
