using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoorController : MonoBehaviour
{
    public string nextScene;
    // Start is called before the first frame update
    void Start()
    {
        SetNextScene("MalloryDevScene_Conversation");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetNextScene(string desiredScene)
    {
        nextScene = desiredScene;
    }

    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            // if conditions are met
            // nextScene="TutorialLevel";
            SceneManager.LoadScene(nextScene);
        }
    }

}
