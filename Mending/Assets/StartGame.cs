using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartGame : MonoBehaviour
{
    public Button StartButton;
 
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(NewGameStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NewGameStart()
    {
        Debug.Log("I work! I promise! Please don't throw me out.");
        SceneManager.LoadScene("OpeningCinema");
    }

}

