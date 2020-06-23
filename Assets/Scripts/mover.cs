using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed ; 

    public AudioSource missile ; 
    
    void Start() {

        GetComponent<Rigidbody>().velocity = transform.forward * speed; 
        missile.Play();

    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("enemyPlane")) {
            other.GetComponent<Rigidbody>().useGravity = true ; 
           // Destroy(other.gameObject) ;
            Destroy(this);
        }
    }
}
