using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_orientacion : MonoBehaviour
{
    public GameObject objetivo;
    void Start() {
      ej4_notifier.OnAproximacionCubo += Orientar;
    }

    // Update is called once per frame
    void Orientar() {
      Vector3 direction = objetivo.transform.position - transform.position;
      Quaternion targetRotation = Quaternion.LookRotation(direction);
      Debug.DrawRay(transform.position, direction, Color.red);
      transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5 * Time.deltaTime);
    }
}
