using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoLevel3 : MonoBehaviour
{
    float timeLeft = 5.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("LET'S GO");
            LoadLevel3();
        }
    }
    void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}