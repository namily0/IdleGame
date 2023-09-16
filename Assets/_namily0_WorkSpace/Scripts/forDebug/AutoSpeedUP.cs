//this scripts is only use in debug.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using useNumber;

public class AutoSpeedUP : MonoBehaviour
{
    private Button button;
    public NumManager numManager;


    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        
    }

    void AutoSpeed()
    {
        numManager.SpeedUP();
    }
}
