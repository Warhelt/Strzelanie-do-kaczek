using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{

	 private Text resultText;
    // Start is called before the first frame update
    void Start()
    {
                 resultText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        if(Timer.isFinish){
                 // resultText.gameObject.SetActive(true);

                    resultText.text = "Uzyskany wynik : " + Points.scoreValue;

        }else{
           resultText.text = "";
        }
    }
}
