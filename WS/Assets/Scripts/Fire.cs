using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private void OnMouseDown()
    {
        Windows.score += 10;
        Windows.counter--;
        Destroy(this.gameObject);
    }

}
