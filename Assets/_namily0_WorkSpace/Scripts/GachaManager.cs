using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using useNumber;

public class GachaManager : MonoBehaviour
{
    public NumManager numManager;
    public Button auto;
    public Button click;
    public Button speed;

    private AutoPlus autoPlus;
    private ClickPlus clickPlus;
    private AutoSpeedUP autoSpeed;

    private Button gacha;
    private bool gachaFlag = true;
    private int rand = 0;
    void Start()
    {
        gacha = GetComponent<Button>();
        gacha.onClick.AddListener(gachaStartFunc);

        autoPlus = auto.GetComponent<AutoPlus>();
        clickPlus = click.GetComponent<ClickPlus>();
        autoSpeed = speed.GetComponent<AutoSpeedUP>();
    }

    void gachaStartFunc()
    {
        if (numManager.number > numManager.needNumber && gachaFlag)
        {
            numManager.number -= numManager.needNumber;
            StartCoroutine("gachaStart");
            numManager.needNumber += 10;
        }
    }

    IEnumerator gachaStart()
    {
        gachaFlag = false;
        for (int i = 0; i < 3; i++)
        {
            ResetColor();
            speed.GetComponentInChildren<Image>().color = new Color32(0, 255, 255, 150);
            yield return new WaitForSeconds(0.2F);

            ResetColor();
            click.GetComponentInChildren<Image>().color = new Color32(0, 255, 255, 150);
            yield return new WaitForSeconds(0.2F);

            ResetColor();
            auto.GetComponentInChildren<Image>().color = new Color32(0, 255, 255, 150);
            yield return new WaitForSeconds(0.2F);

            ResetColor();
        }
        UpStatus();
        yield return new WaitForSeconds(0.8F);
        ResetColor();

        gachaFlag = true;
    }

    void UpStatus()
    {
        rand = Random.Range(1,10);
        if(rand == 1 || rand == 3 || rand == 5 || rand == 7)
        {
            numManager.AutoPlus();
            auto.GetComponentInChildren<Image>().color = new Color32(0, 0, 255, 255);
        }
        else if(rand == 2 || rand == 4 || rand == 6 || rand == 8)
        {
            numManager.SpeedUP();
            speed.GetComponentInChildren<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if(rand == 9)
        {
            numManager.ClickPlus();
            click.GetComponentInChildren<Image>().color = new Color32(0, 255, 0, 255);
        }
    }

    void ResetColor()
    {
        auto.GetComponentInChildren<Image>().color = new Color32(0, 0, 255, 100);
        click.GetComponentInChildren<Image>().color = new Color32(0, 255, 0, 100);
        speed.GetComponentInChildren<Image>().color = new Color32(255, 0, 0, 100);
    }
}
