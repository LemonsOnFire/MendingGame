using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ByeBye : MonoBehaviour
{
    public Button ExitButton;
    
    // Start is called before the first frame update
    void Start()
    {
        ExitButton.onClick.AddListener(ByeByeBye);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ByeByeBye()
    {
        Application.Quit();
        Debug.Log("I don't wanna see you walk out that door, baby.");
    }
}
