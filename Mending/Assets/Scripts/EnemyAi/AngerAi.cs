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
                if (Random.Range(0, 1000) < 1 || !((position.x >= (startLocation.x - patrolDistance)) && (position.x <= (startLocation.x + patrolDistance))))
                {
                    transform.Rotate(0, 180, 0);
                }
                break;
            case AngerMovementState.Alert:
                break;
            case AngerMovementState.Charging:
                break;
            default:
                ams = AngerMovementState.Neutral;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name + "entered the depression zone");
        ams = AngerMovementState.Alert;
    }
}

public enum AngerMovementState
{
    Neutral,
    Alert,
    Charging
}