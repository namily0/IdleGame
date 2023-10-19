//this scripts is only use in debug.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using useNumber;

public class ClickPlus : MonoBehaviour
{
    private Button button;
    public NumManager numManager;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click5Plus);
    }

    void Click5Plus()
    {
        numManager.ClickPlus();
    }
}
