using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoCredits : MonoBehaviour
{
    float timeLeft = 7.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("TIMES UP");
            SceneManager.LoadScene("Credits");
        }
    }
}