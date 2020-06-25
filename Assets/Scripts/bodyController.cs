using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyController : MonoBehaviour
{

    //allows player to move the robot's body
    private float maximumY =45.0f ; 
    private float minimumY = -45.0f ;

    private float sensitivity = 5 ;

    private void moveBody(){
        float _rotationY = Input.GetAxis("Mouse X") * sensitivity;
        _rotationY =  Mathf.Clamp(_rotationY, minimumY, maximumY);
        transform.Rotate(0, _rotationY, 0);
    }

    void Update(){
        moveBody() ;
    }
}
