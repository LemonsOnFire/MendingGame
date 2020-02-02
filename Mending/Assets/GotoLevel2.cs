using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoLevel2 : MonoBehaviour
{
    float timeLeft = 5.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("LET'S GO");
            LoadLevel2();
        }
    }
    void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
}
