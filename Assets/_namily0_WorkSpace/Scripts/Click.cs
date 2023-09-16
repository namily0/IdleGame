using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using useNumber;

public class Click : MonoBehaviour
{
    public Button clickMeButton;
    public NumManager numManager;

    void Start()
    {
        clickMeButton.onClick.AddListener(AddNumber);
    }
    void Update()
    {
        
    }

    void AddNumber()
    {
        numManager.number += numManager.clickNum;
    }

}
