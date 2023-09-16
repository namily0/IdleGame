using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using useNumber;

public class AutoAdd : MonoBehaviour
{
    public NumManager numManager;
    private float timer = 0F;

    void Start()
    {
        
    }

    void Update()
    {
        if(timer > numManager.autoSpan)
        {
            numManager.number += numManager.autoNum;
            timer = 0F;
        }
        timer += Time.deltaTime;
    }
}
