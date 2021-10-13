using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject CollisionParticle;
    public GameObject TriggerParticle;
    private void OnTriggerEnter(Collider other)
    {
        if (TriggerParticle != null) {
            Instantiate(TriggerParticle, this.transform.position, this.transform.rotation);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (CollisionParticle != null)
        {
            Instantiate(CollisionParticle, collision.contacts[0].point, this.transform.rotation);
        }
    }
}
