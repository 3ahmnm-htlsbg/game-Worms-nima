using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Rigidbody rb1;
    //public Rigidbody rb2;
    // private Transform player;
    public GameObject respawnPoint1;
   // public GameObject respawnPoint2;



    void OnTriggerEnter(Collider groundBorder)
    {
       
        
        rb1.transform.position = respawnPoint1.transform.position;
       // rb2.transform.position = respawnPoint2.transform.position;
    }

}
