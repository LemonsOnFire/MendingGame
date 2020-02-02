using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController : MonoBehaviour
{

    public float NeedleX;
    Vector2 m_LeftPosition;
    Vector2 m_MidPosition;
    Vector2 m_RightPosition;
    public float m_XPosition;

    // Start is called before the first frame update
    void Start()
    {
       /* m_LeftPosition = new Vector2(-4.0f, -2.5f);
        m_MidPosition = new Vector2(0.0f, -2.5f);
        m_RightPosition = new Vector2(3.0f, -2.5f); */
    }

    // Update is called once per frame
    void Update()
    {
        m_LeftPosition = new Vector2(-4.0f, -2.5f);
        m_MidPosition = new Vector2(0.0f, -2.5f);
        m_RightPosition = new Vector2(3.0f, -2.5f);
        NeedleX = GameObject.Find("Needle Selector").transform.position.x;

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key was pressed");
            if (NeedleX == 0)
            {
                NeedleX = -4;
                //m_LeftPosition.x = m_XPosition;
                transform.position = m_LeftPosition;
            }
            else if (NeedleX == 3)
            {
                NeedleX = 0;
                //m_MidPosition.x = m_XPosition;
                transform.position = m_MidPosition;
            }            
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D key was pressed");
            if (NeedleX == 0)
            {
                NeedleX = 3;
                //m_RightPosition.x = m_XPosition;
                transform.position = m_RightPosition;
            }
            else if (NeedleX == -4)
            {
                NeedleX = 0;
                //m_MidPosition.x = m_XPosition;
                transform.position = m_MidPosition;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
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
