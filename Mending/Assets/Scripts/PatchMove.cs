using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatchMove : MonoBehaviour
{
    public float NeedleX;
    public float speed;
    public int SpacesUsed;
    private Transform target;
    public GameObject Patch1;
    public GameObject Patch2;
    public GameObject Patch3;
    Vector2 m_Space1;
    Vector2 m_Space2;
    Vector2 m_Space3;
    public bool Patch1IsHome;
    public bool Patch2IsHome;
    public bool Patch3IsHome;
    
    // Start is called before the first frame update
    void Start()
    {
        SpacesUsed = 0;
        speed = 1.0f;
        Patch1IsHome = true;
        Patch2IsHome = true;
        Patch3IsHome = true;

    }

    // Update is called once per frame
    void Update()
    {
        m_Space1 = new Vector2(-2.5f, 3.5f);
        m_Space2 = new Vector2(2.5f, 1.8f);
        m_Space3 = new Vector2(-2.5f, -.25f);

        NeedleX = GameObject.Find("Needle Selector").transform.position.x;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (NeedleX == -4 && Patch1IsHome)
            {
                Debug.Log("I'm on the left");
                MoveThatPatch(Patch1);
                Patch1IsHome = false;
                SpacesUsed++;
            }
            else if (NeedleX == 0 && Patch2IsHome)
            {
                Debug.Log("I'm in the middle");
                MoveThatPatch(Patch2);
                Patch2IsHome = false;
                SpacesUsed++;
            }
            else if (NeedleX == 3 && Patch3IsHome)
            {
                Debug.Log("I'm on the right");
                MoveThatPatch(Patch3);
                Patch3IsHome = false;
                SpacesUsed++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You used these spaces: " + SpacesUsed);
        }
    }
        
   void MoveThatPatch(GameObject Patch)
    {
        if (SpacesUsed == 0)
        {
            Debug.Log("This goes in Space 1");
            Patch.transform.position = m_Space1;
            
        }
        else if (SpacesUsed == 1)
        {
            Debug.Log("This goes in Space 2");
            Patch.transform.position = m_Space2;
        }
        else if (SpacesUsed == 2)
        {
            Debug.Log("This goes in Space 3");
            Patch.transform.position = m_Space3;
        }
        else
        {
            Debug.Log("Time for the next scene.");
        }
      }
}//When SpacesUsed ==3 trigger next scene/load next scene
