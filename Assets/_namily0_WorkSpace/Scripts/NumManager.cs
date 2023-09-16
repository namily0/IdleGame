using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

using System;
namespace useNumber
{
    public class NumManager : MonoBehaviour
    {
        //numberMethodArea
        //-----------------------------------------------
        private int _number = 0;
        public int number
        {
            set { _number = value; }
            get { return _number; }
        }
        private int _clickNum = 1;
        public int clickNum
        {
            set { _clickNum = value; }
            get { return _clickNum; }
        }
        private int _autoNum = 1;
        public int autoNum
        {
            set { _autoNum = value; }
            get { return _autoNum; }
        }
        private float _autoSpan = 1F;
        public float autoSpan
        {
            get { return _autoSpan; }
        }

        //-----------------------------------------------

        //Display----------------------------------------
        public TMP_Text NumDisplay;
        public TMP_Text StatusDisplay;
        //-----------------------------------------------
        
        void Update()
        {
            NumDisplay.text = "Number is " + number.ToString();
            StatusDisplay.text = "Auto:" + autoNum.ToString() + "\nClick:" + clickNum.ToString() + "\nSpeed: " + (Math.Round(Time.timeScale,2)).ToString();
        }

        public void SpeedUP()
        {
            Time.timeScale += 0.1F;
        }

        public void ClickPlus()
        {
            clickNum += 5;
        }

        public void AutoPlus()
        {
            autoNum += 1;
        }
    }
}
