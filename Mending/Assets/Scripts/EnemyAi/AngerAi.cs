using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerAi : MonoBehaviour
{
    public AngerMovementState ams;
    Vector2 startLocation;
    public int chargeDistance;
    public int patrolDistance;
    bool playerInView;
    // Start is called before the first frame update
    void Start()
    {
        ams = AngerMovementState.Neutral;
        startLocation = transform.position;
        playerInView = false;
        inViewCount = 0;
    }
    int inViewCount;
    public int positionChangeModifier = 1;
    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        switch (ams)
        {
            case AngerMovementState.Neutral:
                //Trigger Walk Animation
                if (Random.Range(0, 1000) < 20 || !((position.x >= (startLocation.x - patrolDistance)) && (position.x <= (startLocation.x + patrolDistance))))
                {
                    transform.Rotate(0, 180, 0);
                    positionChangeModifier = positionChangeModifier * (-1);
                }
                transform.position = new Vector3(transform.position.x + (0.02f*positionChangeModifier), transform.position.y, transform.position.z);
                break;
            case AngerMovementState.Alert:
                //Trigger Alert Animation
                if (playerInView && inViewCount >= 10)
                {
                    ams = AngerMovementState.Charging;
                }
                break;
            case AngerMovementState.Charging:
                //Trigger Charge Animation
                transform.position = new Vector3(transform.position.x + (0.095f * positionChangeModifier), transform.position.y, transform.position.z);
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
        playerInView = true;
    }
    
    public void OnTriggerStay2D(Collider2D collision)
    {
        inViewCount = inViewCount + 1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.name + " exited charge zone");
        ams = AngerMovementState.Neutral;
        playerInView = false;
        inViewCount = 0;
    }
}

public enum AngerMovementState
{
    Neutral,
    Alert,
    Charging
}