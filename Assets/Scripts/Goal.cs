using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Text lastTimeText;
    public Text highTimeText;
    int highTime;
    int lastTime;

    // Use this for initialization
    void Start()
    {
        lastTime = PlayerPrefs.GetInt("score");
        lastTimeText.text = lastTime.ToString();

        if (PlayerPrefs.HasKey("highScore") == true)
        {
            highTime = PlayerPrefs.GetInt("highScore");
            if (highTime < lastTime)
            {
                highTime = lastTime;
                PlayerPrefs.GetInt("highScore", highTime);
            }
        }
        else
        {
            highTime = lastTime;
            PlayerPrefs.SetInt("highScore", highTime);

        }
        highTimeText.text = highTime.ToString();


    }
    public void RetryButton()
    {
        SceneManager.LoadScene("Start");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
