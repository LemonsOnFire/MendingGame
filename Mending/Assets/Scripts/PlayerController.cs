using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 8, ForceMode2D.Impulse);
            if (isGrounded)
            {
                jumpCount = 1;
            }
            else
            {
                jumpCount = jumpCount+1;
            }
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

}
