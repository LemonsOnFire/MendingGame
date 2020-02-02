using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepressionAi : MonoBehaviour
{
    public DepressionMovementState dms;
    public Vector2 startLocation;
    public int pullDistance;
    // Start is called before the first frame update
    void Start()
    {
        dms = DepressionMovementState.Neutral;
        startLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        switch (dms)
        {
            case DepressionMovementState.Neutral:
                //trigger idle animation
                break;
            case DepressionMovementState.Attacking:
                //trigger pull in animation
                break;
            default:
                dms = DepressionMovementState.Neutral;
                //trigger idle animation
                break;
        }
    }

    public enum DepressionMovementState
    {
        Neutral,
        Attacking
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name + " entered the depression zone");
        dms = DepressionMovementState.Attacking;
    }

    private Vector2 v2;
    
    public void OnTriggerStay2D(Collider2D collision)
    {
        //pull tward center
        if(Mathf.Abs(collision.transform.position.x - transform.position.x) < pullDistance)
        {
            v2 = new Vector2(0, 0);
            
        }else if (Mathf.Abs(collision.transform.position.y - transform.position.y) < pullDistance)
        {

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.name + " exited the depression zone");
        dms = DepressionMovementState.Neutral;
    }
}
