using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement9 : MonoBehaviour
{
     public float speed = 2f;
    Rigidbody rb;
    void Start() {
      rb = this.GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate() {
      float moveH = Input.GetAxis("Horizontal");
      float moveV = Input.GetAxis("Vertical");
      if (moveH != 0 || moveV != 0) {
        Vector3 movement = new Vector3(moveH * speed * Time.deltaTime, 0, moveV * speed * Time.deltaTime);
        rb.AddForce(movement);
      }
    }
}
