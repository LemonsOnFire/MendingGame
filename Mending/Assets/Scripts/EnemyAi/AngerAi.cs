using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerAi : MonoBehaviour
{
    public AngerMovementState ams;
    Vector2 startLocation;
    public int chargeDistance;
    public int patrolDistance;
    // Start is called before the first frame update
    void Start()
    {
        ams = AngerMovementState.Neutral;
        startLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        switch (ams)
        {
            case AngerMovementState.Neutral:
                //Trigger Walk Animation
                if (Random.Range(0, 1000) < 1 || !((position.x >= (startLocation.x - patrolDistance)) && (position.x <= (startLocation.x + patrolDistance))))
                {
                    transform.Rotate(0, 180, 0);
                }
                break;
            case AngerMovementState.Alert:
                //Trigger Alert Animation
                break;
            case AngerMovementState.Charging:
                //Trigger Charge Animation

                break;
            default:
                ams = AngerMovementState.Neutral;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name + " entered charge zone");
        ams = AngerMovementState.Alert;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        //Don't know yet
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.name + " exited charge zone");
        ams = AngerMovementState.Neutral;
    }
}

public enum AngerMovementState
{
    Neutral,
    Alert,
    Charging
}