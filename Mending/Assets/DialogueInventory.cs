using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInventory : MonoBehaviour
{
    public GameObject Slot1 = null;
    public GameObject Slot2 = null;
    public GameObject Slot3 = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Handles when you have taken damage.
        if (Slot2 != null)
        {
            if(Slot1 = null)
            {
                Slot1 = Slot2;    
                if(Slot3 != null)
                {
                    Slot2 = Slot3;
                    Slot3 = null;
                }
                else
                {
                    Slot2 = null;
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "PickUp")
        {
            Debug.Log("Nyahahaha! You found me!");
            if (Slot3 = null)
            {
                if (Slot1 = null)
                {
                    Debug.Log("You filled slot 1");
                    Slot1 = Other.gameObject;
                }

                else if (Slot2 = null)
                {
                    Debug.Log("You filled slot 2");
                    Slot2 = Other.gameObject;
                }
                else
                {
                    Debug.Log("You filled slot 3");
                    Slot3 = Other.gameObject;
                }
            }

        }

        if (Other.gameObject.tag == "PickUp" && Slot3 != null)
        {
            Debug.Log("You are carrying too much to run.");
        }
    }
}
