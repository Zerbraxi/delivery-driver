using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 12f;
    [SerializeField] float slowSpeed = 8f;
    [SerializeField] float boostSpeed = 18f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        
    }

    // Collision
    void OnCollisionEnter2D (Collision2D other)
    {

        // Check if collision is bump
        if (other.collider.tag == "Bump"){

            // Decrease movement speed
            moveSpeed = slowSpeed;

        }

    }

    // Boost
    void OnTriggerEnter2D(Collider2D other)
    {

        // Check if trigger is boost
        if (other.tag == "Boost") {

            // Increase movement speed
            moveSpeed = boostSpeed;
            Debug.Log("Super fast!");

        }

    }

}
