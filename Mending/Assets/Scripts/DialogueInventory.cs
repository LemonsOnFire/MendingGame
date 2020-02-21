using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInventory : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
   void Update()
    {
        //Handles when you have taken damage.
        if (Slot2 != GameObject.Find("Empty2"))
        {
            if(Slot1 == GameObject.Find("Empty1"))
            {
                Slot1 = Slot2;    
                if(Slot3 != GameObject.Find("Empty3"))
                {
                    Slot2 = Slot3;
                    Slot3 = GameObject.Find("Empty3");
                }
                else
                {
                    Slot2 = GameObject.Find("Empty2");
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "PickUp")
        {
            if (Slot1 == GameObject.Find("Empty1"))
                {
                   Debug.Log("You filled slot 1 with " + Other);
                   Slot1 = Other.gameObject;
                }

            else if (Slot1 != GameObject.Find("Empty1")) 
            {
                if (Slot2 == GameObject.Find("Empty2"))
                {
                    Debug.Log("You filled slot 2 with " + Other);
                    Slot2 = Other.gameObject;
                }
                else if (Slot2 != GameObject.Find("Empty2"))
                {
                    if (Slot3 == GameObject.Find("Empty3"))
                    {
                        Debug.Log("You filled slot 3 with " + Other);
                        Slot3 = Other.gameObject;
                    }
                    else if (Slot3 != GameObject.Find("Empty3"))
                    {
                        Debug.Log("You are carrying too much to run.");
                    }
                }
            }
            Debug.Log("Nyahahaha! You found me!");
        }else if (Other.gameObject.tag == "Enemy")
        {
            Debug.Log("Ouch you hurt me!");
            if (Slot1 == GameObject.Find("Empty1"))
            {
                //Player Die
                //SceneManager
            }
            else
            {
                Slot1 = GameObject.Find("Empty1");
            }
        }
    }
}
