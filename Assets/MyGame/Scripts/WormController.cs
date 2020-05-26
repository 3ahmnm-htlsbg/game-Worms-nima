using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode forwardsKey;
    public KeyCode backwardsKey;

    public Rigidbody rb;

    public Vector3 y;
    public Vector3 z;
    public ForceMode f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Die Jump Taste wurde gedrückt");
            rb.AddForce(y);
        }

        if (Input.GetKeyDown(forwardsKey))
        {
            Debug.Log("Die Forward Taste wurde gedrückt");
            rb.AddForce(z);
        }

        if (Input.GetKeyDown(backwardsKey))
        {
            Debug.Log("Die Backward Taste wurde gedrückt");
            rb.AddForce(-z);
        }

    }
}
