using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ClearEffect : MonoBehaviour
{
    public GameObject GoDebug;

    private Button button;
    private float timer;
    private float timerSpan;
    private bool timerFlag;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ActiveChange);
        timer = 0F;
        timerSpan = 5.0F;
        timerFlag = false;
    }

    void ActiveChange()
    {
        if(timerFlag)
        {
            this.gameObject.SetActive(false);
            GoDebug.SetActive(true);
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timerSpan)
        timerFlag = true;
    }
}
