using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage;
    [SerializeField] float delay;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(2,2,2,2);
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   void OnCollisionEnter2D(Collision2D other) 
   {
       
   }

   void OnTriggerEnter2D(Collider2D other) 
   {
       if (other.tag == "Package" && !hasPackage)
       {
           Debug.Log ("Package Picked Up");
           hasPackage = true;
           spriteRenderer.color = hasPackageColor;
           Destroy(other.gameObject, delay);
       }
       else if(other.tag == "Customer" && hasPackage == true)
       {
           Debug.Log("Package Delivered!");
           spriteRenderer.color = noPackageColor;
           hasPackage = false;
       }
   }
}
