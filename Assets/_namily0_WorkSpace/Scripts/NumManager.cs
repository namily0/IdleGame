using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using System;
namespace useNumber
{
    public class NumManager : MonoBehaviour
    {
        //numberMethodArea
        //-----------------------------------------------
        [SerializeField] private int _number = 0;
        public int number
        {
            set { 
                if(_number < 0 || value >= 1000000000){
                    _number = 1000000000;//999999999
                    Clear();
                }else{
                    _number = value;
                }
                }
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

        private int _needNumber = 0;
        public int needNumber
        {
            set { _needNumber = value; }
            get { return _needNumber; }
        }

        //-----------------------------------------------

        //Display----------------------------------------
        public TMP_Text NumDisplay;
        public TMP_Text StatusDisplay;
        public TMP_Text GachaDisplay;
        //-----------------------------------------------

        //ClearRelated-----------------------------------
        public GameObject ClearEffect;
        public GameObject GoToDebug;
        private bool onceFlag = true;
        //-----------------------------------------------
        
        void Start()
        {
            if(onceFlag && SceneManager.GetActiveScene().name == "GameScene")
            {
                GoToDebug.SetActive(false);
            }
            else if(!onceFlag && SceneManager.GetActiveScene().name == "GameScene")
            {
                GoToDebug.SetActive(true);
            }
        }

        private void GameSceneLoaded(Scene next,LoadSceneMode mode)
        {
            if(onceFlag && SceneManager.GetActiveScene().name == "GameScene")
            {
                GoToDebug.SetActive(false);
            }
            else if(!onceFlag && SceneManager.GetActiveScene().name == "GameScene")
            {
                GoToDebug.SetActive(true);
            }
        }
        void Update()
        {
            NumDisplay.text = "Number is " + number.ToString();
            StatusDisplay.text = "Auto:" + autoNum.ToString() + "\nClick:" + clickNum.ToString() + "\nSpeed: " + (Math.Round(Time.timeScale,2)).ToString();
            if(SceneManager.GetActiveScene().name == "GameScene")
            GachaDisplay.text = "Need to Gacha: " + needNumber.ToString();
        }
        void Clear()
        {
            if(SceneManager.GetActiveScene().name == "GameScene" && onceFlag)
            {
                Debug.Log("this Scene is GameScene");
                ClearEffect.SetActive(true);
                onceFlag = false;
            }
        }

        public void SpeedUP()
        {
            Time.timeScale += 0.1F;
        }

        public void ClickPlus()
        {
            clickNum += 3;
        }

        public void AutoPlus()
        {
            autoNum += 1;
        }
    }
}

