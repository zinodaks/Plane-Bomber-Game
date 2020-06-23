using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    
    public float speed = 6f ; 
    private float horizontal ;
    private float vertical ; 
    private float xMin = -1900 ; 
    private float xMax = 1900 ; 
    private float zMin = -1900 ; 
    private float zMax = 1900 ; 

    public GameObject shot ; 
    public Transform shotSpawn1 ; 
    public Transform shotSpawn2 ; 
    public float fireRate ; 
    private float nextFire ;

    public int ammoCount = 20 ; 
    

 
    public void move() { 
        horizontal = Input.GetAxis("Horizontal") * speed;
        vertical = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        GetComponent<Rigidbody>().velocity = movement * speed;
        

        GetComponent<Rigidbody>().position = new Vector3(
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, xMin, xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, zMin, zMax));
        }
       
    
    public void shoot(){
      if(ammoCount > 0 ) {
       if (Input.GetButton("Fire1") && Time.time  > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot , shotSpawn1.position, shotSpawn1.rotation);
            Instantiate(shot , shotSpawn2.position, shotSpawn2.rotation);
            ammoCount -= 2 ; 
        }
      }
    }
  
    public GameObject ammoPrefab;
    private GameObject ammo;

    public void generateAmmo(){
      
        if(ammo == null){
          ammo =  Instantiate(ammoPrefab) ;
          float randomX = Random.Range(0,1900);
          float randomZ = Random.Range(0,1900);
          ammo.transform.position = new Vector3(randomX, 5.0f,randomZ);
        }
    }

     void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Ammo"))
        {
          ammoCount += 50 ;
          Destroy(other.gameObject);
        }
    }

    void Start()
    {
       
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

   void Update(){
     shoot();
     generateAmmo();
    
   }

    private void FixedUpdate() {  
      move();
    }

       void OnGUI()
    {
        int size = 30;
      
        GUIStyle style = new GUIStyle();
        style.fontSize=30;
        style.fontStyle = FontStyle.Bold;
        
        GUI.Label(new Rect(10,10, size, size), "Ammo: " + ammoCount,style);

    }
    
}
