using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunsController : MonoBehaviour
{
     private float maximumZ =45.0f ; 
    private float minimumZ = -45.0f ;

    private float sensitivity = 5 ;

    private void moveGuns(){
        float _rotationZ = Input.GetAxis("Mouse Y") * sensitivity;
        _rotationZ =  Mathf.Clamp(_rotationZ, minimumZ,  maximumZ);
        transform.Rotate(0, 0, _rotationZ);
    }
    void Update()
    {
        moveGuns();
    }
}
