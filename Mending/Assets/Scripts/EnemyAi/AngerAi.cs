using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerAi : MonoBehaviour
{
    public AngerMovementState ams;
    // Start is called before the first frame update
    void Start()
    {
        ams = AngerMovementState.Neutral;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum AngerMovementState
{
    Neutral,
    Alert,
    Charging
}