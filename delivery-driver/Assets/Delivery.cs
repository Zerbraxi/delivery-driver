using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour {

    // Check if player has package
    bool hasPackage = false;

    // Time for package to be destroyed upon pickup
    [SerializeField] float destroyDelay = 0.5f;


   void OnCollisionEnter2D(Collision2D other) {
    
    Debug.Log("Rekt!");

   }

    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Package" && !hasPackage)
        {
            // Player now has the package
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            Debug.Log("Package picked up!");
        }
        
        if (other.tag == "Customer" && hasPackage)
        {
            // Player no longer has package
            hasPackage = false;
            Debug.Log("Packaged delivered!");
        }
        
       

    }

}
