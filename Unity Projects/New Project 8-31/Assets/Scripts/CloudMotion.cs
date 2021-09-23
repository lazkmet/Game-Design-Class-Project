using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMotion : MonoBehaviour
{
    public float speed = 1;
    public float rightEdge = 41;
    public float leftEdge = -12;
    // Update is called once per frame
    void Update()
    {
        Vector3 tempPosition = this.transform.position;
        if (this.transform.position.x >= rightEdge)
        {
            tempPosition.x = leftEdge;
        }
        else
        {
            tempPosition.x += speed * Time.deltaTime;
        }
        this.transform.position = tempPosition;
    }
}
