using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletContriller : MonoBehaviour
{
    public float speed = 8.0f;
    private Rigidbody bulletRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
        bulletRigidBody.velocity = transform.forward * speed;

        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playercontroller = other.GetComponent<PlayerController>();

            if(playercontroller != null )
            {
                playercontroller.Die();
            }
        }
    }
}
