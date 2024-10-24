using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_1 : MonoBehaviour
{
    public delegate void ColisionCilindro();
    public static event ColisionCilindro OnCilindroCollision;
    void OnTriggerEnter(Collider collision) {
      if (collision.gameObject.tag == "Cubo") {
        OnCilindroCollision();
      }
    }
}
