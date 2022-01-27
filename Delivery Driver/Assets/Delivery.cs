using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage;

   void OnCollisionEnter2D(Collision2D other) 
   {
       
   }

   void OnTriggerEnter2D(Collider2D other) 
   {
       if (other.tag == "Package")
       {
           Debug.Log ("Package Picked Up");
           hasPackage = true;
       }
       else if(other.tag == "Customer" && hasPackage == true)
       {
           Debug.Log("Package Delivered!");
           hasPackage = false;
       }
   }
}
