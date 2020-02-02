using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatchMove : MonoBehaviour
{
    public float NeedleX;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NeedleX = GameObject.Find("Needle Selector").transform.position.x;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (NeedleX == -4)
            {
                Debug.Log("I'm on the left");
            }
            else if (NeedleX == 0)
            {
                Debug.Log("I'm in the middle");
            }
            else if (NeedleX == 3)
            {
                Debug.Log("I'm on the right");
            }
        }
    }
}
