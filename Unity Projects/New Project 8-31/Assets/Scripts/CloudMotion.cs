using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMotion : MonoBehaviour
{
    public float speed = 1;
    // Update is called once per frame
    void Update()
    {
        Vector3 tempPosition = this.transform.position;
        tempPosition.x += speed * Time.deltaTime;
        this.transform.position = tempPosition;
    }
}
