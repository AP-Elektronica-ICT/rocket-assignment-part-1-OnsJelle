using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float Speed = 5f;
    public float tiltPower = 5f;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * tiltPower;
        //float vertical = Input.GetAxis("Vertical") * Time.deltaTime * Speed;

        //Vector3 movement = new Vector3(horizontal, 0, vertical);
        //rb.MovePosition(transform.position + movement);
        float tilt = tiltPower * horizontal;

        transform.Rotate(new Vector3(tilt, 0, 0));

        //transform.Translate(0, 0, horizontal);

        //var normX = rb.transform.rotation.eulerAngles.normalized.x;
        if (Input.GetButtonDown("Jump"))
        {
            //rb.AddForce(new Vector3(tilt, 5, 0), ForceMode.Impulse);

            rb.AddRelativeForce(new Vector3(0, Speed, 0));

        }
    }
}