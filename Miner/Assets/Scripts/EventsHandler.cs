using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsHandler : MonoBehaviour
{
    public static EventsHandler instance;

    public UnityEvent inventoryChanged;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
