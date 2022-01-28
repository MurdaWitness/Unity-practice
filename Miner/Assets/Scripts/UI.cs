using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Player script;
    public Text Weight;
    public Text Money;
    public void UpdateUI()
    {
        print(script.weight.ToString());
        Weight.text = "Weight: " + script.weight;
        Money.text = "Money: " + script.money;
    }
}