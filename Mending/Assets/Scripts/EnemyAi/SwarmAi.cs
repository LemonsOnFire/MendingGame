using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmAi : MonoBehaviour
{
    public SwarmMovementState sms;
    Vector2 startLocation;
    public int maxDistance;
    public int patrolDistance;
    public int spreadSeed;
    // Start is called before the first frame update
    void Start()
    {
        sms = SwarmMovementState.Neutral;
        startLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        switch (sms)
        {
            case SwarmMovementState.Neutral:
                //Trigger patrolling Animation
                if (Random.Range(0, 1000) < 50 || !((position.x >= (startLocation.x - patrolDistance)) && (position.x <= (startLocation.x + patrolDistance))))
                {
                    transform.Rotate(0, 180, 0);
                }
                break;
            case SwarmMovementState.Attacking:
                //Trigger faster fly Animation
                break;
            default:
                sms = SwarmMovementState.Neutral;
                //Trigger patrolling Animation
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name + " entered the Swarm");
        sms = SwarmMovementState.Attacking;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        //Don't know yet
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.name + " left the swarm");
        sms = SwarmMovementState.Neutral;
    }

    public enum SwarmMovementState
    {
        Neutral,
        Attacking
    }
}
