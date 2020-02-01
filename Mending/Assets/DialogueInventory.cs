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
        //Handels when you have taken damage.
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
}
