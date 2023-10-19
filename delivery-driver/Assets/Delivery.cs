using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour {

    // Check if player has package
    bool hasPackage = false;

    // Car color depending on package state
    [SerializeField] Color32 hasPackageColor = new Color32 (74,255,49,255);
    [SerializeField] Color32 noPackageColor = new Color32 (255,255,255,255);

    // Time for package to be destroyed upon pickup
    [SerializeField] float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        
        // Initlialize player color
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void OnCollisionEnter2D(Collision2D other) {

    Debug.Log("Rekt!");

   }

    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Package" && !hasPackage)
        {
            // Player now has the package
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
            Debug.Log("Package picked up!");
        }
        
        if (other.tag == "Customer" && hasPackage)
        {
            // Player no longer has package
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Debug.Log("Packaged delivered!");
        }
        
       

    }

}
