using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
     using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    private Button btn;

	   public void RestartGame() {
        Time.timeScale = 1;
        Points.scoreValue =0;
        Timer.isFinish = false;
        KillDuck.clicked = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
    void Start()
    {
        btn = GetComponent<Button>();

    }

    void Update()
    {
        if(Timer.isFinish){
 			btn.interactable = true;
        }else{
 			btn.interactable = false;
        }
    }
}
