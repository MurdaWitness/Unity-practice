using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public float speed;
    public float stopDistance = 2f;
    public Transform target;
    public bool useLerp;
    public bool useTowards;

    void Update()
    {
        var t = new Vector3(target.position.x, transform.position.y, target.position.z);
        if (Vector3.Distance(transform.position, t) >= stopDistance)
        {
            if (useLerp) MoveByLerp(t);
            if (useTowards) MoveByTowards(t);
            transform.LookAt(t);
        }
    }

    public void MoveByLerp(Vector3 t)
    {
        transform.position = Vector3.Lerp(transform.position, t, speed * Time.deltaTime);
    }

    public void MoveByTowards(Vector3 t)
    {
        transform.position = Vector3.MoveTowards(transform.position, t, speed * Time.deltaTime);
    }

}
