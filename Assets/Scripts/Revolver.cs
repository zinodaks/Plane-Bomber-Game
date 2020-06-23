using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : MonoBehaviour
{

    private float timeCounter = 0 ;
    public float speed ; 
    private float width = 2000 ; 
    private float height = 2000; 

    private float verticalSpeed = 2.5f;  
    private  float amplitude = 200; 
    
    void FixedUpdate() { 
        timeCounter += Time.deltaTime * speed; 
        float x = Mathf.Cos(timeCounter) * width ; 
        float z = Mathf.Sin(timeCounter) * height; 
        float y =  (Mathf.Sin(Time.realtimeSinceStartup* verticalSpeed ) * amplitude ) + 750; 
        GetComponent<Rigidbody>().position = new Vector3(x , y , z);
        
    }
  
}
