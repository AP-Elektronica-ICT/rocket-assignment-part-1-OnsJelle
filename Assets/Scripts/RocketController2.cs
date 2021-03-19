using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController2 : MonoBehaviour
{
    [SerializeField] float thrustF = 10f;
    [SerializeField] float tiltingF = 10f;

    bool thrust = false;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.Space);

        if(!Mathf.Approximately(tilt,0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f, 0f, (tilt * tiltingF * Time.deltaTime))));
        }

        rb.freezeRotation = false;

        if (thrust)
        {
            rb.AddRelativeForce(Vector3.up * thrustF * Time.deltaTime);
        }
    }
}
