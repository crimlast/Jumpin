using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    float score;
    public TMP_Text scoreTxt;
    public TMP_Text deathTxt;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //increase Score
        score += Time.deltaTime * 2;
        scoreTxt.text = "Score: " + (int)score;
    }

    public void Pause(){
        Time.timeScale = 0;
    }

    public void unPause(){
        Time.timeScale = 1;
    }

    public void ReTry(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
