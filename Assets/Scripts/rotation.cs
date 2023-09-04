using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationspeed = 1f;
    
   
    void OnMouseDrag(){
        float XaxisRotation = Input.GetAxis("Mouse X") *rotationspeed;

        transform.Rotate(Vector3.down, XaxisRotation);
   
   
    }
}
