using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_zoomInOut : MonoBehaviour

{
    
    
    void Update() {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 ) {
            GetComponent<Camera>    ().fieldOfView-- ;
           
        }
         if (Input.GetAxis("Mouse ScrollWheel") < 0 ) {
            GetComponent<Camera>    ().fieldOfView++ ;
        }

       
    }
}
