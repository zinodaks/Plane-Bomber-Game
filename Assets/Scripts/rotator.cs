using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    // Rotates the ammo prefab that spawns on the map to make it more attractive
    void Update() {
        transform.Rotate(new Vector3(0,0,30) * Time.deltaTime)  ;
    }
}
