using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timerText;
    public static float startTime;
    public static bool isFinish = false;
    public float elapsedTime;

    void Start()
    {
        timerText = GetComponent<Text>();
        startTime = Time.time;

    }

    void Update()
    {
        elapsedTime = Time.time - startTime;
            string minutes = ((int)elapsedTime / 60).ToString();
            string seconds = ((int)elapsedTime % 60).ToString();
            timerText.text = minutes + ":" + seconds;
        

        if(timerText.text == "1:0"){
            isFinish = true;
            Time.timeScale = 0;
            KillDuck.clicked = false;

        }
        if(timerText.text == "0:0" ){
            Time.timeScale = 1;
            KillDuck.clicked = true;
            isFinish = false;

        }
    }

}
