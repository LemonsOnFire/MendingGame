﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerAi : MonoBehaviour
{
    public AngerMovementState ams;
    Vector2 startLocation;
    public int maxDistance;
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
}

public enum AngerMovementState
{
    Neutral,
    Alert,
    Charging
}