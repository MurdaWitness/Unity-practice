using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreTxt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + Windows.score;
    }
}
