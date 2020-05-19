using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode forwardKey;
    public KeyCode backwardKey;

    public Rigidbody rb;

    public Vector3 y;
    public Vector3 z;
    public Vector3 negativez;
    public ForceMode f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Die Jump Taste wurde gedrückt");
            rb.AddForce(y,f);
        }

        if (Input.GetKeyDown(forwardKey))
        {
            Debug.Log("Die Forward Taste wurde gedrückt");
            rb.AddForce(z, f);
        }

        if (Input.GetKeyDown(backwardKey))
        {
            Debug.Log("Die Backward Taste wurde gedrückt");
            rb.AddForce(negativez, f);
        }

    }
}
