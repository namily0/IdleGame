//this scripts is only use in debug.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using useNumber;

public class AutoPlus : MonoBehaviour
{
    private Button button;
    public NumManager numManager;

    void Start()
    {
        button = GetComponent<Button>(); 
        button.onClick.AddListener(Auto1Plus);
    }

    void Auto1Plus()
    {
        numManager.AutoPlus();
    }

}
