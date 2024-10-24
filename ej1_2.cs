using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_2 : MonoBehaviour
{
    public GameObject objetivo;
    GameObject objeto;
    void Start() {
      ej1_1.OnCilindroCollision += MoverHaciaObjetivo;
      objeto = this.gameObject;      
    }

    // Update is called once per frame
    void MoverHaciaObjetivo() {
      Vector3 direccion = objetivo.transform.position - objeto.transform.position;
      objeto.GetComponent<Rigidbody>().AddForce(direccion.normalized * 10, ForceMode.Impulse);
    }
}
