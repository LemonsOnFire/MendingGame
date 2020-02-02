﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector2 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //This is all about moving and jumping
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;

        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded==true || (canDoubleJump==true && jumpCount==1)))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 17, ForceMode2D.Impulse);
            if (isGrounded)
            {
                jumpCount = 1;
            }
            else
            {
                jumpCount = jumpCount+1;
            }
        }

        if (Input.GetKeyDown(KeyCode.Delete))
	{
            Die();
        }

    }

    //Below focuses on avoiding infinity jump but does jumps and double jumps

    public bool isGrounded;
    public bool canDoubleJump;
    public int jumpCount;

    void OnCollisionStay2D(Collision2D Other)
    {
        if (Other.collider.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D Other)
    {
        if (Other.collider.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
    //This lets us pick things up
    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "PickUp")
        {
            Other.gameObject.SetActive(false);
            Debug.Log("Test Dialogue Given");
        }
    }

    public void Die()
    {
        transform.position = spawnPoint;
    }


}
