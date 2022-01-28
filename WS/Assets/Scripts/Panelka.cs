using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panelka : MonoBehaviour
{
    public Slider slid;
    public int amount;

    void Start()
    {
        slid.maxValue = amount;
    }
}
