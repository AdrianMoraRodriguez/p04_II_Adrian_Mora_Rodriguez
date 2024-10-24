using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_tp : MonoBehaviour
{
    public GameObject huevoObjetivo;
    GameObject esteObjeto;
    void Start() {
      ej4_notifier.OnAproximacionCubo += Teleportar;
      esteObjeto = this.gameObject;
    }

    // Update is called once per frame
    void Teleportar() {
      esteObjeto.GetComponent<Rigidbody>().MovePosition(huevoObjetivo.transform.position);
    }
}
