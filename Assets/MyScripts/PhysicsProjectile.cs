using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsProjectile : MonoBehaviour
{
    private Rigidbody rb;
    public float shootForce;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * shootForce, ForceMode.Impulse);
        Destroy(gameObject, duration);
    }

    
}
