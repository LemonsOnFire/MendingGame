using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        mySpriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D Other)
    {

        if (Other.collider.gameObject.tag == "Player")
        {
            GameObject myPlayer;
            myPlayer = gameObject.GetComponent<GameObject>();
            //myPlayer.SetCheckpoint(transform.position);
            //Other.gameObject.SetCheckpoint(transform.position);
            //Other.SetCheckpoint(transform.position);
        }

    }

}
