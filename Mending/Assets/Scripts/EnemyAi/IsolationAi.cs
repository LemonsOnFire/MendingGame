using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsolationAi : MonoBehaviour
{
    public IsolationMovementState ims;
    Vector2 startLocation;
    public int maxDistance;
    public int patrolDistance;
    // Start is called before the first frame update
    void Start()
    {
        ims = IsolationMovementState.Neutral;
        startLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        switch (ims)
        {
            case IsolationMovementState.Neutral:
                if (Random.Range(0, 1000) < 1 || !((position.x >= (startLocation.x - patrolDistance)) && (position.x <= (startLocation.x + patrolDistance))))
                {
                    transform.Rotate(0, 180, 0);
                }

                break;
            case IsolationMovementState.Attacking:
                break;
            default:
                ims = IsolationMovementState.Neutral;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name + " entered isolation");
        ims = IsolationMovementState.Attacking;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        //Don't know yet
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.name + " no longer isolated");
        ims = IsolationMovementState.Neutral;
    }

    public enum IsolationMovementState
    {
        Neutral,
        Attacking
    }
}
