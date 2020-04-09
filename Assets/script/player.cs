using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 8;
    public Rigidbody rb;
    Vector3 movement;
    public GameObject bullet;
    public Transform gun;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.deltaTime * speed);
    }

    void Shoot()
    {
        GameObject BulletObject = Instantiate(bullet);
        BulletObject.transform.position = gun.position;
    }
}
