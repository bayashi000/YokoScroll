using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//sceneが変わる時
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class StartScene : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Main");
    }

}

