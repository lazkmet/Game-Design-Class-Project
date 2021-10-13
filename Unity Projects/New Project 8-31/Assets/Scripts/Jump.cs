using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody jumpingThing;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            Vector3 forceVector = Vector3.up * jumpForce;
            jumpingThing.AddForce(forceVector);
            print("Down");
        }
        else if (Input.GetButton("Jump")) {
            print("Held");
        }
        else if (Input.GetButtonUp("Jump")) {
            print("Up");
        }
    }
}
