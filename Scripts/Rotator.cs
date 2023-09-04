
// using UnityEngine;

// public class Rotator : MonoBehaviour
// {
//     [SerializeField] float rotationspeed = 100f;
//     bool dragging = false;
//     Rigidbody rb;
// //------------------------------------------------------  
//     void Start()
//     {
//         rb = GetComponent <Rigidbody> ();       

//     }
// //------------------------------------------------------
//     void OnMouseDrag() {
//         dragging = true;
//         //rotationspeed =
//     }
// //------------------------------------------------------  
//     void Update()
//     {
//         if (Input.GetMouseButtonUp (0)){
//             dragging = false;
          

//         }
//     }
// //------------------------------------------------------
//     void FixedUpdate() {
//     if (dragging){
//         float x = Input.GetAxis ("Mouse X")*rotationspeed;
        
//         float y = Input.GetAxis ("Mouse Y")*rotationspeed*Time.fixedDeltaTime;
       
        
//         rb.AddTorque (Vector3.down*x);
//        // rb.AddTorque (Vector3.right*y);
//     }     
//     }
// }
