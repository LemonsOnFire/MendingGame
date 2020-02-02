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
                break;
            case IsolationMovementState.Attacking:
                break;
            default:
                ims = IsolationMovementState.Neutral;
                break;
        }
    }

    public enum IsolationMovementState
    {
        Neutral,
        Attacking
    }
}
