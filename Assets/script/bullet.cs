using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    public float LiftTime;
    public float LiftDuration = 5;
    // Start is called before the first frame update
    void Start()
    {
        LiftTime = LiftDuration;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speed);

        LiftTime -= Time.deltaTime;

        if (LiftTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
