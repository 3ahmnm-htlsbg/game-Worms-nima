using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode forwardsKey;
    public KeyCode backwardsKey;
    public KeyCode downKey;
    public KeyCode shootKey;

    public Rigidbody rb;

    public Vector3 y;
    public Vector3 z;

    public Vector3 position;
    public Quaternion quat;



    public GameObject projectile;

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
            Debug.Log("Die Forwards Taste wurde gedrückt");
            rb.AddForce(z);
        }

        if (Input.GetKeyDown(backwardsKey))
        {
            Debug.Log("Die Backward Taste wurde gedrückt");
            rb.AddForce(-z);
        }

        if (Input.GetKeyDown(downKey))
        {
            Debug.Log("Die Down Taste wurde gedrückt");
            rb.AddForce(-y);
        }

        if (Input.GetKeyDown(shootKey))
        {
            Debug.Log("Die Shoot Taste wurde gedrückt");
            Instantiate(projectile, position, quat);

        }
    }
}
