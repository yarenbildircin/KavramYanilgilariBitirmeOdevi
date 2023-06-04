using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        
    }

    public void StartTopic()
    {
        SceneManager.LoadScene("Topic");

    }
}
