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

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded==true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 6, ForceMode2D.Impulse);
        }

    }

    //Below focuses on avoiding infinity jump

    public bool isGrounded;

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

    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "PickUp")
        {
            Other.gameObject.SetActive(false);
            Debug.Log("Test Dialogue Given");
        }
    }

}
