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
                break;
            case SwarmMovementState.Attacking:
                break;
            default:
                sms = SwarmMovementState.Neutral;
                break;
        }
    }

    public enum SwarmMovementState
    {
        Neutral,
        Attacking
    }
}
